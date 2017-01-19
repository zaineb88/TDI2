--Q1

create database FORMATEC

use FORMATEC

create table Societé(codesocieté int primary key,nomsocieté nvarchar(20),
adressesocieté nvarchar(30))

create table Candidat(numerocandidat int primary key, nomcandidat nvarchar(20),
prenomcandidat nvarchar(20),datedenaissancecandidat date,codesocieté int foreign key
references Societé(codesocieté))

create table Inscrit(numerocandidat int foreign key references Candidat(numerocandidat),
dateinscription date,numerosesssion int foreign key references Session
(numerodesession), constraint C_PK primary key
(numerocandidat,numerosesssion))

create table Stage(numerostage int primary key,intituléstage nvarchar(20))

create table Session(numerodesession int primary key,datedebutsession date,
datefinsession date,numerostage int foreign key references Stage(numerostage))

create table Formateur(codeformateur int primary key, nomformateur nvarchar(20),
prenomformateur nvarchar(20),adresseformateur nvarchar(30),datenaissance date)

create table Module(numeromodule int primary key,nommodule nvarchar(20),
massehoraireprevue int ,codeformateur int foreign key references Formateur(codeformateur))

create table Composition(numerostage int foreign key references Stage(numerostage),
codemodule int foreign key references Module(numeromodule), constraint C_PK2 primary key 
(numerostage,codemodule))

create table Enseigne(codemodule int foreign key references Module(numeromodule),
codeformateur int foreign key references Formateur(codeformateur),numerodesession int foreign key 
references Session(numerodesession),constraint C_PK3 primary key(codemodule,codeformateur,
numerodesession))

insert into Societé values(1,'laraprint','larache')
insert into Candidat values(1,'mazouz','zaineb','10/10/1988',1)
insert into Stage values(1,'radeel')
insert into Session values(1,'08/09/2014','02/06/2015',1)
insert into Inscrit values(1,'02/05/2014',1)
insert into Module values(1,'SGBD',150,1)
insert into Composition values(1,1)
insert into Enseigne values(1,1,1)
insert into Formateur values(1,'alilou','saad','tanger','08/08/1988')

--Q2

create procedure Q2 (@numerostage int,@nb int output)
as
select @nb=count(numerocandidat) from dbo.Inscrit inner join dbo.Session on 
dbo.Inscrit.numerosesssion=dbo.Session.numerodesession
group by numerostage

declare @nbcan int
execute dbo.Q2 1,@nbcan output
print @nbcan

--Q3

create trigger Q3 on dbo.Module
for update
as
begin
if(select massehoraireprevue from inserted)<(select massehoraireprevue from deleted )
begin
rollback
print'imposible diminuer la masse horaire'
end
end

--Q4

create procedure Q4 (@nstage int)
as
select * from dbo.Session where datedebutsession>getdate() and @nstage=numerostage

execute dbo.Q4 1

--Q5

create trigger Q5 on dbo.Enseigne
for insert
as
  begin
  declare @formateur int, @session int,@date date
  select @formateur=codeformateur from inserted
  select @session=numerodesession from inserted
  select @date=datedebutsession from inserted inner join dbo.Session
 on dbo.Session.numerodesession=inserted.numerodesession
 
 if(exists(select*from dbo.Enseigne inner join dbo.Session on 
 dbo.Session.numerodesession=dbo.Enseigne.numerodesession where 
 @formateur=codeformateur and @session <>dbo.Session.numerodesession
 and @date=datedebutsession))
 begin
 rollback
 end
 end 
 
 --Q6
 
 create procedure Q6 (@dated date,@datef date)
 as
 select* from dbo.Module inner join dbo.Enseigne on dbo.Enseigne.codemodule=dbo.Module.numeromodule
  inner join dbo.Session on 
 dbo.Session.numerodesession=dbo.Enseigne.numerodesession
 where datedebutsession=@dated and datefinsession=@datef
 
 --Q7
 
 create function scalaire_Q7 (@numstage int)
 returns nvarchar(70)
 as
 begin
   declare @nbModule int, @nbFormateur int
  select @nbModule=count(codemodule)
  from dbo.Composition where @numstage=numerostage
  select @nbFormateur=count(codeformateur)from dbo.Composition inner join dbo.Module
  on dbo.Module.numeromodule=dbo.Composition.codemodule
  where @numstage=numerostage 
  return convert(varchar(30),@nbModule)+' '+ convert(varchar(30),@nbFormateur)
  end
  
print dbo.scalaire_Q7 (1)

-------------------------------------

create function totalcandidats (@nstage int)
returns int
as
begin
declare @total int
select @total=count(numerocandidat) from dbo.Inscrit inner join Session on
dbo.Inscrit.numerosesssion=dbo.Session.numerodesession
where numerostage=@nstage
group by numerostage
return @total
end



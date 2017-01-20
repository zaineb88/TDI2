Create database TPClientServeur
use TPClientServeur
Create table Module(Num_Mod int primary key,Nom_Mod nvarchar(30))
Create table Stagiaire(Num_Sta int primary key,Nom_Sta nvarchar(30),Pre_Sta nvarchar(30),
Date_Sta datetime)
Create table Notes(Num_Sta int foreign key references Stagiaire(Num_Sta),Num_Mod int foreign key references Module(Num_Mod),
Note float,Constraint SM primary key(Num_Sta,Num_Mod))

----------------------------------------


Create trigger T1 on dbo.Stagiaire
after insert
as
declare @codestag int
set @codestag=(select Num_Sta from inserted)
insert into dbo.Notes
values(@codestag,1,null)
insert into dbo.Notes values (@codestag,2,null)
insert into dbo.Notes values (@codestag,3,null)
insert into dbo.Notes values (@codestag,4,null)

Create trigger T2 on dbo.Stagiaire
instead of delete
as
declare @codestag int
set @codestag=(select Num_Sta from deleted)
delete from dbo.Notes where Num_Sta=@codestag
delete from dbo.Stagiaire where Num_Sta=@codestag

-------------------------------

create view Vue3 as SELECT        dbo.Notes.Num_Sta, dbo.Module.Num_Mod, dbo.Module.Nom_Mod, dbo.Notes.Note
FROM            dbo.Module INNER JOIN
                         dbo.Notes ON dbo.Module.Num_Mod = dbo.Notes.Num_Mod
                         
                         
-------------------------------


alter procedure Bulltin 
as
select dbo.Stagiaire.Num_Sta,Nom_Sta,Pre_Sta,dbo.Module.Num_Mod,Nom_Mod,Note from dbo.Stagiaire inner join 
dbo.Notes on 
dbo.Stagiaire.Num_Sta=dbo.Notes.Num_Sta inner join dbo.Module on 
dbo.Notes.Num_Mod=dbo.Module.Num_Mod
                                                 


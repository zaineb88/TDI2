<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Mise à jour du module" 
        Font-Bold="True" Font-Size="X-Large" ForeColor="#000066"></asp:Label>
<br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" DataKeyNames="numeromodule" DataSourceID="SqlDataSource1" 
    GridLines="Vertical" 
    onselectedindexchanging="GridView1_SelectedIndexChanging">
    <AlternatingRowStyle BackColor="#DCDCDC" />
    <Columns>
        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        <asp:CommandField ButtonType="Button" ShowEditButton="True" />
        <asp:TemplateField ShowHeader="False">
            <ItemTemplate>
                <asp:Button ID="Button1" runat="server" CausesValidation="False" 
                    CommandName="Delete" OnClientClick="return confirm('Vous voulez vraiment supprimer ce module?');" Text="Supprimer" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="numeromodule" HeaderText="numeromodule" 
            ReadOnly="True" SortExpression="numeromodule" />
        <asp:BoundField DataField="nommodule" HeaderText="nommodule" 
            SortExpression="nommodule" />
        <asp:BoundField DataField="massehoraireprevue" HeaderText="massehoraireprevue" 
            SortExpression="massehoraireprevue" />
        <asp:BoundField DataField="codeformateur" HeaderText="codeformateur" 
            SortExpression="codeformateur" />
    </Columns>
    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#0000A9" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#000065" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:FORMATECConnectionString4 %>" 
    DeleteCommand="DELETE FROM [Module] WHERE [numeromodule] = @numeromodule" 
    InsertCommand="INSERT INTO [Module] ([numeromodule], [nommodule], [massehoraireprevue], [codeformateur]) VALUES (@numeromodule, @nommodule, @massehoraireprevue, @codeformateur)" 
    SelectCommand="SELECT * FROM [Module]" 
    UpdateCommand="UPDATE [Module] SET [nommodule] = @nommodule, [massehoraireprevue] = @massehoraireprevue, [codeformateur] = @codeformateur WHERE [numeromodule] = @numeromodule">
    <DeleteParameters>
        <asp:Parameter Name="numeromodule" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="numeromodule" Type="Int32" />
        <asp:Parameter Name="nommodule" Type="String" />
        <asp:Parameter Name="massehoraireprevue" Type="Int32" />
        <asp:Parameter Name="codeformateur" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="nommodule" Type="String" />
        <asp:Parameter Name="massehoraireprevue" Type="Int32" />
        <asp:Parameter Name="codeformateur" Type="Int32" />
        <asp:Parameter Name="numeromodule" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
<br />
<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
    Text="Filtrer" />
<br />
<asp:Panel ID="Panel1" runat="server" Visible="False">
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Tous" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
        Text="Par Numero" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
        Text="Par Nom" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</asp:Panel>
<br />
<asp:Panel ID="Panel2" runat="server" Visible="False">
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" 
        Text="La liste des formateurs du module sélectionner"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="GridView2" runat="server" BackColor="White" 
        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="1" 
        GridLines="Vertical">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
</asp:Panel>
<br />
</asp:Content>


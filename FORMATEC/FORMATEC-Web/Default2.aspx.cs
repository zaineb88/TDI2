using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    
    { 
        try{
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=FORMATEC;Integrated Security=True");
        SqlCommand cmd = new SqlCommand("insert into dbo.Module values("+TextBox1.Text+",'"+TextBox2.Text+"',"+TextBox3.Text+","+TextBox4.Text+")",cnx);

        cnx.Open();
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('bien Ajouter')</script>");
        cnx.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        }
        catch { Response.Write("<script>alert('ERREUR: ce numero du modele est déja existe ou le code formateur n'existe pas' )</script>"); }

        
        
    }
}
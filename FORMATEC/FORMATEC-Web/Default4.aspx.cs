using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlDataSource1.SelectCommand = "select *from Module";
        TextBox1.Text = "";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try{
        SqlDataSource1.SelectCommand = "select *from Module where numeromodule=" + TextBox1.Text;
          }
        catch (Exception Ex) { Response.Write(Ex.Message); }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            SqlDataSource1.SelectCommand = "select *from Module where nommodule LIKE'" + TextBox1.Text + "%'";
        }
        catch (Exception Ex) { Response.Write(Ex.Message); }
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        Panel2.Visible = true;
        Session["key"]=GridView1.Rows[e.NewSelectedIndex].Cells[3].Text;
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=FORMATEC;Integrated Security=True");
        SqlCommand cmd = new SqlCommand("select dbo.Formateur.codeformateur, nomformateur, prenomformateur, adresseformateur, datenaissance from dbo.Formateur inner join dbo.Enseigne on dbo.Formateur.codeformateur=dbo.Enseigne.codeformateur inner join dbo.Module on dbo.Enseigne.codemodule=dbo.Module.numeromodule where dbo.Enseigne.codemodule=" + Session["key"], cnx);
        //cnx.Open();
        //SqlDataReader red = cmd.ExecuteReader();

        //GridView2.DataSource = red;
        //GridView2.DataBind();
        //cnx.Close();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "0");
        GridView2.DataSource = ds;
        GridView2.DataBind();


    }
}
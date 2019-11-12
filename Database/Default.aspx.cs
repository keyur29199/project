using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{

    static SqlConnection con;
    static SqlCommand cmd;
    static SqlDataAdapter da;
    static DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Anjna\Database\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        cmd = new SqlCommand("select * from stud", con);
        con.Open();
        Repeater2.DataSource = cmd.ExecuteReader();
        Repeater2.DataBind();
        con.Close();
    }
}

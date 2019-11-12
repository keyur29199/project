using System;
using System.Collections;
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
using System.Web.Configuration;

public partial class DataImage : System.Web.UI.Page
{
    static string x;
    static SqlConnection con;
    static SqlCommand cmd;


    protected void Page_Load(object sender, EventArgs e)
    {
        x = WebConfigurationManager.ConnectionStrings["x"].ConnectionString;
        con = new SqlConnection(x);
    }

    int getNewProductId()
    {

        string sql = "select max(id) from product";

        cmd = new SqlCommand(sql, con);
        con.Open();
        object o = cmd.ExecuteScalar();


        int id;
        if (o.ToString() == "")
            id = 1;
        else
            id = Convert.ToInt32(o) + 1;

        con.Close();

        return id;


    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
       add();
    }
    public void add()
    {

        if (FileUpload1.HasFile)
        {
            //getting length of uploaded file  
            int length = FileUpload1.PostedFile.ContentLength;
            //create a byte array to store the binary image data  
            byte[] imgbyte = new byte[length];
            //store the currently selected file in memeory  
            HttpPostedFile img = FileUpload1.PostedFile;
           
            //set the binary data  
            img.InputStream.Read(imgbyte, 0, length);
            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            string imgQty = txtQty.Text;
            string imgPrice = txtPrice.Text;
            string imgType;

            imgType = FileUpload1.PostedFile.ContentType;

            //Connection String  
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Anjna\Database\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
            //Open The Connection  
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO product VALUES (@id,@Name,@img,@imgType,@qty,@price)", connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = name;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = imgbyte;
            cmd.Parameters.Add("@imgType", SqlDbType.VarChar, 30).Value = imgType;
            cmd.Parameters.Add("@qty", SqlDbType.Int).Value = imgQty;
            cmd.Parameters.Add("@price", SqlDbType.Int).Value = imgPrice;

            int count = cmd.ExecuteNonQuery();
            //Close The Connection  
            connection.Close();
            if (count == 1)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertmessage", "javascript:alert('Record added successfully')", true);
                //call the method to bind the grid  
                GridView1.DataBind();
            }
        }
    }
}

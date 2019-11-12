<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");


        string x = WebConfigurationManager.ConnectionStrings["x"].ConnectionString;
        SqlConnection con = new SqlConnection(x);
        string id = context.Request.QueryString["id"];
        string sql = "select image,imageType from product where id = " + id;

        SqlCommand cmd = new SqlCommand(sql, con);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();

        context.Response.ContentType = dr["image"].ToString();
        byte[] img = (byte[]) dr["image"];
        int imgLength = img.Length;

        context.Response.OutputStream.Write(img, 0, imgLength);
        dr.Close();
        con.Close();
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
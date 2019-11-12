<%@ WebHandler Language="C#" Class="Handler2" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class Handler2 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {
       
        string imageid = context.Request.QueryString["id"];
        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Anjna\Database\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        connection.Open();
        SqlCommand command = new SqlCommand("select Image from product where id='" + imageid + "' ", connection);
        SqlDataReader dr = command.ExecuteReader();
        dr.Read();
        context.Response.BinaryWrite((Byte[])dr[0]);
        connection.Close();
        context.Response.End();
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }  

}
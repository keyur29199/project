using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void btn_Click(object sender, EventArgs e)
    {

        if (fui.PostedFile.ContentType == "image/jpeg")
        {

            fui.SaveAs(@"E:\keyur mistry" + fui.FileName);

            Label1.Text = "file name :" + fui.FileName;
            //Response.Write("file type :"+);
            Label2.Text = "file size :"+fui.FileBytes.Length;
            Label3.Text = "file uploaded";

        }
        else
        {

            Label1.Text="this file is not image";

        }
    }
}
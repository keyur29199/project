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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert Message", "alert('Image button Clicked')", true);
    }
    protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
    {
        Response.Write("Hi," + e.PostBackValue);
    }
    protected void ImageMap2_Click(object sender, ImageMapEventArgs e)
    {
        Response.Write("Hi," + e.PostBackValue);
    }
    protected void ImageMap3_Click(object sender, ImageMapEventArgs e)
    {
        Response.Write("Hi," + e.PostBackValue);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
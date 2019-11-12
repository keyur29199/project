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
    protected void btnsend_Click(object sender, EventArgs e)
    {
        HttpCookie Cookie = new HttpCookie("Username");
        Cookie.Value = txtUsername.Text;
        Cookie.Expires = DateTime.Now.AddHours(1);
        Response.Cookies.Add(Cookie);
        Response.Redirect("Default2.aspx");  
    }
}
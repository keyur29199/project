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

public partial class WebCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie c = Request.Cookies["user"];
        if (c == null)
            Label1.Text = "Welcome Guest";
        else
            Label1.Text = "Welcome : " + c.Value;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie c1 = new HttpCookie("c1", "Cookie-1");
        c1.Expires = DateTime.Now.AddDays(1);

        HttpCookie c2 = new HttpCookie("c2", "Cookie-2");
        c2.Expires = DateTime.Now.AddDays(1);

        Response.Cookies.Add(c1);
        Response.Cookies.Add(c2);

        

        for (int i = 0; i < Request.Cookies.Count; i++)
        {
            Response.Write("<br> <b> Cookie-" + (i +1) +"<br>");
            Response.Write("<br> Name = : " + Request.Cookies[i].Name);
            Response.Write("<br> Value = : " + Request.Cookies[i].Value);
            Response.Write("<br> Expires on : " + Request.Cookies[i].Expires.ToShortDateString());
            Response.Write("<hr>");
        }

        Response.Write("<h3> Total Cookies : " + Request.Cookies.Count.ToString() + "</h3><hr>");
        //  c1.Expires = DateTime.Now;
       // c2.Expires = DateTime.Now;
    }
}

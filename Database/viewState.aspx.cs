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

public partial class viewState : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnClick_Click(object sender, EventArgs e)
    {
        int c;
        if (ViewState["counter"] == null)
        {
            c = 1;
            ViewState["counter"] = c;
        }
        else {

            c = Convert.ToInt32(ViewState["counter"]) + 1;
            ViewState["counter"] = c;
        }
        Label1.Text = "Counter : " + c.ToString();
    }
    protected void linkCreate_Click(object sender, EventArgs e)
    {
        HttpCookie c = new HttpCookie("user");
       // c1.Name = txtUnm.Text;
        if (txtUnm.Text.Length == 0)
            c.Value = "Unknown";
        else
            c.Value = txtUnm.Text;

        c.Expires = DateTime.Now.AddMilliseconds(60);
        Response.Cookies.Add(c);
        Response.Redirect("WebCookie.aspx");
        
    }
}

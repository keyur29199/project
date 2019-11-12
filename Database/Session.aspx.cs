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

public partial class Session : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnClick_Click(object sender, EventArgs e)
    {
        string unm = txtUnm.Text;
        string pwd = txtPass.Text;
        if (unm == "ABC" && pwd == "123")
            Session["user"] = unm;
        Response.Redirect("WelcomeSession.aspx");

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtPass.Text = "";
        txtUnm.Text = "";
    }
}

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
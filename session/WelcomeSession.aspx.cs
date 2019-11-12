﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WelcomeSession : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
            lblUser.Text = "Welcome GUEST";
        else
            lblUser.Text = "Welcome : " + Session["user"].ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        Session.Abandon();
        Response.Redirect("WelcomeSession.aspx");
    }
}
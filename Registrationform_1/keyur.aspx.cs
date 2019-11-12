using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class keyur : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ddstate.SelectedValue == "Gujarat")
        {
            ddcity.Items.Clear();
            ddcity.Items.Add("Rajkot");
            ddcity.Items.Add("Ahemdabad");
            ddcity.Items.Add("surat");
        }

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddstate.SelectedValue== "Gujarat")
        {
            ddcity.Items.Clear();
            ddcity.Items.Add("Rajkot");
            ddcity.Items.Add("Ahemdabad");
            ddcity.Items.Add("surat");
        }
        else if (ddstate.SelectedValue == "Maharastra")
        {
            ddcity.Items.Clear();
            ddcity.Items.Add("pune");
            ddcity.Items.Add("Amravati");
            ddcity.Items.Add("bombay");
        }
        else if (ddstate.SelectedValue == "Rajasthan")
        {
            ddcity.Items.Clear();
            ddcity.Items.Add("Jodhpur");
            ddcity.Items.Add("Ajmer");
            ddcity.Items.Add("Udaypur");
        }
        else
        {
            ddcity.Items.Clear();
        }
   
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (fupload.HasFile)
        {
            fupload.SaveAs(@"E:\keyur mistry\" + fupload.FileName);
            lblMessage.Text = "file uploaded:" + fupload.FileName;

        }
        else
        {
            lblMessage.Text = "NO FILE UPLOADED>>>>";
        }
    }
}
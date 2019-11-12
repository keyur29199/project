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

        if (ddstate.SelectedValue == "Gujarat")
        {
            ddcity.Items.Clear();
            ddcity.Items.Add("Rajkot");

        }
    }
    protected void ddstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddstate.SelectedValue == "Gujarat")
        {
            ddcity.Items.Clear();
            ddcity.Items.Add("Rajkot");
            ddcity.Items.Add("Gondal");
            ddcity.Items.Add("Junagadh");
        }
        else if (ddstate.SelectedValue == "Rajashthan")
        {
            ddcity.Items.Clear();
            ddcity.Items.Add("Jaipur");
            ddcity.Items.Add("Jodhpur");
            ddcity.Items.Add("Udaipur");
        }
        else if (ddstate.SelectedValue == "Maharashtra")
        {
            ddcity.Items.Clear();
            ddcity.Items.Add("Mumbai");
            ddcity.Items.Add("PUne");
            ddcity.Items.Add("Nagpur");
        }
       
    }
    protected void btnsub_Click(object sender, EventArgs e)
    {
        btnsub.Text = " Record Succefully Inserted";
    }
    protected void TextBoxnm_TextChanged(object sender, EventArgs e)
    {
       
    }
}
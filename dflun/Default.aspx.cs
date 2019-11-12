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
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton1.Checked = true;
        
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

        RadioButton2.Checked = true;
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            ListBox1.Items.Add(CheckBox1.Text);
        }
        else {

            ListBox1.Items.Remove(CheckBox1.Text);

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked)
        {

            lblMessage.Text = RadioButton1.Text;
        }
        else
        {

            lblMessage.Text = RadioButton2.Text;
        
        }
       
    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox2.Checked)
        {
            ListBox1.Items.Add(CheckBox2.Text);
        }
        else
        {

            ListBox1.Items.Remove(CheckBox2.Text);

        }
    }
    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox3.Checked)
        {
            ListBox1.Items.Add(CheckBox3.Text);
        }
        else
        {

            ListBox1.Items.Remove(CheckBox3.Text);

        }
    }
    protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox4.Checked)
        {
            ListBox1.Items.Add(CheckBox4.Text);
        }
        else
        {

            ListBox1.Items.Remove(CheckBox4.Text);

        }
    }
}
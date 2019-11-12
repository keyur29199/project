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
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        DateTime d;
        for (int i = 0; i < Calendar1.SelectedDates.Count; i++)
        {
            d = Calendar1.SelectedDates[i];
            BulletedList1.Items.Add("Date is :" + d.ToString());   
        }

    }


}
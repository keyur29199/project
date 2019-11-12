using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Customer_Care : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder bldr;
        public main main;
        public Customer_Care()
        {
            InitializeComponent();
        }

        private void Customer_Care_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnm.Text == "")
            {
                MessageBox.Show("Name is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtcno.Text == "")
            {
                MessageBox.Show("Contect number is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txta.Text == "")
            {
                MessageBox.Show("Address is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (richtxtc.Text == "")
            {
                MessageBox.Show("Complaint is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\madi\login\login\prodb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                da = new SqlDataAdapter("SELECT * FROM table_Ccare", cn);
                bldr = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "table_Ccare");
                DataRow dr = ds.Tables["table_Ccare"].NewRow();
                dr["C_nm"] = txtnm.Text;
                dr["C_no"] = txtcno.Text;
                dr["C_address"] = txta.Text;
                dr["Complain"] = richtxtc.Text;
                ds.Tables["table_Ccare"].Rows.Add(dr);
                da.Update(ds, "table_Ccare");


                //this.Close();
                MessageBox.Show("Complaint is save", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }

        }

     
    }
}

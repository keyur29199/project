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
    public partial class PassengerDetail : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder bldr;

        public PassengerDetail()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtpid.Text == "")
            {
                MessageBox.Show("Passenger Id is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtnm.Text == "")
            {
                MessageBox.Show("Name is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtage.Text =="")
            {
                MessageBox.Show("Age is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtcno.Text == "")
            {
                MessageBox.Show("Contect number is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\madi\login\login\prodb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                da = new SqlDataAdapter("SELECT * FROM table_pdetail", cn);
                bldr = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "table_pdetail");
                DataRow dr = ds.Tables["table_pdetail"].NewRow();
                dr["P_id"] = Convert.ToInt32(txtpid.Text);
                dr["P_nm"] = txtnm.Text;
                dr["P_age"]  =  txtage.Text;
                dr["C_no"]  =   txtcno.Text;
                ds.Tables["table_pdetail"].Rows.Add(dr);
                //da.Update(ds,"table_pdetail");

                
                this.Close();
                MessageBox.Show("RESERVATION SUCCESSFUL", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                main m = new main();
                this.Hide();
                m.Show();
            }


        }

        private void PessengerDetail_Load(object sender, EventArgs e)
        {

        }

        private void lblpd_Click(object sender, EventArgs e)
        {

        }
    }
}

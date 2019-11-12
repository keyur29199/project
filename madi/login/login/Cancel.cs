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
    public partial class Cancel : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        string cmdstr;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder bldr;
        public Cancel()
        {
            InitializeComponent();
        }

       
        private void Cancel_Load(object sender, EventArgs e)
        {

            //cn = new SqlConnection(Program.cnstr);
            //cn.Open();
        }

        private void btnc_Click(object sender, EventArgs e)
        {



            if (txtnm.Text == "")
            {
                MessageBox.Show("Passenger Name is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbtno.Text == "")
            {
                MessageBox.Show("Train no is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbtnm.Text == "")
            {
                MessageBox.Show("Train name is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbs.Text == "")
            {
                MessageBox.Show("Source is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbd.Text == "")
            {
                MessageBox.Show("Destination is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbvia.Text == "")
            {
                MessageBox.Show("via is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdt.Text == "")
            {
                MessageBox.Show("Departure time is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbct.Text == "")
            {
                MessageBox.Show("Class type is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (jd1.Text == "")
            {
                MessageBox.Show("Journy date is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (jd2.Text == "")
            {
                MessageBox.Show("Journy month is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (jd3.Text == "")
            {
                MessageBox.Show("Journy year is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtfare.Text == "")
            {
                MessageBox.Show("Fare(RS) is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtsno.Text == "")
            {
                MessageBox.Show("Seat no is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\madi\login\login\prodb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                da = new SqlDataAdapter("delete from table_book where P_id", cn);
                //cmdstr = "delete from reservation where table_cancel";
                bldr = new SqlCommandBuilder(da);
                ds = new DataSet();
                MessageBox.Show("Data Cancel Succsessfuly", "Add", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }


            
        
        
public  main main { get; set; }}



    }

    


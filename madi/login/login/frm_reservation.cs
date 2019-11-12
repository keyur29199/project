using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using login;

namespace loginform
{
    public partial class frm_reservation : Form
    {
       // SqlConnection con;
        //SqlCommand cmd;
       // string cmdstr;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder bldr;
        login.DBclass c1 = new login.DBclass();
        public login.main main;
       
        public frm_reservation()
        {
            InitializeComponent();
        }
        

       
        public void fillGrid()
        {

            da = new SqlDataAdapter("select * from table_book", new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\madi\Documents\prodb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"));
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        private void btnbook_Click(object sender, EventArgs e)
        {

            if (cbtno.Text == "")
            {
                MessageBox.Show("Train no is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbtnm.Text == "")
            {
                MessageBox.Show("Train name is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdt.Text == "")
            {
                MessageBox.Show("Departure time is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (cbct.Text == "")
            {
                MessageBox.Show("Class type is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                 //PessengerDetail pd = new PessengerDetail();
                 //this.Hide();
                 //pd.Show();
                 SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\madi\Documents\prodb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                 da = new SqlDataAdapter("SELECT * FROM table_book",cn);
                 bldr = new SqlCommandBuilder(da);
                 ds = new DataSet();
                 da.Fill(ds, "table_book");

                 DataRow dr = ds.Tables["table_book"].NewRow();
                 dr["T_no"] = Convert.ToInt32(cbtno.Text);
                 dr["T_nm"] = cbtnm.Text;
                 dr["J_date"] = jd1.Text;
                 dr["J_month"] = jd2.Text;
                 dr["j_year"] = jd3.Text;
                 dr["D_time"] = txtdt.Text;
                 dr["Source"] = cbs.Text;
                 dr["Desti"] = cbd.Text;
                 dr["Via"] = cbvia.Text;
                 dr["C_type"] = cbct.Text;
                 dr["Fare"] = Convert.ToInt32(txtfare.Text);
                 dr["S_no"] = Convert.ToInt32(txtsno.Text);
                 ds.Tables["table_book"].Rows.Add(dr);
                 da.Update(ds, "table_book");
                 MessageBox.Show("Data Book Succsessfuly", "Add", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                 fillGrid();


             }
        }

      

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodbDataSet.table_book' table. You can move, or remove it, as needed.
            this.table_bookTableAdapter.Fill(this.prodbDataSet.table_book);

        }

        private void btnnxt_Click(object sender, EventArgs e)
        {
            if (cbtno.Text == "")
            {
                MessageBox.Show("Train no is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbtnm.Text == "")
            {
                MessageBox.Show("Train name is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdt.Text == "")
            {
                MessageBox.Show("Departure time is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (cbct.Text == "")
            {
                MessageBox.Show("Class type is empty", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                PassengerDetail pd = new PassengerDetail();
                this.Hide();
                pd.Show();
                fillGrid();
            }

        }
        

     
        }
    }

      

        
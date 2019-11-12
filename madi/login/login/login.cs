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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\madi\Documents\prodb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string query = "select * from table_login where Userid='" + txtunm.Text + "'and Password='" + txtpwd.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                main objmain = new main();
                this.Hide();
                objmain.Show();

            }
            else
            {
                MessageBox.Show("Check your Username or Password");
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }





        public main main { get; set; }
    }
}

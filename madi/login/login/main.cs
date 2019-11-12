using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using loginform;

namespace login
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            login l = new login();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reservation r = new frm_reservation();
            r.main = this;
            r.Show();
        }

       private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel c = new Cancel();
            c.main = this;
            c.Show();
        }

        private  void customerCareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Care cc = new Customer_Care();
            cc.main = this;
            cc.Show();
        }

        private void informathionMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map m = new Map();
            m.main = this;
            m.Show();
        }

        private void contectUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contectus cu = new Contectus();
            cu.main = this;
            cu.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.main = this;
            l.Show();
        }

      
      

    }
}

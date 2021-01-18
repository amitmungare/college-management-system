using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            String name = txtfullname.Text;
            String password = txtPassword.Text;          
            Int64 moblie = Int64.Parse(txtmoblienum.Text);
            String email = txtemailid.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8; database =college; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Admin (fname,pword,moblie,email) values ('" + name + "','" + password + "'," + moblie + ",'" + email + "')";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            MessageBox.Show("Data submitted.", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfullname.Clear();
            txtPassword.Clear();
            txtmoblienum.Clear();
            txtemailid.Clear();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Scholarship : Form
    {
        public Scholarship()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =LAPTOP-T2JA1MM8; database=college;integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con; ;
            cmd.CommandText = "insert into Scholarship (NAID,fname,ssc,hsc,FathersOcc,income) values('" + int.Parse(txtRegno.Text) + "','" + txtfname.Text + "','" + int.Parse(txtSSC.Text) + "','" + int.Parse(txtHSC.Text) + "','" + txtFatherOcc.Text + "','" + txtIncome.Text + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            MessageBox.Show("Scholarship Applied Succesfully ", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

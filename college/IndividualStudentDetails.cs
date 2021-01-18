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
    public partial class IndividualStudentDetails : Form
    {
        public IndividualStudentDetails()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8 ; database=college ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID =" + txtregid.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                labelfullname.Text = ds.Tables[0].Rows[0][1].ToString();
                labelmothername.Text = ds.Tables[0].Rows[0][2].ToString();
                labelgender.Text = ds.Tables[0].Rows[0][3].ToString();
                labeldob.Text = ds.Tables[0].Rows[0][4].ToString();
                labelmobile.Text = ds.Tables[0].Rows[0][5].ToString();
                labelemail.Text = ds.Tables[0].Rows[0][6].ToString();
                labelsem.Text = ds.Tables[0].Rows[0][7].ToString();
                labelpgmlang.Text = ds.Tables[0].Rows[0][8].ToString();
                labelschoolname.Text = ds.Tables[0].Rows[0][9].ToString();
                labelyear.Text = ds.Tables[0].Rows[0][10].ToString();
                labeladdress.Text = ds.Tables[0].Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtregid.Text = "";
                labelfullname.Text = "_______________";
                labelmothername.Text = "_______________";
                labelgender.Text = "_______________";
                labeldob.Text = "_______________";
                labelmobile.Text = "_______________";
                labelemail.Text = "_______________";
                labelsem.Text = "_______________";
                labelpgmlang.Text = "_______________";
                labelschoolname.Text = "_______________";
                labelyear.Text = "_______________";
                labeladdress.Text = "_______________";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtregid.Text = "";
            labelfullname.Text = "_______________";
            labelmothername.Text = "_______________";
            labelgender.Text = "_______________";
            labeldob.Text = "_______________";
            labelmobile.Text = "_______________";
            labelemail.Text = "_______________";
            labelsem.Text = "_______________";
            labelpgmlang.Text = "_______________";
            labelschoolname.Text = "_______________";
            labelyear.Text = "_______________";
            labeladdress.Text = "_______________";
        }

        private void labelpgmlang_Click(object sender, EventArgs e)
        {

        }

        private void IndividualStudentDetails_Load(object sender, EventArgs e)
        {

        }
    }
}

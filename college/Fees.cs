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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }

        private void txtRegnum_TextChanged(object sender, EventArgs e)
        {
            if(txtRegnum.Text !="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-T2JA1MM8 ; database=college ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname,mname,duration from NewAdmission where NAID = " + txtRegnum.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    labelFullName.Text = ds.Tables[0].Rows[0][0].ToString();
                    labelMotherName.Text = ds.Tables[0].Rows[0][1].ToString();
                    labelDuration.Text = ds.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    labelFullName.Text = "________";
                    labelMotherName.Text = "________";
                    labelDuration.Text = "________";
                }
            }
            else
            {
                txtRegnum.Text = "";
                txtFees.Text = "";
                labelFullName.Text = "________";
                labelMotherName.Text = "________";
                labelDuration.Text = "________";
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8 ; database=college ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from fees where NAID = "+txtRegnum.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count==0)
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = LAPTOP-T2JA1MM8 ; database=college ; integrated security =True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                cmd1.CommandText = "insert into fees (NAID,fees) values (" + txtRegnum.Text + "," + txtFees.Text + ")";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                if (MessageBox.Show("Fees Submition Successfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtRegnum.Text = "";
                    txtFees.Text = "";
                    labelFullName.Text = "________";
                    labelMotherName.Text = "________";
                    labelDuration.Text = "________";
                }

            }
            else
            {
                MessageBox.Show("Fees are already submitted.");
                txtRegnum.Text = "";
                txtFees.Text = "";
                labelFullName.Text = "________";
                labelMotherName.Text = "________";
                labelDuration.Text = "________";
            }


           

            

        }
    }
}

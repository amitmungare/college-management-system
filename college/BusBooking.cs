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

namespace collegedatabase
{
    public partial class BusBooking : Form
    {
        public BusBooking()
        {
            InitializeComponent();
        }

        private void BusBooking_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-910M870;database=college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BusBooking where NAID=" + txtRegNo.Text + "";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            String roadname = txtRoute.Text;

            if (ds.Tables[0].Rows.Count == 0)
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source=DESKTOP-910M870;database=college;integrated security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                cmd1.CommandText = "insert into BusRoute2 (NAID,BusR,BusFees) values (" + txtRegNo.Text + ",'" + roadname + "', "+ txtBusFees.Text+")";
                

                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                if (MessageBox.Show("Submission Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtRegNo.Text = "";
                    NameLabel.Text = "______";
                    DurationLabel.Text = "______";
                    
                }
            }
            else
            {
                MessageBox.Show("Submitted.");
                txtRegNo.Text = "";
                NameLabel.Text = "______";
                DurationLabel.Text = "______";
               
            }

        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {
            if (txtRegNo.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-910M870;database=college;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname,duration from NewAdmission where NAID=" + txtRegNo.Text + "";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    NameLabel.Text = ds.Tables[0].Rows[0][0].ToString();
                    DurationLabel.Text = ds.Tables[0].Rows[0][1].ToString();

                }
                else
                {
                    NameLabel.Text = "______";
                    DurationLabel.Text = "______";

                }

            }
            else
            {
                txtRegNo.Text = "";
                txtRegNo.Text = "";
                NameLabel.Text = "______";
                DurationLabel.Text = "______";

            }
        }
    }
    }
    


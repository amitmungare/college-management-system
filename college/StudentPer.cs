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
    public partial class StudentPer : Form
    {
        public StudentPer()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =LAPTOP-T2JA1MM8; database=college;integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from StudentPerformance where NAID = " + txtRno.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count == 0)
            {

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source =LAPTOP-T2JA1MM8; database=college;integrated security =True";
                SqlCommand cmd1 = new SqlCommand();

                cmd1.Connection = con1;
                cmd1.CommandText = "insert into StudentPerformance (NAID,percentage) values (" + txtRno.Text + "," + txtper.Text + ")";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                if (MessageBox.Show("Performance Submitted Successfull ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtfname.Text = "_____";
                    txtRno.Text = "";
                    txtper.Text = "";
                    txtMname.Text = "_____";
                    txtSemister.Text = "_____";
                    txtDuration.Text = "_____";
                }
            }
            else
            {
                if (MessageBox.Show(" (Percentage already Submitted)" +
                    " Update Again? ", "Confirm ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "data source =LAPTOP-T2JA1MM8; database=college;integrated security =True";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con1;
                    cmd1.CommandText = "update StudentPerformance set percentage = '" + txtper.Text + "'where NAID = '" + txtRno.Text + "'";

                    SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                    DataSet DS1 = new DataSet();
                    DA1.Fill(DS1);

                    MessageBox.Show("Percentage Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Update Cancelled", "Cancle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            




        }



        private void txtRno_TextChanged(object sender, EventArgs e)
        {

            if (txtRno.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =LAPTOP-T2JA1MM8; database=college;integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select fname,mname,duration,semester from NewAdmission where  NAID = " + txtRno.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtfname.Text = DS.Tables[0].Rows[0][0].ToString();
                    txtMname.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDuration.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtSemister.Text = DS.Tables[0].Rows[0][3].ToString();
                }
                else
                {
                    txtfname.Text = "_____";
                    txtMname.Text = "_____";
                    txtDuration.Text = "_____";
                    txtSemister.Text = "_____";
                }
            }
            else
            {
                txtRno.Text = "";
                txtper.Text = "";
                txtfname.Text = "_____";
                txtMname.Text = "_____";
                txtDuration.Text = "_____";
                txtSemister.Text = "_____";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scholarship SC = new Scholarship();
            SC.Show();
        }
    }
}

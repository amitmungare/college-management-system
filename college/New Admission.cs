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
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

            private void btnsubmit_Click(object sender, EventArgs e){
            String name = txtfullname.Text;
            String mname = txtmothername.Text;
            String gender = "";
            bool isChecked = radioButtonmale.Checked;
            if (isChecked) {
                gender = radioButtonmale.Text;
            }
            else{
                gender = radioButtonfemale.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 moblie = Int64.Parse(txtmoblienum.Text);
            String email = txtemailid.Text;
            String semester = comboBoxsem.Text;
            String program = comboBoxlang.Text;
            String sname = txtprischname.Text;
            String duration = comboBoxduration.Text;
            String add = richTextBoxaddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8; database =college; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewAdmission (fname,mname,gender,dob,moblie,email,semester,prog,sname,duration,addres) values ('" + name + "','" + mname + "','" + gender + "','" + dob + "'," + moblie + ",'" + email + "','" + semester + "','" + program + "','" + sname + "','" + duration + "','" + add + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            MessageBox.Show("Data submitted. Remember the Registration Id", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
             }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfullname.Clear();
            txtmothername.Clear();
            radioButtonmale.Checked = false;
            radioButtonfemale.Checked = false;
            txtmoblienum.Clear();
            txtemailid.Clear();
            comboBoxsem.ResetText();
            txtprischname.Clear();
            comboBoxlang.ResetText();
            comboBoxduration.ResetText();
            richTextBoxaddress.Clear();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8; database =college; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select max(NAID) from NewAdmission";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Int64 regid = Convert.ToInt64(ds.Tables[0].Rows[0][0]);
            regIdNum.Text = (regid + 1).ToString();
        }

        private void txtmothername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void regIdNum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtemailid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmoblienum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxduration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxlang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxsem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtprischname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

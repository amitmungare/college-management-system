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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {


            String name = txtfullname.Text;
            String gender = "";
            bool isChecked = radioButtonmale.Checked;
            if (isChecked)
            {
                gender = radioButtonmale.Text;
            }
            else
            {
                gender = radioButtonfemale.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 moblie = Int64.Parse(txtmoblienum.Text);
            String email = txtemailid.Text;
            String semester = comboBoxsem.Text;
            String program = comboBoxlang.Text;
            String duration = comboBoxworkexp.Text;
            String add = richTextBoxaddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8; database =college; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher(fname,gender,dob,mobile,email,semester,prog,yer,adr) values ('" + name + "','" + gender + "','" + dob + "'," + moblie + ",'" + email + "','" + semester + "','" + program + "','" + duration + "','" + add + "')";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            MessageBox.Show("Data submitted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfullname.Clear();
            radioButtonmale.Checked = false;
            radioButtonfemale.Checked = false;
            txtmoblienum.Clear();
            txtemailid.Clear();
            comboBoxsem.ResetText();
            comboBoxlang.ResetText();
            comboBoxworkexp.ResetText();
            richTextBoxaddress.Clear();
        }
    }
}

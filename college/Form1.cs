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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            String Username = textBox1.Text;
            String password = textBox2.Text;


            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "data source = LAPTOP-T2JA1MM8 ; database=college ; integrated security =True";
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = new SqlCommand("Select fname,pword from Admin where fname = '" + textBox1.Text + "' and pword = '" + textBox2.Text + "'", sc);
            da.Fill(ds);
            sc.Open();

            if (ds.Tables[0].Rows.Count >0)
            {
                
                menuStrip1.Visible = true;
                panel1.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            upgreadSem us = new upgreadSem();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fe = new Fees();
            fe.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void individualDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualStudentDetails isd = new IndividualStudentDetails();
            isd.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher addt = new AddTeacher();
            addt.Show();
        }

        private void searchTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Exit","Exit",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hostelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void busTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void hostelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hostel hs = new Hostel();
            hs.Show();
        }

        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bustransport bss = new bustransport();
            bss.Show();
        }

        private void studentFeesPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentFeesPaid sfp = new StudentFeesPaid();
            sfp.Show();
        }

        private void removeTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeteacher rmt = new removeteacher();
            rmt.Show();
        }

        private void studentAppliedForHostelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAtHostel sah = new StudentAtHostel();
            sah.Show();
        }

        private void studentUsingTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentUsingTransport sut = new StudentUsingTransport();
            sut.Show();
        }

        private void stuPerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentPer spp = new StudentPer();
            spp.Show();
        }

        private void studentPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Strper sp = new Strper();
            sp.Show();
        }

        private void studentScholarshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsAppliedForScholarShip safs = new StudentsAppliedForScholarShip();
            safs.Show();
        }
    }
}

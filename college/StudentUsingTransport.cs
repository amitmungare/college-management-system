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
    public partial class StudentUsingTransport : Form
    {
        public StudentUsingTransport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8 ; database=college ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID =" + txtRegID.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewdata.DataSource = ds.Tables[0];
        }

        private void StudentUsingTransport_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8 ; database=college ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select NewAdmission.NAID as Student_ID , NewAdmission.fname as Full_Name ,NewAdmission.gender as Gender, NewAdmission.dob as Date_Of_Birth, NewAdmission.moblie as Mobile_Number , NewAdmission.email as Email_ID , NewAdmission.semester as Semester , NewAdmission.sname as School_name , NewAdmission.duration as Duration, NewAdmission.addres as Address, BusRoute2.Busfees as Fees from NewAdmission inner join BusRoute2 on NewAdmission.NAID=BusRoute2.NAID";
           // cmd.CommandText = "select * from BusRoute2 ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewdata.DataSource = ds.Tables[0];
        }
    }
}

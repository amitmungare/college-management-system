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
    public partial class Strper : Form
    {
        public Strper()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8 ; database=college ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from StudentPerformance where NAID =" + txtRegID.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewdata.DataSource = ds.Tables[0];
        }

        private void Strper_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-T2JA1MM8 ; database=college ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdmission.NAID as Student_ID , NewAdmission.fname as Full_Name , NewAdmission.semester as Semester , NewAdmission.duration as Duration, StudentPerformance.percentage as percentage from NewAdmission inner join StudentPerformance on NewAdmission.NAID=StudentPerformance.NAID";

            //cmd.CommandText = "select * from  StudentPerformance";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewdata.DataSource = ds.Tables[0];
        }
    }
}

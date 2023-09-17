using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo
{
    public partial class old : Form
    {
        public old()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vasan\Documents\docinfo.mdf;Integrated Security=True;Connect Timeout=30");
        void popcombo()
        {
            string sql = " select * from prescript";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("patientid", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox1.ValueMember = "patientid";
                comboBox1.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        void populate()
        {
            con.Open();
            string query = "select * from patient";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        void populate1()
        {
            con.Open();
            string query = "select * from prescript";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashborad db = new Dashborad();
            db.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void old_Load(object sender, EventArgs e)
        {
            populate();
            populate1();
            popcombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from patient where patientid='"+comboBox1.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

            con.Open();
            string query1 = "select * from prescript where patientid='"+comboBox1.Text+"'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            SqlCommandBuilder builder1 = new SqlCommandBuilder(sda1);
            var ds1 = new DataSet();
            sda1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
            con.Close();
        }
    }
}

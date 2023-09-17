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
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vasan\Documents\docinfo.mdf;Integrated Security=True;Connect Timeout=30");
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
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashborad db = new Dashborad();
            db.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void patient_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into patient Values('" +textBox1.Text + "','" +textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("added successfully");
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update patient set patientname= '" + textBox2.Text + "',bloodgroup= '" + textBox3.Text + "',age='" + textBox4.Text + "',gender='" + comboBox1.Text + "',email='" + textBox5.Text + "',phoneno='"+textBox6.Text+ "',contactperson='"+textBox7.Text+ "',disoder='"+textBox8.Text+ "',Treatment='"+textBox9.Text+ "',allergies='"+textBox10.Text+ "' where patientid='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("upated successfully");
            populate();
        }
    }
}

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
    public partial class prescription : Form
    {
        public prescription()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vasan\Documents\docinfo.mdf;Integrated Security=True;Connect Timeout=30");
        void popcombo()
        {
            string sql = " select patientid from patient";
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
        string ptname;
           void name()
            {
                con.Open();
                string mysqql = "select patientname from patient where patientid='"+comboBox1.SelectedValue.ToString()+"'";
                SqlCommand cmd = new SqlCommand(mysqql,con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    ptname = dr["patientname"].ToString();
                    textBox1.Text = ptname;
                }
            con.Close();
            }
        /*void populate()
        {
            con.Open();
            string query = "select * from prescript where patientid='" + comboBox1.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashborad db = new Dashborad();
            db.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void prescription_Load(object sender, EventArgs e)
        {
            popcombo();
           // populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into prescript Values('" + comboBox1.SelectedValue.ToString() + "','" + textBox1.Text + "','" + richTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + richTextBox2.Text + "','"+dateTimePicker1.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("added successfully");
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            name();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString(label13.Text+"\n", new Font("Sitka Small", 14, FontStyle.Bold), Brushes.Black, new Point(230,100));
            e.Graphics.DrawString(label14.Text, new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(130,160));
            e.Graphics.DrawString(textBox6.Text, new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(230, 160));
            e.Graphics.DrawString(label15.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(130,180));
            e.Graphics.DrawString(textBox7.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(255, 180));
            e.Graphics.DrawString(label16.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(130, 200));
            e.Graphics.DrawString(textBox8.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(230, 200));
            e.Graphics.DrawString(label17.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(130, 220));
            e.Graphics.DrawString(textBox9.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(230, 220));
            e.Graphics.DrawString(label18.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(130, 240));
            e.Graphics.DrawString(richTextBox3.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(230, 240));
            e.Graphics.DrawString(label21.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(130, 260));
            e.Graphics.DrawString(textBox2.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(230, 260));
            e.Graphics.DrawString(label22.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(130, 280));
            e.Graphics.DrawString(textBox10.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(230, 280));
            e.Graphics.DrawString(label23.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(130, 300));
            e.Graphics.DrawString(textBox11.Text + "\n", new Font("Sitka Small", 12, FontStyle.Italic), Brushes.Black, new Point(230, 300));
            e.Graphics.DrawString(label19.Text+"\n", new Font("Sitka Small", 14, FontStyle.Bold), Brushes.Black, new Point(230,430));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ( printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            textBox6.Text =comboBox1.Text;
            textBox7.Text = textBox1.Text;
            textBox8.Text = dateTimePicker1.Text;
            textBox9.Text = textBox3.Text;
            richTextBox3.Text = richTextBox1.Text;
            textBox2.Text = comboBox2.Text;
            textBox10.Text = comboBox3.Text;
            textBox11.Text = comboBox4.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from prescript where patientid='" + comboBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}

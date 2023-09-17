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
    public partial class docinfo : Form
    {
        public docinfo()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            string query = "select * from docinfo";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0]; 
            con.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vasan\Documents\docinfo.mdf;Integrated Security=True;Connect Timeout=30");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert Into docinfo Values('" + tdocid.Text + "','" + tdocname.Text + "','" + tdocph.Text + "','" + tdocad.Text + "','" + tdocemail.Text + "','" + tdocpass.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("added successfully");
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update docinfo set Docname='" + tdocname.Text + "',Phoneno='" + tdocph.Text + "',Address='" + tdocad.Text + "',Email='" + tdocemail.Text + "',Password='" + tdocpass.Text + "'where Docid='"+tdocid.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("upated successfully");
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tdocname.Text = " ";
            tdocid.Text = " ";
            tdocph.Text = " ";
            tdocad.Text = " ";
            tdocemail.Text = " ";
            tdocpass.Text = " ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* tdocid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tdocname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tdocph.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tdocad.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tdocemail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            tdocpass.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();*/
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tdocad_TextChanged(object sender, EventArgs e)
        {

        }

        private void docinfo_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}

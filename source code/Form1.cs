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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vasan\Documents\docinfo.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select Docid , Password From docinfo Where Docid ='" + tusername.Text + "' and Password ='" + tpassword.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
                {
                this.Hide();
                Dashborad db = new Dashborad();
                db.Show();
                }
            else
            {
                MessageBox.Show("Enter the valid username and password");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            docinfo di = new docinfo();
            di.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    }

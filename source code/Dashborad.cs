using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Dashborad : Form
    {
        public Dashborad()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a2.ForeColor = System.Drawing.Color.LightBlue;
            a1.ForeColor = System.Drawing.Color.White;
            a3.ForeColor = System.Drawing.Color.LightBlue;
            this.Hide();
            docinfo di = new docinfo();
            di.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1.ForeColor = System.Drawing.Color.LightBlue;
            a2.ForeColor = System.Drawing.Color.White;
            a3.ForeColor = System.Drawing.Color.LightBlue;
            this.Hide();
            patient pi = new patient();
            pi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a1.ForeColor = System.Drawing.Color.LightBlue;
            a2.ForeColor = System.Drawing.Color.LightBlue;
            a3.ForeColor = System.Drawing.Color.White;
            this.Hide();
            prescription pres = new prescription();
            pres.Show();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Patient's new record")
            {
                this.Hide();
                patient pn = new patient();
                pn.Show();
            }

            if(comboBox1.SelectedItem == "Patient's old record")
            {
                this.Hide();
                old po= new old();
                po.Show();
            }

        }

        private void Dashborad_Load(object sender, EventArgs e)
        {

        }
    }
}

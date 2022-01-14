using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        
        private CAuto Masina = new CAuto();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Masina.set_Tankinhalt(100);
            progressBar1.Value = Masina.get_Tankinhalt();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            Masina.set_Ladung(50);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            Masina.set_Ladung(100);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            Masina.set_Ladung(150);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox5.Checked = false;
            Masina.set_Ladung(200);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            Masina.set_Ladung(250);
          
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            Masina.set_Geschwindigkeit(Convert.ToInt32(numericUpDown1.Value));
        }

        private void Fahren_Click(object sender, EventArgs e)
        {
            if (Masina.fahren(Convert.ToInt32(textBox1.Text)))
                label5.Text = "Fahren erfolgreich";
            else
            { label5.Text = "Fahren nicht erfolgreich";
                

            }
            progressBar1.Value = Masina.get_Tankinhalt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masina.set_Tankinhalt(100);
            progressBar1.Value = Masina.get_Tankinhalt();
        }
    }
}

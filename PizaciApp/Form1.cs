using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizaciApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(maskedTextBox1.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(checkBox1.Text + " " + checkBox2.Text + " " + checkBox3.Text + " " + checkBox4.Text);
            listBox6.Items.Add(comboBox3.Text);
            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox4.Items.Clear();
            listBox6.Items.Clear();

        }
    }
}

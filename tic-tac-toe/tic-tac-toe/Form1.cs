using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 cliente = new Form2(IP_server.Text);
            cliente.Show();
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comprovarIP(IP_server);
        }

        public void comprovarIP(TextBox t1)
        {
            string input = t1.Text.Trim();

            Regex isiP = new Regex(@"\b(10\.\d{1,3}\.\d{1,3}\.\d{1,3})\b|\b(172\.(1[6-9]|2\d|3[0-1])\.\d{1,3}\.\d{1,3})\b|\b(192\.168\.\d{1,3}\.\d{1,3})\b");

            if (!string.IsNullOrEmpty(input) && isiP.IsMatch(input))
            {
                connect.Enabled = true;
            }
            else
            {
                connect.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect.Enabled = false;
        }
    }
}

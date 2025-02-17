using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form2 : Form
    {
        private static IPAddress server; 
        public Form2(string ip)
        {
            server = IPAddress.Parse(ip);
            int ServerPort = 50000;
            TcpClient client = new TcpClient();
            client.Connect(server, ServerPort);
            NetworkStream ns = client.GetStream();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

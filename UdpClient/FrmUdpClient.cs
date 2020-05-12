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

namespace UdpClient
{
    public partial class FrmUdpClient : Form
    {
        IPEndPoint TargetEndpoint = null;
        Socket UdpClient = null; 
        public FrmUdpClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var feedBack= UdpClient.SendTo(Encoding.UTF8.GetBytes("Message"), TargetEndpoint);
        }

        private void FrmUdpClient_Load(object sender, EventArgs e)
        {
            TargetEndpoint= new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5555);
            UdpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        private void FrmUdpClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(UdpClient != null)
            {
                UdpClient.Close();
            }
        }
    }
}

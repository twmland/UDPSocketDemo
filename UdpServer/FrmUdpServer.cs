using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpServer
{
    public partial class FrmUdpServer : Form
    {
        IPEndPoint ipep = null;
        UdpClient uc = null;
        Thread thread = null;
        public FrmUdpServer()
        {
            InitializeComponent();
        }

        private void FrmUdpServer_Load(object sender, EventArgs e)
        {
            ipep = new IPEndPoint(IPAddress.Any, 5555);
            uc = new UdpClient(ipep.Port);
            thread = new Thread(GetMessageFromUdpClient);
            thread.IsBackground = true;
            thread.Start();
        }

        private void GetMessageFromUdpClient()
        {
            while(true)
            {
               var messageText =System.Text.Encoding.UTF8.GetString(uc.Receive(ref ipep));

            }
        }

        private void FrmUdpServer_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void FrmUdpServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
        }
    }
}

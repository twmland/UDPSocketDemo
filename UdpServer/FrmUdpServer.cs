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
        delegate void OneStringParameterDelegate(string  message,ListBox lstBxMessages);
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
            OneStringParameterDelegate delegateMthd = new OneStringParameterDelegate(DisplayMessage);
            while (true)
            {
               var rcvMessage =System.Text.Encoding.UTF8.GetString(uc.Receive(ref ipep));
                #region do something
                this.Invoke(delegateMthd, rcvMessage,LstBoxMessages);
                #endregion 
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
           
            LstBoxMessages.Items.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void DisplayMessage(string message,ListBox lstBxMessages)
        {
            lstBxMessages.Items.Insert(0, message.ToString());
        }
        void DoSomething()
        {

        }
    }
}

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

namespace Chat_App
{
    public partial class ChatUI : Form
    {
        private const string IP_ADDRESS = "127.0.0.1";
        private const int PORT = 8000; 
        public ChatUI()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(IP_ADDRESS, PORT);
            Byte[] sendBytes = Encoding.ASCII.GetBytes(txtbox_message.Text.ToString());
            udpClient.Send(sendBytes, sendBytes.Length);
            lstbox_received_message.Items.Add(
                "Me" + ": " + txtbox_message.Text.ToString()
                );
        }

        public void ServerThead()
        {
            UdpClient udpClient = new UdpClient(PORT);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse(IP_ADDRESS), 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                lstbox_received_message.Items.Add(
                    "Friend" + ": " + returnData.ToString()
                    );
            }
        }

        private void ChatUI_Load(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(ServerThead));
            thdUDPServer.Start();
        }
    }
}

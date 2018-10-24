using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    delegate void SetTextCallback(string s);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpClient tcpClient = null;
        NetworkStream ntwStream = null;
        Chat_Class cht_Class = new Chat_Class();

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cmd_Connect.Text == "Login")
            {
                return;
            }
            Message_Snd("<" + txt_Name.Text + ">  님께서 접속해제 하셨습니다. ", false);
            cht_Class.Chat_Close();
            ntwStream.Close();
            tcpClient.Close();
        }

        private void cmd_Connect_Click(object sender, EventArgs e)
        {
            if (cmd_Connect.Text == "Login")
            {
                try
                {
                    IPAddress ipaAddress = IPAddress.Parse(txt_Server_IP.Text);
                    tcpClient = new TcpClient();
                    tcpClient.Connect(ipaAddress, 5001);
                    ntwStream = tcpClient.GetStream();
                    cht_Class.Chat_Class_Setup(this, ntwStream, this.txt_Chat);
                    Thread thd_Receive = new Thread(new ThreadStart(cht_Class.Chat_Process));
                    thd_Receive.Start();
                    Message_Snd("<" + txt_Name.Text + "> 님께서 접속 하셨습니다.", true);
                    cmd_Connect.Text = "Logout";
                    int count = 0;
                    count++;
                    label3.Text = "현재 " + count + " 명 참여 ";
                }
                catch (System.Exception Err)
                {
                    MessageBox.Show("Chatting Server 오류발생 또는 Start되지 않았거나\n\n" + Err.Message, "Client");
                }
            }
            else
            {
                
                Message_Snd("<" + txt_Name.Text + "> 님께서 접속해제 하셨습니다.", true);
                cmd_Connect.Text = "Login";
      
            }
        }

        private void txt_Msg_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar == 13)
            {
                if (cmd_Connect.Text == "Logout")
                {
                    Message_Snd("<" + txt_Name.Text + ">" + txt_Msg.Text, true);
                }
                txt_Msg.Text = "";
                e.Handled = true;
            }
        }



        public void SetText(string text)
        {
            if (this.txt_Chat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txt_Chat.AppendText(text);
            }
        }

        private void Message_Snd(string lstMessage, Boolean Msg)
        {
            try
            {
                string dataToSend = lstMessage + "\r\n";
                byte[] data = Encoding.Default.GetBytes(dataToSend);

                ntwStream.Write(data, 0, data.Length);
            }
            catch (System.Exception Err)
            {
                if (Msg == true)
                {
                    MessageBox.Show("Chatting Server 가 오류발생 또는  Start 되지 않았거나,\n\n" + Err.Message, "Client");
                    cmd_Connect.Text = "Login";
                    cht_Class.Chat_Close();
                    ntwStream.Close();
                    tcpClient.Close();
                }
            }
        }
    }
    public class Chat_Class
    {
        private Encoding ecd_Encode = Encoding.GetEncoding("KS_C_5601-1987");
        private System.Windows.Forms.TextBox txt_Chat;
        private NetworkStream netStream;
        private StreamReader strReader;
        private Form1 form1;
        public void Chat_Class_Setup(Form1 form1, NetworkStream netStream, System.Windows.Forms.TextBox txt_Chat)
        {
            this.txt_Chat = txt_Chat;
            this.netStream = netStream;
            this.strReader = new StreamReader(netStream, ecd_Encode);
            this.form1 = form1;
        }
        public void Chat_Process()
        {
            while (true)
            {
                try
                {
                    string lstMessage = strReader.ReadLine();
                    if (lstMessage != null && lstMessage != "")
                    {
                        form1.SetText(lstMessage + "\r\n");
                    }
                }
                catch (System.Exception)
                {
                    break;
                }
            }
        }
        public void Chat_Close()
        {
            netStream.Close();
            strReader.Close();
        }
    }
}
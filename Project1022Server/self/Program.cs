using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace selfMultiServer
{
    class ClintHadler
    {
        Socket socket = null;
        NetworkStream stream = null;
        StreamReader reader = null;
        StreamWriter writer = null;

        public ClintHadler(Socket socket)
        {
            this.socket = socket;
            Server.list.Add(socket); 

        }

        public void chat()
        {
            stream = new NetworkStream(socket);
            Encoding encode = Encoding.GetEncoding("euc-kr");
            reader = new StreamReader(stream, encode);
          
            while (true)
            {
                string str = reader.ReadLine();
                Console.WriteLine(str);

                foreach (Socket s in Server.list)
                    stream = new NetworkStream(s);
                    writer = new StreamWriter(stream, encode) { AutoFlush = true };
                    writer.WriteLine(str);
            }
        }
    }
    class Server
    {
        public static List<Socket> list = new List<Socket>();
        public static void Main(string[] args)
        {
            TcpListener tcpListener = null;
            Socket clientsocket = null;
            try
            {
                IPAddress ipAd = IPAddress.Parse("192.168.0.204");

                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();

                while (true)
                {
                    clientsocket = tcpListener.AcceptSocket();

                    ClintHadler cHadler = new ClintHadler(clientsocket);
                    Thread t = new Thread(new ThreadStart(cHadler.chat));
                    t.Start();

                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }
        }
    }
}



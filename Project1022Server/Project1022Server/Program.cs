using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1022Server
{
    class Server
    {
        static void Main(string[] args)
        {
            NetworkStream stream = null;
            Socket clientsocket = null;
            StreamReader reader = null;
            StreamWriter writer = null;

            TcpListener tcpListener = null;


            try
            {
                IPAddress ipAd = IPAddress.Parse("192.168.0.204");   // 서버ip 객체 생성

                tcpListener = new TcpListener(ipAd, 5001); // 서버 클래스 
                tcpListener.Start();

                clientsocket = tcpListener.AcceptSocket();  // accept socket하면 socket이 만들어진다. 
                stream = new NetworkStream(clientsocket);
                Encoding encode = Encoding.GetEncoding("utf-8"); // 한글 때문

                reader = new StreamReader(stream, encode);
                writer = new StreamWriter(stream, encode) { AutoFlush = true };
                while (true)
                {
                    string str = reader.ReadLine();
                    Console.WriteLine(str);
                    writer.WriteLine(str);
                }
            }
            catch(Exception e)
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

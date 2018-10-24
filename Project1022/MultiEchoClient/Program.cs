using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace MultiEchoClient
{
    class ServerHandler
    {
        StreamReader reader = null;

        public ServerHandler(StreamReader reader)
        {
            this.reader = reader;
        }

        public void chat()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class TcpclientTest
    {
        static void Main(string[] args)
        {
                TcpClient client = null;
            try
            {
                client = new TcpClient();
                client.Connect("192.168.0.204", 5001);

                NetworkStream stream = client.GetStream();
                Encoding encode = System.Text.Encoding.GetEncoding("euc-kr");
                
                StreamWriter writer = new StreamWriter(stream, encode) { AutoFlush = true };

                StreamReader reader = new StreamReader(stream, encode);
                ServerHandler sHandler = new ServerHandler(reader);
                Thread t = new Thread(new ThreadStart(sHandler.chat));
                t.Start();

                Console.WriteLine("<Client>메시지를 입력하세요 ");
                string datatoSend = Console.ReadLine();
                while (true)
                {
                    writer.WriteLine("-->  {0}",datatoSend);
                    datatoSend = Console.ReadLine();
                    if (datatoSend.IndexOf("<EOF>") > -1) break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                client.Close();
                client = null;
            }

        }
    }
}

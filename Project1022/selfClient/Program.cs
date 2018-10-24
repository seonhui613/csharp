using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace selfClient
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
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
    class TcpClientTest
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient();
                client.Connect("192.168.0.204", 5001); //서버 ip 주소에 n번 포트로 접속하겠다.
                NetworkStream stream = client.GetStream();

                Encoding encode = Encoding.GetEncoding("euc-kr");
                StreamReader reader = new StreamReader(stream, encode);
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                ServerHandler sHan = new ServerHandler(reader);
                Thread t = new Thread(new ThreadStart(sHan.chat));
                t.Start();
                

                string dataToSend = Console.ReadLine(); // 메세지 작성

                while (true)
                {

                    writer.WriteLine(dataToSend); // 내가 적은메세지 출력
                    if (dataToSend.IndexOf("<EOF>") > -1) break; // <EOF>쓰면 쓰기 종료.
                    dataToSend = Console.ReadLine();
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

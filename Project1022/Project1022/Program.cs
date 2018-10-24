using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1022
{
    class TcpClientTest
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient();
                client.Connect("192.168.0.15", 5001); //서버 ip 주소에 n번 포트로 접속하겠다.
                NetworkStream stream = client.GetStream();

                Encoding encode = Encoding.GetEncoding("utf-8");
                StreamReader reader = new StreamReader(stream, encode);
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                string dataToSend = Console.ReadLine(); // 메세지 작성

                while (true)
                {

                    writer.WriteLine(dataToSend); // 내가 적은메세지 출력
                   
                    string str = reader.ReadLine();
                    Console.WriteLine(str);

                    if (dataToSend.IndexOf("<EOF>") > -1) break; // <EOF>쓰면 쓰기 종료.
                    dataToSend = Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                client.Close();
            }
        }
    }
}

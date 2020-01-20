using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCP聊天室_服务端
{
    class Program
    {
        static List<Client> clientList = new List<Client>();
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress iPAddress = IPAddress.Parse("192.168.0.132");
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 6667);
            tcpServer.Bind(iPEndPoint);
            tcpServer.Listen(100);
            Console.WriteLine("开启服务器");
            while(true)
            {
                Socket clientSocket = tcpServer.Accept();
                Console.WriteLine("一个客户端连接");
                Client client = new Client(clientSocket);//把每个客户端收发的信息在Client上处理
                clientList.Add(client);
            }

        }
    }
}

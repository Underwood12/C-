using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;

namespace Socket编程_TCP协议
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);//创建Socket
            IPAddress iPAddress = new IPAddress(new byte[] { 192,168,0,132});//IP地址
            EndPoint endPoint = new IPEndPoint(iPAddress,6667);//对IP和端口做了一层封装类
            tcpServer.Bind(endPoint);//向操作系统申请一个可用的ip跟端口号，用来通讯
            tcpServer.Listen(100);//开始监听，最大连接数100
            Socket clientSocket= tcpServer.Accept();//暂停当前线程，直到有一个客户连接过来，才进行下面代码
            //使用返回的Socket跟客户端进行通信
            string message = "Hello World!";
            byte[] bytes= Encoding.UTF8.GetBytes(message);
            clientSocket.Send(bytes);

            //接收客户端发送的数据
            byte[] data1 = new byte[1024];
            int length = clientSocket.Receive(data1);
            string message1 = Encoding.UTF8.GetString(data1, 0, length);
            Console.WriteLine(message1);
            Console.Read();
        }
    }
}

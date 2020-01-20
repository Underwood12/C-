using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace UDP协议_服务端
{
    
    class Program
    {
        static byte[] data = new byte[1024];
        static void Main(string[] args)
        {
            Socket UDPServer;
            UDPServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            UDPServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.132"), 6667));


            EndPoint removeEndPoiont = new IPEndPoint(IPAddress.Any, 0);
            int length = UDPServer.ReceiveFrom(data, ref removeEndPoiont);
            string msg = Encoding.UTF8.GetString(data);
            Console.WriteLine(string.Format("发送地址{0},发送端口{1},发送信息{2}", (removeEndPoiont as IPEndPoint).Address.ToString(), (removeEndPoiont as IPEndPoint).Port,msg));
            UDPServer.Close();
            Console.Read();
        }

    }
}

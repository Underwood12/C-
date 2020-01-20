using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCP聊天室_服务端
{
    class Client
    {
        Task task;
        Socket socket;
        byte[] data = new byte[1024];
        public Client(Socket socket)
        {
            this.socket = socket;
            task = new Task(ReceiveMessage);
            task.Start();
        }
        public void ReceiveMessage()
        {
            while (true)
            {
                if (!socket.Connected) return;
                int length = socket.Receive(data);
                string message = Encoding.UTF8.GetString(data, 0, length);
                
            }
        }
    }
}

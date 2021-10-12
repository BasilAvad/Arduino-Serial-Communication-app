using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace UZTA1
{
    public class cServerClass
    {
        public event MessageEventHandler Message;
        public delegate void MessageEventHandler(cServerClass sender, string Data);

        // Server Control 

        public static string IP= "hbhbhbb";
        public static int Port=1000;



        public IPAddress ServerIP = IPAddress.Parse(IP);
        public int ServerPort = Port;

        public TcpListener myserver;
        public Thread ComThread;
        public bool IsListning = true;
        private TcpClient client;
        private StreamReader clientData;
        public cServerClass()
        {

            myserver = new TcpListener(ServerIP, ServerPort);
            myserver.Start();
            ComThread = new Thread(new ThreadStart(Hearing));
            ComThread.Start();
        }
        private void  Hearing()
        {
            while (IsListning==false)
            {
                if (myserver.Pending()==true )
                {
                    client = myserver.AcceptTcpClient();
                    clientData =new  StreamReader(client.GetStream());
                }
                try
                {
                    Message?.Invoke(this, clientData.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(" Error {0}",ex);
                }
                Thread.Sleep(10);
            }
        }
    }

}

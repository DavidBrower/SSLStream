using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Configuration;
using System.Net.Sockets;

namespace TCPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            if (appSettings["useSSL"] == "true")
            {
                //string serverCertificateName = null;
                //string machineName = null;
                //if (args == null || args.Length < 1)
                //{
                //    SslTcpClient.DisplayUsage();
                //}

                //// User can specify the machine name and server name.
                //// Server name must match the name on the server's certificate.
                //machineName = args[0];
                //if (args.Length < 2)
                //{
                //    serverCertificateName = machineName;
                //}
                //else
                //{
                //    serverCertificateName = args[1];
                //}

                SslTcpClient.RunClient("127.0.0.1", "LT15838.civica.root.local");
            }
            else
            {
                TcpSender.Connect("127.0.0.1", "This is a great message");
            }
        }
    }
}

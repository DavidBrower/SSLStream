using System.Collections.Specialized;
using System.Configuration;

namespace TCPReceiver
{
    class MyTcpListener
    {
        public static int Main(string[] args)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            if (appSettings["useSSL"] == "true")
            {
                string certificate = null;
                //certificate = args[0];
                SslTcpServer.RunServer(certificate);
            }
            else
            {
                TcpServer.Connect();
            }
            return 0;
        }
    }
}

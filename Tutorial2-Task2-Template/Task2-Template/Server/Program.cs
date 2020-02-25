using System;

namespace SSE.Server
{
    public class TcpServer
    {
        /// <summary>
        /// Starts the HTTP server, which keeps on running until the program is aborted.
        /// </summary>
        /// <param name="ip">The IP address to listen tp.</param>
        /// <param name="port">The port to listen to.</param>
        public void Run(string ip, int port)
        {           
        }
     
        /// <summary>
        /// Handles an incoming line of text. 
        /// </summary>
        /// <param name="line">Incoming data.</param>
        /// <returns>The answer to be sent back as a reaction to the received line or null.</returns>
        protected virtual string ReceiveLine(string line)
        {
             // for testing purposes: wait for 10s and echo back received line 
            Console.WriteLine("TCP: Simulate 10s processing time.");

            // simulate 10s processing time
            var start = DateTime.Now.Ticks;
            while (DateTime.Now.Ticks - start < 100000000) { };

            // example application: provide environment information
            if (line.StartsWith("ask "))
                return Environment.GetEnvironmentVariable(line.Substring(4));
            return "What?";
        }
        
        /// <summary>
        /// Program entry point for testing purposes.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var server = new TcpServer();
            server.Run("127.0.0.1", 13000);
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}

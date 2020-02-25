using System;

namespace SSE.Client
{
    /// <summary>
    /// Simple implementation of a TCP client.
    /// </summary>
    public class TcpClient
    {
        /// <summary>
        /// Sends a string to a TCP endpoint, waits for an answer and returns it.
        /// </summary>
        /// <param name="ip">The IP address to send the request to.</param>
        /// <param name="port">The target port to send the request to.</param>
        /// <param name="message">The data to be sent as a string.</param>
        /// <returns>The data received as an answer.</returns>
        public string Request(string ip, int port, string message)
        {
            return "";
        }

        /// <summary>
        /// Program entry point for testing purposes.
        /// </summary>  
        public static void Main(string[] args)
        {
           // create client
            var client = new TcpClient();

            // send a request to a locally running server program             
            var answer = client.Request("127.0.0.1", 13000, "ask NUMBER_OF_PROCESSORS\n");

            // display answer and wait for user
            Console.WriteLine("Answer: " + answer);
            Console.ReadLine();
        }
    }
}

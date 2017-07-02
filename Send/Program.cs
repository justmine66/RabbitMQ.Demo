using System;
using System.Text;
using RabbitMQ.Client;
using Send.HelloWorld;
using Send.publishSubscribe;

namespace Send
{
    class Program
    {
        static void Main(string[] args)
        {
            //args = new string[]{
            //    "First message.",
            //    "Second message..",
            //    "Third message...",
            //    "Fourth message....",
            //    "Fifth message.....",
            //};
            //Publisher.DoSend();
            //EmitLogs.DoSend(args);

            var rpcClient = new RPCClient();

            Console.WriteLine(" [x] Requesting fib(30)");
            var response = rpcClient.Call("30");
            Console.WriteLine(" [.] Got '{0}'", response);

            rpcClient.Close();
        }
    }
}
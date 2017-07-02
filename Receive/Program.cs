using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Receive.HelloWorld;
using Receive.publishSubscribe;

namespace Receive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Consumer.DoReceive();
            ReceiveLogs.DoReceive();
        }
    }
}
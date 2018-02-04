using LeaderBoardClient.ServiceReference;
using System;

namespace LeaderBoardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Create an instance of the WCF proxy.  
            ServiceReference.Service1Client client = new Service1Client();
            client.GetData(1);
            Console.ReadLine();
        }
    }
}

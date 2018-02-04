using LeaderBoardClient.ServiceReference;
using System;

namespace LeaderBoardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Create an instance of the WCF proxy.  
            ServiceReference.ServiceClient client = new ServiceClient();
            for( int i = 0; i < 10; i++)
            {
                Console.WriteLine(client.createPrivateContest());

            }
            Console.ReadLine();
        }
    }
}

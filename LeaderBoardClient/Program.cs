using LeaderBoardClient.ServiceReference;
using System;

namespace LeaderBoardClient
{
    class Program
    {
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        static void Main(string[] args)
        {

            // Show commmand line options
            
            var program = new Program();
            while (true)
            {
                commandline();
                int input = Convert.ToInt32(Console.ReadLine());
                if (!program.process(input))
                    break;
            }
        }

        Program()
        {            
            //Console.WriteLine("Connected to server with client id {0}", client_id);
        }       

        static void commandline()
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1 : Create a public contest");
            Console.WriteLine("2 : Create a private contest");
            Console.WriteLine("3 : List All Public Leaderboard");
            Console.WriteLine("4 : List Your Private Leaderboard");
            Console.WriteLine("5 : Update score");
            Console.WriteLine("6 : Close a  contest");
            Console.WriteLine("7 : View a  contest");
            Console.WriteLine("8 : Add player");
            Console.WriteLine("-1: To exit");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        bool process(int option)
        {
            switch (option)
            {
                case -1: { Console.WriteLine("Good bye, See you next time"); return false; }
                case 1: { return createPublicContest(); }
                case 2: { return createPrivateContest(); }
                case 3: { return listAllPublicContest(); }
                case 4: { return listMyPrivateContest(); }
                case 5: { return updateScore(); }               
                case 6: { return closeContest(); }
                case 7: { return viewContest(); }
                case 8: { return addPlayer(); }
            }
            return true;
        }

        void listAllContest()
        {
            Console.WriteLine("Choose contest from:");
            listAllPublicContest();
            listMyPrivateContest();

        }

        private bool addPlayer()
        {
            listAllContest();
            int contest_id = Convert.ToInt32(Console.ReadLine());
            client.AddPlayer(contest_id);
            Console.WriteLine(client.AddPlayer(contest_id));
            return true;
        }

        private bool viewContest()
        {
            listAllContest();
            int contest_id = Convert.ToInt32(Console.ReadLine());
            var contest = client.GetContest(contest_id);

            Console.WriteLine("___________________Contest id ({0})_____________________\n", contest_id);
            foreach ( var val in contest)
            {
                Console.WriteLine("Player({0} )- Score({1})", val.Key, val.Value);
            }
            Console.WriteLine("\n______________________________________________________\n");
            return true;
        }

        private bool closeContest()
        {
            throw new NotImplementedException();
        }

        private void listPlayer( int contestID)
        {
            Console.Write("Choose player from :");
            printList(client.GetAllPlayers(contestID));
            Console.WriteLine();

        }

        private bool updateScore()
        {
            listAllContest();
            int contest_id = Convert.ToInt32(Console.ReadLine());

            listPlayer(contest_id);
            int player_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter player new score");
            int score = Convert.ToInt32(Console.ReadLine());

            client.UpdateScore(contest_id, player_id, score);
            return true;
        }

        bool createPublicContest()
        {
            var rv = client.CreatePublicContest();
            Console.Write("Created contest with id:");
            Console.WriteLine(rv);
            return true;
        }

        bool createPrivateContest()
        {
            var rv = client.CreatePrivateContest();
            Console.Write("Created contest with id:");
            Console.WriteLine(rv);
            return true;
        }

        bool listAllPublicContest()
        {
            printList(client.GetAllPubicContest());            
            return true;

        }

        bool listMyPrivateContest()
        {
            printList(client.GetAllPrivateContest());           
            return true;

        }

        private void printList(int [] l)
        {
            if (l==null)
            {
                Console.WriteLine("Error...");
                return;
            }
            if (l.Length==0)
            {
                //Console.WriteLine("Empty....?");
                return;
            }
            foreach (var val in l)
            {
                Console.Write(val);
                Console.Write("\t");
            }
            Console.WriteLine(); ;

        }

        
    }
}

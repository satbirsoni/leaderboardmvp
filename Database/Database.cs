using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Database : IDatabase
    {
        int contest_id = 0;
        int player_id = 0;
        Dictionary<int, int> scores= new Dictionary<int, int>();
        List<int> publicContest = new List<int>();
        List<int> privateContest = new List<int>();


        public Database()
        {
            Console.WriteLine("Database c'tor");

        }

        public int CreateContest(bool isPrivate = false)
        {
            Console.WriteLine("Inside CreateContest");
            var rv =  ++contest_id;

            if (isPrivate)
                privateContest.Add(rv);
            else
                publicContest.Add(rv);

            return rv;
        }

        public int CreatePlayer()
        {
            Console.WriteLine("Inside CreatePlayer");
            return ++player_id;
        }

        public int[] GetAllPrivateContest()
        {
            Console.WriteLine("Inside getAllPrivateContest");
            return privateContest.ToArray();
        }

        public int[] GetAllPublicContest()
        {
            Console.WriteLine("Inside GetAllPublicContest");
            return publicContest.ToArray();
        }

        public int getScore(int playerId)
        {
            Console.WriteLine("Inside getScore");
            int score = 0;

            if (!scores.TryGetValue(playerId, out score))
                return 0; //todo raise exception
            return score;

        }

        public int getScore(int playerId, int ContestID)
        {
            Console.WriteLine("Inside getScore");
            //todo : validate input playe rand scores
            return scores[playerId];
        }

        public void UpdateScore(int playerId,int score)
        {
            Console.WriteLine("Inside UpdateScore");
            //todo : validate input playe rand scores
            scores[playerId] = score;
        }
    }
}

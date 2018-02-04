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
        Dictionary<int, int> scores;

        public Database()
        {

        }

        public int CreateContest(bool isPrivate = false)
        {
            return ++contest_id;
        }

        public int CreatePlayer()
        {
            return ++player_id;
        }

        public int getScore(int playerId)
        {
            int score = 0;

            if (!scores.TryGetValue(playerId, out score))
                return 0; //todo raise exception
            return score;

        }

        public int getScore(int playerId, int ContestID)
        {
            //todo : validate input playe rand scores
            return scores[playerId];
        }

        public void UpdateScore(int playerId,int score)
        {
           //todo : validate input playe rand scores
            scores[playerId] = score;
        }
    }
}

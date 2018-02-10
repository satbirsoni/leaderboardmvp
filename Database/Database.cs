using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Player
    {
        private int score = 0;
        public Player()
        {
        }

        public int getScore()
        {
            return score;
        }

        public void setScore(int score)
        {
            this.score = score;
        }

    }
    class Contest
    {
        private int id = 0;
        private int clientID = 0;
        private int playerids = 0;
        bool isPrivate = false;
        Dictionary<int, Player> players = new Dictionary<int, Player>();
        public Contest(int id, int clientid, bool isPrivate = false)
        {
            this.isPrivate = isPrivate;
            this.id = id;
            this.clientID = clientid;
        }
        public bool IsPrivate()
        {
            return isPrivate;
        }
        public int GetID()
        {
            return id;
        }

        public Dictionary<int, int> todict()
        {
            var rv = new Dictionary<int, int>();
            foreach (var p in players)
            {
                rv[p.Key] = p.Value.getScore();
            }
            return rv;
        }
        public int GetClientID()
        {
            return clientID;
        }

        public int addPlayer()
        {
            Console.WriteLine("Contest create player");
            var rv = ++playerids;
            players[rv] = new Player();
            return rv;

        }

        public void setScore(int playerid, int score)
        {
            Player player;
            players.TryGetValue(playerid, out player);
            if (player != null)
            {
                player.setScore(score);
            }
        }

        public int [] getPlayers()
        {
            var l = new List<int>();

            foreach (var p in players)
                l.Add(p.Key);

            return l.ToArray();
        }
    }
  
    public class Database : IDatabase
    {
        int contest_id = 0;
        int player_id = 0;
        Dictionary<int, Contest> contest = new Dictionary<int, Contest>();

        public Database()
        {
            Console.WriteLine("Database c'tor");

        }

        public int CreateContest(int clientid, bool isFalse=false)
        {
            Console.WriteLine("Inside CreateContest");
            var rv =  ++contest_id;
            var c = new Contest(rv, clientid, isFalse);
            contest[rv] = c;
            return rv;
        }     

        public int CreatePlayer(int contestid)
        {
            Console.WriteLine("Inside CreatePlayer");
            Contest c;
            contest.TryGetValue(contestid, out c);
            if (c!=null)
            {
               return c.addPlayer();
            }
            

            return -1;
        }

        public int CreatePrivateContest(int clientid)
        {
            return this.CreateContest(clientid, true);
        }

        public int CreatePublicContest(int clientid)
        {
            return this.CreateContest(clientid, false);
        }

        private int[] getAllContest(bool isPrivate=false, int clientid=0)
        {
            Console.WriteLine("getAllContest");

            List<int> rv = new List<int>();
            foreach (var v in contest)
            {
                if (isPrivate && v.Value.IsPrivate())
                {
                    if(v.Value.GetClientID()==clientid)
                        rv.Add(v.Key);
                }
                if (!isPrivate && !v.Value.IsPrivate())
                    rv.Add(v.Key);
            }
            return rv.ToArray();
                
        }

   

        public int[] GetAllPrivateContest(int clientid)
        {
            Console.WriteLine("Inside getAllPrivateContest");
            return getAllContest(true, clientid);
        }

        public int[] GetAllPublicContest()
        {
            Console.WriteLine("Inside GetAllPublicContest");
            return getAllContest();
        }

        public Dictionary<int, int> getContest(int contestID)
        {

            return contest[contestID].todict();
        }

        public int[] GetPrivateContest(int clientid)
        {
            throw new NotImplementedException();
        }

        public void UpdateScore(int contestid, int playerId, int score)
        {
            Console.WriteLine("Database UpdateScore contest{0}, player{1}, score{2}", contestid, playerId, score);
            Contest c;
            contest.TryGetValue(contestid, out c);
            if (c != null)
                c.setScore(playerId, score);
        }

        public int [] GetAllPlayers(int contestid)
        {
            Contest c;
            contest.TryGetValue(contestid, out c);
            if (c != null)
                return c.getPlayers();

            return null;
        }
    }
}

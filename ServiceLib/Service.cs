using System;
using System.Collections.Generic;
using Database;

namespace ServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {
        private static Database.IDatabase db = new Database.Database();
        private static int client_ids = 0;

        private int myClientID = ++client_ids;

        public int addContest()
        {
            return db.CreatePublicContest(myClientID);
        }

        public int AddPlayer(int contestID)
        {
            return db.CreatePlayer(contestID);
        }

        public int CreatePrivateContest()
        {
            return db.CreatePrivateContest(myClientID);
        }

        public int CreatePublicContest()
        {
            return db.CreatePublicContest(myClientID);
        }


        public int[] GetAllPrivateContest()
        {
            return db.GetAllPrivateContest(myClientID);
        }

        public int[] GetAllPubicContest()
        {
            return db.GetAllPublicContest();
        }
      
        public int UpdateContest()
        {
            throw new NotImplementedException();
        }

        public void UpdateScore(int contestid, int playerid, int score)
        {
            Console.WriteLine("Service update score contest {0}, player {1}, score {2}", contestid, playerid, score);
            db.UpdateScore(contestid, playerid, score);
        }

        Dictionary<int, int> IService.GetContest(int id)
        {
            return db.getContest(id);
        }

        public int [] GetAllPlayers (int contestID)
        {
            return db.GetAllPlayers(contestID);
        }
    }
}

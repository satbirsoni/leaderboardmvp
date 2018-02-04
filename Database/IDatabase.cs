using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    /*
     *  Interface for database
     */
    public interface IDatabase
    {
        /// <summary>
        /// Creates a contest
        /// </summary>
        /// <returns>unique id of contest</returns>
        int CreateContest(bool isPrivate=false);
        int[] GetAllPublicContest();
        int[] GetAllPrivateContest();
        int CreatePlayer();
        void UpdateScore(int playerId,int score);
        int getScore(int playerId);
    }
}

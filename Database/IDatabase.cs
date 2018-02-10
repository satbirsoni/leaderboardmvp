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
        /// Creates a public contest, Visible to all clients
        /// </summary>
        /// <param name="clientid"></param>
        /// <returns>Contst id</returns>
        int CreatePublicContest(int clientid);
        /// <summary>
        /// Creates a priveate contest only visible to this client
        /// </summary>
        /// <param name="clientid"></param>
        /// <returns></returns>
        int CreatePrivateContest(int clientid);
        /// <summary>
        /// Returns all public contests
        /// </summary>
        /// <returns></returns>
        int[] GetAllPublicContest();
        /// <summary>
        /// Returns all private contest for this client
        /// </summary>
        /// <param name="clientid"></param>
        /// <returns></returns>
        int[] GetAllPrivateContest(int clientid);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="contestid"></param>
        /// <returns></returns>
        int CreatePlayer(int contestid);
        /// <summary>
        /// Updates score for a player
        /// </summary>
        /// <param name="contestid"></param>
        /// <param name="playerId"></param>
        /// <param name="score"></param>
        void UpdateScore(int contestid, int playerId,int score);
        /// <summary>
        /// Retrusn a contest for this id
        /// </summary>
        /// <param name="contestID"></param>
        /// <returns></returns>
        Dictionary<int,int> getContest(int contestID);

        int [] GetAllPlayers(int contestID);
    }
}

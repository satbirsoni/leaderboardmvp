using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

namespace ServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        /// <summary>
        /// Creates a public contest for given client
        /// </summary>        
        /// <returns></returns>
        [OperationContract]
        int CreatePublicContest();

        /// <summary>
        /// Creates a private contest for given client
        /// </summary>
        
        /// <returns></returns>
        [OperationContract]
        int CreatePrivateContest();

        /// <summary>
        /// Returns ID of all public contests
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        int[] GetAllPubicContest();

        /// <summary>
        /// Returns ID of all private contest for this client
        /// </summary>        
        /// <returns></returns>
        [OperationContract]
        int [] GetAllPrivateContest();

        /// <summary>
        /// Return a contest for given ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        Dictionary<int, int> GetContest(int id);

        /// <summary>
        /// Adds a player for given contest
        /// </summary>
        /// <param name="contestID"></param>
        /// <returns>Unique id of created player</returns>
        [OperationContract]
        int AddPlayer(int contestID);

        /// <summary>
        /// Updates score for given player
        /// </summary>
        /// <param name="contestid"></param>
        /// <param name="playerid"></param>
        /// <param name="score"></param>
        [OperationContract]
        void UpdateScore(int contestid, int playerid, int score);

        [OperationContract]
        int [] GetAllPlayers(int contestid);
    }


}

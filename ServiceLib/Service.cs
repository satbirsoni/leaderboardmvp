using System;
using Database;

namespace ServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {
        Database.IDatabase db = new Database.Database();

        public int addContest()
        {
            return db.CreateContest();
        }

        public int createPrivateContest()
        {
            return db.CreateContest(true);
        }

        public int createPublicContest()
        {
            return db.CreateContest();
        }

        public int[] geAllPrivateContest()
        {
            return db.GetAllPrivateContest();
        }

        public int[] geAllPubicContest()
        {
            return db.GetAllPublicContest();
        }

        public int getContest()
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Contest GetDataUsingDataContract(Contest composite)
        {
           return composite;
        }

        public int UpdateContest()
        {
            throw new NotImplementedException();
        }
    }
}

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
            throw new NotImplementedException();
        }

        public int createPrivateContest()
        {
            throw new NotImplementedException();
        }

        public int createPublicContest()
        {
            throw new NotImplementedException();
        }

        public int geAllPrivateContest()
        {
            throw new NotImplementedException();
        }

        public int[] geAllPubicContest()
        {
            throw new NotImplementedException();
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

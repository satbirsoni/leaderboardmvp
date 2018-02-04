using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        int createPublicContest();

        [OperationContract]
        int createPrivateContest();

        [OperationContract]
        int[] geAllPubicContest();

        [OperationContract]
        int geAllPrivateContest();

        [OperationContract]
        int getContest();

        [OperationContract]
        int UpdateContest();



        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceLib.ContractType".
    [DataContract]
    public class Contest
    {
   
        public void print () { Console.WriteLine("Hello from server"); }
    }
}

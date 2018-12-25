using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WindowsFormsApplication3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDBUser" in both code and config file together.
    [ServiceContract]
    public interface IDBUser
    {
        [OperationContract]
        void OpenConnection();
        [OperationContract]
        void ReadAllUsers(int UID);
        [OperationContract]
        void InsertUser(string username, string password, string firstname, string lastname, int age, int weight, string gender, int height, int target,int planid);
        [OperationContract]
        void UpdateUser(int UserID, string username, string password, string firstname, string lastname, int age, int weight, string gender, int height, int target, int planid);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDBPlan" in both code and config file together.
    [ServiceContract]
    public interface IDBPlan
    {

        [OperationContract]
        void OpenConnection();
        [OperationContract]
        void ReadPlan(int PID);
    }
}

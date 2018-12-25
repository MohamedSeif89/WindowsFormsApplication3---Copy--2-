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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DBSystem" in both code and config file together.
    public class DBSystem : IDBSystem
    {
        SqlConnection sc;
        SqlDataAdapter sda;
        DataSet ds;
            public void OpenConnection()
        {
            sc = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog= WeightTracker Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            sc.Open();
        }
        public void DoWork()
        {
        }
        public void InsertHistory(DateTime D, DateTime NRD, int Weight,int UID)
        {
            OpenConnection();
            SqlCommand smd = new SqlCommand("insert into dbo.History (Date,NextReminder,Weight,UserID) values (D,NRD,W,UID)", sc);
            SqlParameter sp = new SqlParameter("UN", D);
            SqlParameter sp2 = new SqlParameter("P", NRD);
            SqlParameter sp3 = new SqlParameter("FN", Weight);
            SqlParameter sp4 = new SqlParameter("FN", UID);

            smd.Parameters.Add(sp);
            smd.Parameters.Add(sp2);
            smd.Parameters.Add(sp3);
            smd.Parameters.Add(sp4);
            sc.Close();
        }
        public void View(int UID)
        {
            DateTime[] D = new DateTime[100];
            DateTime[] NRD = new DateTime[100];
            int[] W = new int[100];
            OpenConnection();
            SqlCommand smd = new SqlCommand("select H.Date,H.NextReminder, H.Weight from dbo.History H,User U  where U.UserID = ID", sc);
            SqlParameter sp = new SqlParameter("ID", UID);
            SqlDataReader reader = smd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {              
                D[i] = Convert.ToDateTime((string)reader["Date"]); 
                NRD[i] = Convert.ToDateTime((string)reader["NextReminder"]);
                W[i] = Int32.Parse((string)reader["Weight"]);
                i++;
            }
            reader.Close();
            sc.Close();
        }
    }
}

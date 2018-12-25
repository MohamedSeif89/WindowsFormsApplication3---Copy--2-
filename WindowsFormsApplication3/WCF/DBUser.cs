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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DBUser" in both code and config file together.
    public class DBUser : IDBUser
    {
        SqlConnection sc;
        SqlDataAdapter sda;
        DataSet ds;

        public void OpenConnection()
        {
            sc = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog= WeightTracker Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            sc.Open();
        }
        public void ReadAllUsers(int UID)
        {
            string username, password, firstname, lastname, age, weight, gender, height, target, planid;
            
            OpenConnection();
            //select UserName,Password,FirstName,LastName,Age,Weight,Gender,Height,TargetWeight,PlanID from dbo.User where UserID = ID"
            SqlCommand smd = new SqlCommand("select * from dbo.User where UserID = ID",sc);
            SqlParameter sp = new SqlParameter("ID", UID);
            SqlDataReader reader = smd.ExecuteReader();
            int i = 0;
            while(reader.Read())
            {
                               
                 username = (string)reader["UserName"]; 
                 password = (string)reader["Password"];
                 firstname = (string)reader["FirstName"];
                 lastname = (string)reader["LastName"];
                 age = (string)reader["Age"];
                 weight = (string)reader["Weight"];
                 gender = (string)reader["Gender"];
                 height = (string)reader["Height"];
                 target = (string)reader["TargetWeight"];
                 planid = (string)reader["PlanID"];
                i++;
            }
            reader.Close();
            sc.Close();
        }
        public void InsertUser(string username, string password, string firstname,string lastname, int age, int weight, string gender, int height, int target, int planid)
        {
            OpenConnection();
            SqlCommand smd = new SqlCommand("insert into dbo.User (UserName,Password,FirstName,LastName,Age,Weight,Gender,Height,TargetWeight,PlanID) values (UN,P,FN,LN,A,W,G,H,TW,PID)", sc);
            SqlParameter sp = new SqlParameter("UN", username);
            SqlParameter sp2 = new SqlParameter("P", password);
            SqlParameter sp3 = new SqlParameter("FN", firstname);
            SqlParameter sp4 = new SqlParameter("LN", lastname);
            SqlParameter sp5 = new SqlParameter("A", age);
            SqlParameter sp6 = new SqlParameter("W", weight);
            SqlParameter sp7 = new SqlParameter("G", gender);
            SqlParameter sp8 = new SqlParameter("H", height);
            SqlParameter sp9 = new SqlParameter("TW", target);
            SqlParameter sp10 = new SqlParameter("PID", planid);

            smd.Parameters.Add(sp);
            smd.Parameters.Add(sp2);
            smd.Parameters.Add(sp3);
            smd.Parameters.Add(sp4);
            smd.Parameters.Add(sp5);
            smd.Parameters.Add(sp6);
            smd.Parameters.Add(sp7);
            smd.Parameters.Add(sp8);
            smd.Parameters.Add(sp9);
            smd.Parameters.Add(sp10);
            sc.Close();


        }

        public void UpdateUser(int UserID,string username, string password, string firstname,string lastname, int age, int weight, string gender, int height, int target, int planid)
        {
            OpenConnection();
            SqlCommand smd = new SqlCommand("update dbo.User set UserName=:UN,Password=:P,FirstName=:FN,LastName=:LN,Age=:A,Weight=:W,Gender=:G,Height=:H,TargetWeight=:TW where UserID=:UID)", sc);
            SqlParameter sp = new SqlParameter("UID", UserID);
            SqlParameter sp1 = new SqlParameter("UN", username);
            SqlParameter sp2 = new SqlParameter("P", password);
            SqlParameter sp3 = new SqlParameter("FN", firstname);
            SqlParameter sp4 = new SqlParameter("LN", lastname);
            SqlParameter sp5 = new SqlParameter("A", age);
            SqlParameter sp6 = new SqlParameter("W", weight);
            SqlParameter sp7 = new SqlParameter("G", gender);
            SqlParameter sp8 = new SqlParameter("H", height);
            SqlParameter sp9 = new SqlParameter("TW", target);
            SqlParameter sp10 = new SqlParameter("PID", planid);

            smd.Parameters.Add(sp);
            smd.Parameters.Add(sp1);
            smd.Parameters.Add(sp2);
            smd.Parameters.Add(sp3);
            smd.Parameters.Add(sp4);
            smd.Parameters.Add(sp5);
            smd.Parameters.Add(sp6);
            smd.Parameters.Add(sp7);
            smd.Parameters.Add(sp8);
            smd.Parameters.Add(sp9);
            smd.Parameters.Add(sp10);
            sc.Close();


        }


    }
}

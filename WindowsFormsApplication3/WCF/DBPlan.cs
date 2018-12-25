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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DBPlan" in both code and config file together.
    public class DBPlan : IDBPlan
    {
        SqlConnection sc;
        SqlDataAdapter sda;
        DataSet ds;
        public void OpenConnection()
        {
            sc = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog= WeightTracker Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            sc.Open();
        }
        public void ReadPlan(int PID )
        {
            string PN,RF;
            int WH,DC,BFC,LC,DLC,SC;

            OpenConnection();

            SqlCommand smd = new SqlCommand("select * from dbo.Plan where PlanID = ID",sc);
            SqlParameter sp = new SqlParameter("ID", PID);
            SqlDataReader reader = smd.ExecuteReader();
            int i = 0;
            while(reader.Read())
            {                
                 PN = (string)reader["PlanName"]; 
                 WH = Int32.Parse((string)reader["WeeklyHours"]);
                 DC = Int32.Parse((string)reader["DailyCalories"]);
                 BFC = Int32.Parse((string)reader["BreakFastCalories"]);
                 LC = Int32.Parse((string)reader["LunchCalories"]);
                 DLC = Int32.Parse((string)reader["DinnerCals"]);
                 SC = Int32.Parse((string)reader["SnackCals"]);
                 RF = (string)reader["RecFood"];

                i++;
            }
            reader.Close();
            sc.Close();
            
        }

    }
}

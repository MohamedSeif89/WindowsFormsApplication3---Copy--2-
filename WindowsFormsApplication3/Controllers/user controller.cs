using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.Models;
using WindowsFormsApplication3.WCF;




namespace WindowsFormsApplication3.Controllers
{
    class user_controller
    {
        public User user;
        public DBUser temp2 = new DBUser();
        public plancontroller plantemp = new plancontroller();

        public void register(string username, string password, string firstname, string lastname, int age,int weight,string gender, int height,int target) 
        {
            int planid = 0 ;
            planid = plantemp.provideplan(weight, target);
            temp2.InsertUser(username, password,  firstname, lastname, age, weight, gender,  height, target,planid);
            //string username, string password, string firstname,string lastname, int age, int weight, string gender, int height, int target, int planid
        
        }
        public void login()
        { 
        
        
        }

        public void view()
        { 
        
        
        }

        public void update() 
        {
        
        
        }

        public void logout()
        {
 


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.Models;

namespace WindowsFormsApplication3.Controllers
{
    class plancontroller
    {


        public int provideplan(int current,int target) 
        {
            int kgs;
            
            kgs = current - target;
            if (kgs > 0 && kgs <= 10) {
                kgs = 1;
            }

            else if (kgs > 10 && kgs <= 20)
            {
                kgs = 2;
            }
            else if (kgs > 20 && kgs <= 30)
            {
                kgs = 3;
            }
            else if (kgs > 30 && kgs <= 40)
            {
                kgs = 4;
            }
            else if (kgs > 40)
            {
                kgs = 5;
            }
            return kgs;
        }
        public void registerplan() 
        {
        
        }

        public void deletepplan()
        { 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareChecker
{
    public class Checker
    {
        public bool Check(int n)
        {

            if((n >= 0) && (Math.Sqrt(n) % 1 == 0)) {
                
                return true;
            } else
            { 
                return false; 
            }
                
           

          


        }
    }
}

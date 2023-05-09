using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApp.app
{
    public class ActionC
    {
        public void square(int nmbr)
        {
            int sq = nmbr * nmbr;
            Console.WriteLine("Square of the given number is  " + sq);

            // Don’t provide any return statement  
        }
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}

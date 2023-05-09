using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApp.app
{
    public class ActionA
    {
        protected void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        public void sayHello(string fname)
        {
            Console.WriteLine("Hello "+fname);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApp.app.functionD
{
    public  class ActionD
    {
        protected void method()
        {
            Console.WriteLine("I just got executed!");
        }
        public void sayHelloWorld(string fname)
        {
            Console.WriteLine("Hello " + fname);
        }
    }
}

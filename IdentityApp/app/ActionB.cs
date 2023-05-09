using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApp.app
{
    public class ActionB
    {
        public int MyAge()
        {
            return 53;
        }
        public float Sum(int[] values, int startindex, int endindex)
        {
            var total = 0;
            for (var index = startindex; index <= endindex; index++)
            {
                total += values[index];
            }
            return total;
        }
    }
}

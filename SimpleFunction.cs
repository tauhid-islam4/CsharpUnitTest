using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpUnitTest
{
    internal class SimpleFunction
    {
        public string returnsDogIfOne(int num)
        {
            if (num == 1) 
                { return "DOG"; }
            else 
                { return "CAT"; }
        }
    }
}

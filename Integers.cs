using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    public class Integers
    {
        public int myMethod(int x, int y = 10)
        {
            int result = x * y;
            return result;
        }
    }
}
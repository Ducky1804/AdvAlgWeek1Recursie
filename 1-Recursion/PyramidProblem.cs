using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALGA
{
    public class PyramidProblem
    {
        public static int triangular_number_recursive(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return triangular_number_recursive(n - 1) + n;
        }

        public static int triangular_number_iterative(int n)
        {
            int result = 0;
            while (n >= 0)
            {
                result += n;
                n--;
            }
            return result;
        }

        public static int triangular_number_function(int n)
        { 
            return n * (n + 1) / 2;
        }
    }
}

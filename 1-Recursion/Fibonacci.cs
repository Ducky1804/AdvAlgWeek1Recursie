using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Fibonacci
    {
        public static int fibonacci_recursive(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            
            return fibonacci_recursive(n - 1) + fibonacci_recursive(n - 2);
        }

        public static int fibonacci_iterative(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            
            int prev = 0;
            int current = 1;
            int result;
            
            for (int i = 2; i <= n; i++)
            {
                result = current + prev;
                prev = current;
                current = result;
            }
            
            return current;
        }

        public enum Answer { IterativeIsFaster, RecursiveIsFaster };

        public static Answer which_is_faster()
        {
            return Answer.IterativeIsFaster;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_for_recursion_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory f = new Factory();
            int add_for = f.Sum1ToXFor(100);
            Console.WriteLine(add_for);
            int add_recursion = f.Sum1ToXRecursion(50);
            Console.WriteLine(add_recursion);
            int add_math = f.Sum1ToXMath(20);
            Console.WriteLine(add_math);
        }
    }

    class Factory
    {
        public int Sum1ToXFor(int x)
        {
            int result = 0;
            for (int i = 1; i <= x; i++)
            {
                result = result + i;
            }
            return result;
        }
        public int Sum1ToXRecursion(int x)
        {
            if (x==1)
            {
                return 1;
            }
            else
            {
                int result = x + Sum1ToXRecursion(x - 1);
                return result;
            }
        }
        public int Sum1ToXMath(int x)
        {
            int result = (1 + x) * x / 2;
            return result;
        }
    }
}

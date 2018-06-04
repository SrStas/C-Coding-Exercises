using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereotypicalCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidParentheses runner = new ValidParentheses();
            string inString = "([()[]({{}})[{}]])";
            if (!(inString.Length % 2 == 0))
            {
                return false;
            }
            var result = runner.run(inString);
            if (result.Length !=0)
              Console.WriteLine("false");
            else
                Console.WriteLine("true");

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

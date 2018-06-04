using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereotypicalCoding
{
    class ValidParentheses
    {
        public string run(string s)
        {
            int tempLength = s.Length;
           s= s.Replace("()", "");
            s = s.Replace("{}", "");
            s =  s.Replace("[]", "");
            if (!(s.Length< tempLength )||s.Length ==0)
            {
                return s;
            }
            return run(s);
        }

        public bool Run(string inString)
        {
            inString = "([()[]{{}}] )";
            inString.Replace("()", "");
            inString.Replace("{}", "");
            inString.Replace("[]", "");

            var inArray = inString.ToArray();
            List<List<char>> newlist = new List<List<char>>();
            List<char> opnList = new List<char>();
            List<char> clsList = new List<char>();

            foreach (var item in inArray)
            {
                if (item=='('||item ==')'|| item == '[' || item == ']' || item == '{' || item == '}')
                {
                    
                    switch (item)
                    {
                        case '{':
                        case '[':
                        case '(':
                            
                            break;
                        case ')':
                            break;
                        
                        case ']':
                            break;
                        
                        case '}':
                            break;
                        default:
                            break;
                    }

                }
            }

            return true;
        }
    }
}

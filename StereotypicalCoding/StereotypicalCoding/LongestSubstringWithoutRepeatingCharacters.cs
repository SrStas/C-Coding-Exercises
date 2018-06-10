using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereotypicalCoding
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        public string Run(string s)
        {
            //List<string> allSubStrings = new List<string>();
            int longest = 0;
            string retVal = String.Empty;
            List<char> tempString = new List<char>();
            int pointer = 0;
            bool stop = false;
            while (true)
            {
                for (int i = pointer; i < s.Length; i++)
                {
                    if (!tempString.Contains(s[i]))
                    {
                        tempString.Add(s[i]);

                    }
                    else
                    {
                        if (tempString.Count > longest)
                        {
                            longest = tempString.Count;
                            retVal = new string(tempString.ToArray());
                        }

                        pointer++;
                        tempString = new List<char>();
                        if (i == s.Length - 1)
                        {
                            stop = true;
                        }
                        break;
                    }

                    if (i == s.Length - 1)
                    {
                        if (tempString.Count > longest)
                        {
                            longest = tempString.Count;
                            retVal = new string(tempString.ToArray());
                        }

                        stop = true;
                    }
                }

                if (stop || s.Length == 0)
                {
                    break;
                }
            }

            return retVal;
        }

        public int Run2(string s)
        {
            List<char> str = s.ToList();
            int longest = 0;
            List<char> tmpLst = new List<char>();

            while (str.Count!=0)
            {
                for (int i = 0; i < str.Count; i++)
                {
                    if (!tmpLst.Contains(str[i]))
                    {
                        tmpLst.Add(str[i]);
                    }
                    else
                    {
                        if (longest < tmpLst.Count)
                        {
                            longest = tmpLst.Count;
                        }
                        tmpLst = new List<char>();
                        str.RemoveAt(0);
                        break;
                    }


                }
            }
            
            return longest;
        }

        public int Run3(string s)
        {
            
            int longest = 0;
            int[] arry = new int[256];
            List<char> tmpLst = new List<char>();
            int lastVisited = 0;
            while (lastVisited <= s.Length-1)
            {
                for (int i = lastVisited; i < s.Length; i++)
                {
                    if (!tmpLst.Contains(s[i]))
                    {
                        tmpLst.Add(s[i]);
                    }
                    else
                    {
                        if (longest < tmpLst.Count)
                        {
                            longest = tmpLst.Count;
                        }
                        tmpLst = new List<char>();
                        lastVisited++;
                        break;
                    }


                }
            }

            return longest;
        }

        public int Run4(string s)
        {

            int longest = 0;
            int[] arry = new int[256];
            List<char> tmpLst = new List<char>();
            int lastVisited = 0;
            while (lastVisited <= s.Length - 1)
            {
                if (s.Length==1)
                {
                    return 1;
                }
                for (int i = lastVisited; i < s.Length; i++)
                {
                    if (!arry.Contains(s[i]))
                    {
                        arry[i]=s[i];
                        
                    }
                    else
                    {
                        if (longest < (i - lastVisited))
                        {
                            longest = i-lastVisited;
                        }
                        arry = new int[256];
                        lastVisited++;
                        break;
                    }


                }
            }

            return longest;
        }
    }
}

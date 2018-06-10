using System;
using System.Linq;

namespace StereotypicalCoding
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            bool minus = false;
            if (x < 0)
            {
                minus = true;
                x = x * -1;
            }

            if (x%10 == 0)
            {
                x = x / 10;
            }
            int retVal = 0;

            string xstring = x.ToString();

            var arry = xstring.ToCharArray();
            char[] revarry =arry.Reverse().ToArray();
            var tmp = revarry.ToString();
            try
            {
                retVal = Int32.Parse(new string(revarry));
            }
            catch (Exception e)
            {
                return 0;
            }
            
            if (minus)
            {
                retVal = retVal * -1;
            }

            return retVal;
        }
    }
}
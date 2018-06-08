using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereotypicalCoding
{
    class TwoSum
    {
        public int[] sum(int[] nums, int target)
        {
            int[] retVal = new int[2];
            int pointer = 0;
            int length = nums.Length;

            while (pointer<length)
            {
                for (int i = pointer + 1; i < length; i++)
                {
                    if (nums[pointer] + nums[i] == target)
                    {
                        retVal = new[] { pointer, i };
                    }
                }

                pointer++;
            }
            

            return retVal;
        }
    }
}

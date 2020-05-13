using System;
using System.Collections.Generic;

namespace Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 1,2,3,4,3 };
            Console.WriteLine(ContainsDuplicate(test).ToString());
        }


        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, bool> result = new Dictionary<int, bool>();

            foreach (var i in nums)
            {
                if (result.ContainsKey(i))
                    return true;
                else
                    result.Add(i, true);
            }

            return false;
        }
    }
}

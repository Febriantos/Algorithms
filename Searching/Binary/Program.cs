using System;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[1] { -1 };
            int target = -1;
            Console.WriteLine("expected 0 result " + Search(nums, target));

            nums = new int[7] { 1, 3, 5, 7, 8, 9, 12 };
            target = 4;
            Console.WriteLine("expected -1 result " + Search(nums, target));

            nums = new int[5] { -3, -1, 5, 7, 11 };
            target = 7;
            Console.WriteLine("expected 3 result " + Search(nums, target));

            nums = new int[4] { -5, 2, 5, 7 };
            target = -5;
            Console.WriteLine("expected 0 result " + Search(nums, target));

            nums = new int[3] { -1, 0, 5 };
            target = 5;
            Console.WriteLine("expected 2 result " + Search(nums, target));

            nums = new int[1];
            target = 5;
            Console.WriteLine("expected -1 result " + Search(nums, target));
            Console.ReadLine();
        }

        public static int Search(int[] nums, int target)
        {
            int mid, left, right;
            left = 0;
            right = nums.Length - 1;

            while (left <= right)
            {
                mid = (left + right) >> 1;
                if (nums[mid] < target)
                    left = mid + 1;
                else if (nums[mid] > target)
                    right = mid - 1;
                else
                    return mid;
            }

            return -1;
        }
    }
}

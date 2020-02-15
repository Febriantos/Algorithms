using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInRotatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[1] { -1 };
            int target = -1;
            Console.WriteLine("expected 0 result " + Search(nums, target));

            nums = new int[2] { 1, 3 };
            target = 0;
            Console.WriteLine("expected -1 result " + Search(nums, target));


            nums = new int[7] { 7, 8, 9, 12, 1, 3, 5 };
            target = 8;
            Console.WriteLine("expected 1 result " + Search(nums, target));

            nums = new int[5] { 7, 11, -3, -1, 5 };
            target = 7;
            Console.WriteLine("expected 0 result " + Search(nums, target));

            nums = new int[4] { 2, 5, 7, -5 };
            target = -5;
            Console.WriteLine("expected 3 result " + Search(nums, target));

            nums = new int[3] { 5, -1, 0 };
            target = 0;
            Console.WriteLine("expected 2 result " + Search(nums, target));

            nums = new int[1];
            target = 5;
            Console.WriteLine("expected -1 result " + Search(nums, target));
            Console.ReadLine();
        }

        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 1)
                return nums[0] == target ? 0 : -1;

            int pivot = IndexSearch(nums);

            if (pivot == -1)
                return BinarySearch(nums, target, 0, nums.Length-1);
            else if (target >= nums[0])
                return BinarySearch(nums, target, 0, pivot);
            else if (target >= nums[pivot + 1])
                return BinarySearch(nums, target, pivot+1, nums.Length-1);
            return -1;
        }

        public static int IndexSearch(int[] nums)
        {
            int left = 0;
            int right = nums.Length-1;
            int mid;
            while (left <= right)
            {
                mid = (left + right) >> 1;
                if (right >= mid + 1 && nums[mid] > nums[mid + 1])
                    return mid;
                else if (left <= mid - 1 && nums[mid] < nums[mid - 1])
                    return mid - 1;
                else if (nums[left] > nums[mid])
                    right = mid - 1;
                else 
                    left = mid + 1;
            }

            return -1;
        }
         
        public static int BinarySearch(int[] nums, int target, int left, int right)
        {
            int mid;
            while(left <= right)
            {
                mid = left + right >> 1;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else if (nums[mid] > target)
                    right = mid - 1;
            }
            return -1;
        }
    }
}

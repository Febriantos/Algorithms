using System;
using System.Collections.Generic;

namespace ProductOfTheLastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductOfNumbers productOfNumbers = new ProductOfNumbers();
            productOfNumbers.Add(3);        // [3]
            productOfNumbers.Add(0);        // [3,0]
            //productOfNumbers.Add(2);        // [3,0,2]
            //productOfNumbers.Add(5);        // [3,0,2,5]
            //productOfNumbers.Add(4);        // [3,0,2,5,4]
            Console.WriteLine(productOfNumbers.GetProduct(2)); // return 20. The product of the last 2 numbers is 5 * 4 = 20
            Console.WriteLine(productOfNumbers.GetProduct(3)); // return 40. The product of the last 3 numbers is 2 * 5 * 4 = 40
            Console.WriteLine(productOfNumbers.GetProduct(4)); // return 0. The product of the last 4 numbers is 0 * 2 * 5 * 4 = 0
            productOfNumbers.Add(8);        // [3,0,2,5,4,8]
            Console.WriteLine(productOfNumbers.GetProduct(2)); // return 32. The product of the last 2 numbers is 4 * 8 = 32 
            Console.ReadLine();
        }
    }

    public class ProductOfNumbers
    {

        private List<int> Numbers { get; set; }
        private List<int> Result { get; set; }

        public ProductOfNumbers()
        {
            Numbers = new List<int>();
            Result = new List<int>();
        }

        public void Add(int num)
        {
            if (num >= 0 && num <= 100)
                Numbers.Add(num);
        }

        public int GetProduct(int k)
        {
            if (k < 1 || k > 40000)
                return 0;
            var result = 1;
            int max = Numbers.Count;
            bool isAllOne = true;
            for (int i = max - 1; i >= (max - k) && i >= 0; i--)
            {
                if (Numbers[i] == 0)
                    return 0;
                if (Numbers[i] != 1 && isAllOne)
                    isAllOne = false;
            }

            if (isAllOne)
                return 1;

            for (int i = max - 1; i >= (max - k) && i >= 0; i--)
            {
                result *= Numbers[i];
            }

            return result;
        }
    }
}

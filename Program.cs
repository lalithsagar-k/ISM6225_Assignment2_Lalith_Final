using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));
            
            // Additional test cases for Question 1
            Console.WriteLine("Q1 - Edge Case (Empty array):");
            Console.WriteLine(string.Join(",", FindMissingNumbers(new int[] { })));

            Console.WriteLine("Q1 - All numbers present:");
            Console.WriteLine(string.Join(",", FindMissingNumbers(new int[] { 1, 2, 3, 4, 5 })));



            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

             // Additional test cases for Question 2
            Console.WriteLine("Q2 - All even numbers:");
            Console.WriteLine(string.Join(",", SortArrayByParity(new int[] { 2, 4, 6 })));

            Console.WriteLine("Q2 - All odd numbers:");
            Console.WriteLine(string.Join(",", SortArrayByParity(new int[] { 1, 3, 5 })));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

             // Additional test cases for Question 3
            Console.WriteLine("Q3 - No match:");
            Console.WriteLine(string.Join(",", TwoSum(new int[] { 1, 2, 3 }, 10)));

            Console.WriteLine("Q3 - Duplicates:");
            Console.WriteLine(string.Join(",", TwoSum(new int[] { 3, 3 }, 6)));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

              // Additional test case for Question 4
            Console.WriteLine("Q4 - With negatives:");
            Console.WriteLine(MaximumProduct(new int[] { -10, -10, 5, 2 }));


            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);


            // Additional test cases for Question 5
            Console.WriteLine("Q5 - Decimal 0:");
            Console.WriteLine(DecimalToBinary(0));

            Console.WriteLine("Q5 - Decimal 3:");
            Console.WriteLine(DecimalToBinary(3));

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);


            // Additional test case for Question 6
            Console.WriteLine("Q6 - Already sorted:");
            Console.WriteLine(FindMin(new int[] { 1, 2, 3, 4, 5 }));


            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Additional test cases for Question 7
            Console.WriteLine("Q7 - Single digit:");
            Console.WriteLine(IsPalindrome(5));

            Console.WriteLine("Q7 - Negative number:");
            Console.WriteLine(IsPalindrome(-121));


            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);

            // Additional test cases for Question 8
            Console.WriteLine("Q8 - Fibonacci of 0:");
            Console.WriteLine(Fibonacci(0));

            Console.WriteLine("Q8 - Fibonacci of 10:");
            Console.WriteLine(Fibonacci(10));
        }

        // Question 1: Find Missing Numbers in Array
        // Finds all numbers missing from the range [1, n] using negative marking
        // Edge case: returns empty list if array is null or empty
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                if (nums == null || nums.Length == 0) 
                return new List<int>();

                List<int> result = new List<int>();

                 // Mark indices corresponding to values by negating

                for (int i = 0; i < nums.Length; i++)
                {
                    int index = Math.Abs(nums[i]) - 1;
                    if (nums[index] > 0)
                     nums[index] = -nums[index];
                }
                 // If a number is still positive, it was never visited

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                    result.Add(i + 1);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        // Sorts an array so that even numbers come before odd numbers
        // Uses two-pointer approach. Edge case: returns original if array is null or small

        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code hereif (nums == null || nums.Length <= 1) return nums;
                 if (nums == null || nums.Length <= 1)
            return nums;

            int left = 0, right = nums.Length - 1;

                while (left < right)
                 {
                    
                    // Swap when left is odd and right is even
                    if (nums[left] % 2 > nums[right] % 2)
             {   
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
             }

            if (nums[left] % 2 == 0) left++;
            if (nums[right] % 2 == 1) right--;
        }

        return nums;
    }
    catch (Exception)
    {
        throw;
    }
}

        // Question 3: Two Sum
        // Finds two indices such that nums[i] + nums[j] = target
        // Edge case: handles null or small array

        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here 
                if (nums == null || nums.Length < 2) return new int[0];

                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                    {
                      int complement = target - nums[i];
                      if (map.ContainsKey(complement))
                        return new int[] { map[complement], i };
                        
                        if (!map.ContainsKey(nums[i]))
                        map[nums[i]] = i;
                    }
                return new int[0];
                return new int[0]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
         // Returns the maximum product of any three numbers
        // Edge case: returns 0 for arrays shorter than 3

        public static int MaximumProduct(int[] nums)
        {
            try
            {
                
                Array.Sort(nums);  // Sort to access largest and smallest
                int n = nums.Length;

                // Edge case: less than 3 elements
                if (n < 3) return 0;

                // Compare product of top 3 and 2 smallest * largest
                return Math.Max(nums[n - 1] * nums[n - 2] * nums[n - 3],
                nums[0] * nums[1] * nums[n - 1]);
             
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
          // Converts a decimal number to binary string
        // Edge case: if number is 0, returns "0"

        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                if (decimalNumber == 0) return "0";

                string binary = "";
                    while (decimalNumber > 0)
                    {
                      binary = (decimalNumber % 2) + binary;
                     decimalNumber /= 2;
                    }
                    return binary;
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        // Finds the minimum value in a rotated sorted array using binary search
        // Edge case: handles null or empty array

        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                if (nums == null || nums.Length == 0)
                 return -1;

                int left = 0, right = nums.Length - 1;

                while (left < right)
                {
                     int mid = left + (right - left) / 2;
                     if (nums[mid] > nums[right])
                         left = mid + 1;
                    else
                      right = mid;
                }

                return nums[left];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        // Checks whether an integer is a palindrome (same forward and backward)
        // Edge case: negative numbers are not palindromes

        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                if (x < 0) return false;

                    int original = x, reversed = 0;
                    while (x > 0)
                {
                    int digit = x % 10;
                    reversed = reversed * 10 + digit;
                    x /= 10;
                }

                return original == reversed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        // Returns the nth Fibonacci number using an iterative approach
        // Edge case: if n is 0 or 1, return directly
        
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                if (n == 0) return 0;
                if (n == 1) return 1;

                int a = 0, b = 1, sum = 0;
                for (int i = 2; i <= n; i++)
                {
                     sum = a + b;
                     a = b;
                     b = sum;
                }
            return sum;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

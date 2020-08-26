﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Reflection.Metadata.Ecma335;

namespace LeetcodePractice
{








    //Leetcode - Backspace string compare
    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {

    //        string s = "y#fo##f";
    //        string t = "y#f#o##f";
    //        BackspaceCompare(s, t);  
    //    }

    //    public static bool BackspaceCompare(string S, string T)
    //    {
    //        char[] listOne = S.ToCharArray(), listTwo = T.ToCharArray();
    //        Stack<string> stack = new Stack<string>(), stackTwo = new Stack<string>();


    //        listOne.ToList().ForEach(j =>
    //        {
    //            if (j.ToString().Equals("#") && stack.Count() > 0) stack.Pop();
    //            else if (!j.ToString().Equals("#")) stack.Push(j.ToString());
    //        });

    //        listTwo.ToList().ForEach(j =>
    //        {
    //            if (j.ToString().Equals("#") && stackTwo.Count() > 0) stackTwo.Pop();
    //            else if(!j.ToString().Equals("#")) stackTwo.Push(j.ToString());
    //        });

    //        var t = string.Join("", stack) == string.Join("", stackTwo) ? true : false;

    //        return t;
    //    }
    //}





    //class Solution - n character multiple
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[] arr = { -2,0,10,-19,4,6,-8 };
    //        Console.WriteLine(CheckIfExist(arr) + " final");
    //    }

    //    public static bool CheckIfExist(int[] arr)
    //    {
    //        bool exists = default;
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            for (int j = 0; j < arr.Length; j++)
    //            {
    //              exists = arr[i] * 2 == arr[j] && i!= j ? true : false;
    //              if (exists == true)
    //                break;
    //            }
    //            if (exists == true)
    //                break;
    //        }
    //        return exists;
    //    }
    //}





    //class Solution - LEETCODE - Remove element - works locally not in editor 
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[] nums = { 3, 2, 2, 3 };
    //        int val = 3;

    //        Console.WriteLine(RemoveElement(nums, val));
    //    }

    //    public static int RemoveElement(int[] nums, int val)
    //    {
    //        nums = nums.Where(x => x != val && x != 0).ToArray();

    //        return nums.Length;
    //    }

    //}



    /* Leetcode - merge sorted array */

    //class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[] nums1 = { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
    //        int[] nums2 = { 1, 2, 2 };

    //        Merge(nums1, 6, nums2, 3);
    //    }

    //    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    //    {
    //        var mergedList = new List<int> {  };

    //        for (int i = 0; i < nums1.Length; i++)
    //        {
    //            if(!nums1[i].Equals(0))
    //                mergedList.Add(nums1[i]);
    //            if (i < nums2.Length && !nums2[i].Equals(0))
    //                mergedList.Add(nums2[i]);
    //        }

    //        Array.Clear(nums1, 0, m);

    //        for (int i = 0; i < mergedList.Count; i++)
    //           nums1[i] = mergedList[i];

    //        Array.Sort(nums1);

    //    }

    //}




    //class Solution - leetcode duplicate 0s - 93% faster
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[] nums = { 1, 0, 2, 3, 0, 4, 5, 0 };

    //        DuplicateZeros(nums);
    //        Console.WriteLine(nums.Length);

    //    }

    //    private static void DuplicateZeros(int[] arr)
    //    {

    //        List<int> calculationList = new List<int>();

    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //                if (arr[i].Equals(0))
    //                {
    //                    calculationList.Add(arr[i]);
    //                    calculationList.Add(0);
    //                }
    //                else
    //                {
    //                    calculationList.Add(arr[i]);
    //                }
    //        }

    //        calculationList.RemoveRange(arr.Length, (calculationList.Count) - arr.Length);

    //        Array.Clear(arr, 0, calculationList.Count);
    //        for(var i = 0; i < calculationList.Count; i++)
    //        {
    //            arr[i] = calculationList[i];
    //        }

    //    }
    //}



    //class Solution - quick sort LEETCODE -  Squares of a Sorted Array
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[] nums = { -4, -1, 0, 3, 10 };


    //            var finalSorted = SortedSquares(nums);
    //    }

    //    public static int[] SortedSquares(int[] A)
    //    {
    //        List<int> finalArray = new List<int>();

    //        foreach (var number in A) { finalArray.Add(number * number); }

    //        return QuickSort(finalArray).ToArray();
    //    }



    //    private static IEnumerable<int> QuickSort(IEnumerable<int> list)
    //    {

    //        if (list.Count() <= 1) return list;

    //        var pivot = list.First();

    //        var less = list.Skip(1).Where(i => i <= pivot);

    //        var greater = list.Skip(1).Where(i => i > pivot);

    //        return QuickSort(less).Concat(new List<int> { pivot }).Concat(QuickSort(greater));
    //    }




    //}



    //class Solution
    //{
    //    //Bubble sort solution(passed 130/132 test cases)

    //    public static int[] SortedSquares(int[] A)
    //    {
    //        int temp;
    //        List<int> finalArray = new List<int>();
    //        for (int j = 0; j < A.Length - 1; j++)
    //        {
    //            for (int i = 0; i < A.Length - 1; i++)
    //            {
    //                if ((A[i] * A[i]) > (A[i + 1] * A[i + 1]))
    //                {
    //                    temp = A[i + 1];
    //                    A[i + 1] = A[i];
    //                    A[i] = temp;
    //                }
    //            }
    //        }

    //        //var final = A.Select(x => x * x).ToArray();
    //        foreach (var number in A) { finalArray.Add(number * number); }

    //        return finalArray.ToArray();
    //    }





    //    public static void Main(string[] args)
    //    {
    //        int[] nums = { -7, -3, 2, 3, 11 };

    //        Console.WriteLine(SortedSquares(nums));
    //    }
    //}






    //Leetcode - second array problem
    //class Solution
    //{


    //    public static int FindNumbers(int[] nums)
    //    {
    //        List<int> evenNumbers = new List<int>();
    //        int totalCount = 0;

    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            int count = nums[i].ToString().Length;//count of digits in each number

    //            var isEven = count % 2 == 0 ? totalCount = totalCount + 1 : totalCount = totalCount;
    //        }

    //        return totalCount;
    //    }



    //    public static void Main(string[] args)
    //    {
    //        int[] nums = { 555, 901, 482, 1771, 2222, 2222, 2222 };

    //        Console.WriteLine(FindNumbers(nums));
    //    }

    //}









    /* LEETCODE - training arrays


    //Algorithm uses stack to count and add consecutive 1s in array
    //class Solution {

    //    public static int FindMaxConsecutiveOnes(int[] nums)
    //    {
    //        List<int> result = new List<int>();
    //        Stack container = new Stack();

    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            if (nums[i].Equals(1))
    //                container.Push(nums[i]);
    //            else
    //            {
    //                result.Add(container.Count);
    //                container.Clear();
    //            }
    //            //Account for last input value being 1
    //            if (i == nums.Count() - 1 && nums[i] == 1)
    //                result.Add(container.Count);
    //        }

    //        return result.ToArray().Max();
    //    }

    //    public static void Main(string[] args)
    //    {
    //        int[] nums = { 1, 1, 1, 0, 1, 1};

    //        Console.WriteLine(FindMaxConsecutiveOnes(nums));
    //    }








    //}


    /*LEETCODE valid parenthetis - THIS NEEDS TO BE REFINED AND LOOKED AT - USING STACKS

    Runtime: 72 ms, faster than 89.69% of C# online submissions for Valid Parentheses.
Memory Usage: 22.9 MB, less than 5.93% of C# online submissions for Valid Parentheses.
    //public class solution
    //{

    //    public static bool IsValid(string s)
    //    {
    //        Stack stringStack = new Stack();

    //        char[] myArray = s.ToCharArray();

    //        for (int j = 0; j < myArray.Length; j++)
    //        {

    //            if (myArray[j].ToString().Equals("{") || myArray[j].ToString().Equals("[") || myArray[j].ToString().Equals("("))
    //                stringStack.Push(myArray[j]);
    //            if (myArray[j].ToString().Equals("}") || myArray[j].ToString().Equals("]") || myArray[j].ToString().Equals(")"))
    //                try {

    //                    if (myArray[j].ToString().Equals(")"))
    //                        if (stringStack.Peek().ToString().Equals("("))
    //                            stringStack.Pop();
    //                        else
    //                            break;
    //                    if (myArray[j].ToString().Equals("}"))
    //                        if (stringStack.Peek().ToString().Equals("{"))
    //                            stringStack.Pop();
    //                        else
    //                            break;
    //                    if (myArray[j].ToString().Equals("]"))
    //                        if (stringStack.Peek().ToString().Equals("["))
    //                            stringStack.Pop();
    //                        else
    //                            break;
    //                }
    //                catch
    //                {
    //                    stringStack.Push("#");
    //                }

    //        }



    //        var isEmpty = stringStack.Count.Equals(0) ? true : false;

    //        return isEmpty;
    //    }

    //   public static void Main(string[] args)
    //   {
    //        IsValid("()()([])");
    //   }



    //}











    //REVERSE AN INT TAKING INTO CONSIDERATION -, OVERFLOW ETC



    /* Runtime: 68 ms, faster than 19.09% of C# online submissions for Reverse Integer.
Memory Usage: 19.8 MB, less than 5.02% of C# online submissions for Reverse Integer.*/
    //class Solution
    //{
    //    public static int Reverse(int x)
    //    {
    //        List<int> digits = new List<int>();
    //        string result;
    //        var builder = new StringBuilder();
    //        int finalInt;

    //        for (; x != 0; x /= 10)
    //        {
    //            digits.Add(x % 10);
    //        }

    //        int[] arr = digits.ToArray();

    //        string stringResult = string.Join("", arr);

    //        var isNegative = stringResult.Contains("-") ? true : false;

    //        if (isNegative)
    //        {
    //            result = Regex.Replace(stringResult, @"-", "");
    //            builder.Append("-");
    //            builder.Append(result);


    //            try
    //            {
    //                finalInt = Int32.Parse(builder.ToString());
    //            }
    //            catch
    //            {
    //                finalInt = 0;
    //            }
    //        }
    //        else
    //        {
    //            try
    //            {
    //                Int32.Parse(stringResult);
    //            }
    //            catch
    //            {
    //                stringResult = "0";
    //            }




    //            if (stringResult != "" || stringResult != "0")
    //            {
    //                finalInt = Int32.Parse(stringResult);
    //            }
    //            else
    //            {
    //                return 0;
    //            }
    //        }


    //        return finalInt;


    //    }

    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine(Reverse(123)); 
    //    }




    //TWO SUM PROBLEM - Leetcode bubble sort for two sum question



    //public static int[] TwoSum(int[] nums, int target)
    //{
    //    List<int> result = new List<int>();

    //    for (int write = 0; write < nums.Length - 1; write++)
    //    {
    //        for (int sort = 1; sort < nums.Length; sort++)
    //        {
    //            if (nums[sort] + nums[write] == target && sort != write && result.Count == 0)
    //            {
    //                result.Add(write);
    //                result.Add(sort);
    //                break;

    //            }

    //        }
    //    }

    //    return result.ToArray();

    //}


    //public static void Main(string[] args)
    //{
    //    int[] nums = new int[] { 2, 5, 5, 11 };
    //    TwoSum(nums, 10);
    //}


}



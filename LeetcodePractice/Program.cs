using System.CodeDom.Compiler;
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



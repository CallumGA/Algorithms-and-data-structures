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

namespace LeetcodePractice
{

    //Leetcode bubble sort for two sum question

    class Solution
    {

        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();

            for (int write = 0; write < nums.Length - 1; write++)
            {
                for (int sort = 1; sort < nums.Length; sort++)
                {
                    if (nums[sort] + nums[write] == target && sort != write && result.Count == 0)
                    {

                        Console.WriteLine("Found");
                        Console.WriteLine(write + ", " + sort);
                        result.Add(write);
                        result.Add(sort);
                        break;

                    }

                }
            }

            return result.ToArray();

        }


        public static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 5, 5, 11 };
            TwoSum(nums, 10);
        }


    }
}


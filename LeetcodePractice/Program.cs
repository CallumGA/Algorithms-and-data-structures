using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodePractice
{


    //public class Solution - STACK algorithm solved
    //{

    //    public static void Main(string[] args)
    //    {
    //        string[] ops = { "5", "-2", "4", "C", "D", "9", "+", "+" };
    //        Console.WriteLine(CalPoints(ops));
    //    }

    //    public static int CalPoints(string[] ops)
    //    {
    //        Stack<int> stack = new Stack<int>();

    //        foreach (var round in ops)
    //        {
    //            int n;
    //            if (int.TryParse(round, out n)) stack.Push(int.Parse(round));
    //            if (round.ToLower().Equals("c")) stack.Pop();
    //            if (round.ToLower().Equals("d")) stack.Push((stack.Peek() * 2));
    //            if (round.Equals("+"))
    //            {
    //                var top = stack.Peek();
    //                stack.Pop();
    //                var nextTop = stack.Peek();
    //                stack.Push(top);
    //                stack.Push((top + nextTop));
    //            }
    //        }

    //        return stack.Sum();
    //    }

    //}






    //    public static void Main(string[] args)
    //    {

    //        int[] flowerbed = { 0, 0, 1, 0, 0 };
    //        int n = 1;
    //        //int[] flowerbed = { 1, 0, 0, 0, 0, 1};
    //       // int n =2;
    //        Console.WriteLine(CanPlaceFlowers(flowerbed, n));

    //    }

    //    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    //    {
    //        var count = 0;

    //        for (int i = 0; i < flowerbed.Length; i++)
    //        {
    //            var interiorElement = !i.Equals(0) && !i.Equals(flowerbed.Length - 1);
    //            var firstElement = i.Equals(0) && flowerbed.Length > 1;
    //            var lastElement = i.Equals(flowerbed.Length - 1) && flowerbed.Length > 1;

    //            if (interiorElement)
    //                if ((flowerbed[i] + flowerbed[i + 1] + flowerbed[i - 1]).Equals(0)){ count = count + 1; flowerbed[i] = 1; }
    //            if (firstElement)
    //                if ((flowerbed[i] + flowerbed[i + 1]).Equals(0)){count = count + 1; flowerbed[i] = 1; }
    //            if (lastElement)
    //                if ((flowerbed[i] + flowerbed[i - 1]).Equals(0)){count = count + 1; flowerbed[i] = 1; }

    //            if (flowerbed.Length.Equals(1) && flowerbed[0].Equals(0) && n.Equals(1)) count = count + 1;
    //        }

    //        return count.Equals(n) || count > n ? true : false;
    //    }

    //}









    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {

    //        //string s = "abBAcC";
    //        string s = "abBAcC";
    //        Console.WriteLine(MakeGood(s));

    //    }

    //    public static string MakeGood(string s)
    //    {

    //        Stack<char> letterStack = new Stack<char>();
    //        Stack<int> indexStack = new Stack<int>();
    //        var characterList = s.ToList();


    //            for (int i = 0; i < characterList.Count; i++)
    //            {
    //                if (char.IsUpper(characterList[i]))
    //                {
    //                    if (!letterStack.Count.Equals(0))
    //                    {
    //                        if (char.IsLower(letterStack.Peek()) 
    //                        && characterList[i].ToString().ToLower().Equals(letterStack.Peek().ToString().ToLower()))
    //                        {
    //                            characterList.RemoveAt(i);
    //                            characterList.RemoveAt(indexStack.Peek());
    //                            i = 0;
    //                        }
    //                    }
    //                    if (i < characterList.Count)
    //                        letterStack.Push(characterList[i]);
    //                    indexStack.Push(i);
    //                }
    //                else
    //                {
    //                    if (!letterStack.Count.Equals(0))
    //                    {
    //                        if (char.IsUpper(letterStack.Peek())
    //                        && characterList[i].ToString().ToLower().Equals(letterStack.Peek().ToString().ToLower()))
    //                        {
    //                            characterList.RemoveAt(i);
    //                            characterList.RemoveAt(indexStack.Peek());
    //                            i = 0;
    //                    }
    //                }

    //                    if (i < characterList.Count)
    //                        letterStack.Push(characterList[i]);
    //                    indexStack.Push(i);
    //                }
    //            }

    //            if (characterList.Count.Equals(2))
    //            {
    //                if (characterList[0].ToString().ToLower().Equals(characterList[1].ToString().ToLower()))
    //                {
    //                    characterList.RemoveAt(0);
    //                    characterList.RemoveAt(0);
    //                }
    //            }

    //        return string.Join("", characterList);
    //    }

    //}










    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {

    //        string order = "hlabcdefgijkmnopqrstuvwxyz";
    //        //string[] words = { "helloccc", "leetcode", "shit" };
    //        string[] words = { "app", "apple" };

    //        Console.WriteLine(IsAlienSorted(words, order));
    //    }

    //    public static bool IsAlienSorted(string[] words, string order)
    //    {
    //        Dictionary<int, string> dict = new Dictionary<int, string>();
    //        dict.Add(-1, null);
    //        var orderArray = order.ToCharArray();
    //        bool finalAnswer = default;

    //        for (int i = 0; i < orderArray.Length; i++)
    //            dict.Add(i, orderArray[i].ToString());


    //        List<string> letterList = new List<string>(words);
    //        var longestWord = letterList.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
    //        Stack<int> stack = new Stack<int>();

    //        //It is 2 words compared then the next 2 compared

    //        for (int i = 0; i < longestWord.Length; i++)
    //        {
    //            var letters = letterList.Select(s => i! >= s.Length ? null : s.Substring(i, 1)).ToList();

    //            var letterOne = dict.FirstOrDefault(x => x.Value == letters[0]).Key;
    //            var letterTwo = dict.FirstOrDefault(x => x.Value == letters[1]).Key;

    //            if (letterOne < letterTwo)
    //            {
    //                finalAnswer = true;
    //                break;
    //            }
    //            else if(letterOne > letterTwo)
    //            {
    //                finalAnswer = false;
    //                break;
    //            }
    //        }



    //        return finalAnswer;
    //    }
    //}











    //public class Solution
    //{

    //    public static void Main(string[] args)
    //    {

    //        int[] arr1 = { 2, 21, 43, 38, 0, 42, 33, 7, 24, 13, 12, 27, 12, 24, 5, 23, 29, 48, 30, 31 };
    //        int[] arr2 = { 2, 42, 38, 0, 43, 21};

    //        RelativeSortArray(arr1, arr2);
    //    }

    //    public static int[] RelativeSortArray(int[] arr1, int[] arr2)
    //    {
    //        List<int> finalList = new List<int>();

    //        for (int i = 0; i < arr2.Length; i++)
    //        {
    //            if (arr1.Contains(arr2[i]))
    //                foreach (var item in arr1.Where(p => p.Equals(arr2[i])).ToList())
    //                    finalList.Add(item);
    //        }

    //        finalList.AddRange(arr1.Where(v => !arr2.Contains(v)).OrderBy(x=>x));

    //        return finalList.ToArray();
    //    }
    //}






    //public class Solution //- TWO POINTERS as well as QUEUE - strstr leetcode
    //{
    //    public static void Main(string[] args)
    //    {
    //        string haystack = "lhello";
    //        string needle = "ll";

    //        Console.WriteLine(StrStr(haystack, needle));
    //    }

    //    public static int StrStr(string haystack, string needle)
    //    {
    //        if (needle.Length == 0) return 0;

    //        int index = 0;
    //        int counter = 0;
    //        Queue<int> indexList = new Queue<int>();

    //        for (int i = 0; i < haystack.Length; i++)
    //        {
    //            if (haystack[i].Equals(needle[index]))
    //            {
    //                indexList.Enqueue(i);
    //                if (index < needle.Length - 1)
    //                    index = index + 1;
    //                counter = counter + 1;

    //                if (counter.Equals(needle.Length))
    //                    return indexList.Peek() - (needle.Length - 1);

    //                else if (!indexList.Count().Equals(0))
    //                    indexList.Dequeue();
    //            }
    //            else
    //            {
    //                i -= index;
    //                counter = 0;
    //                index = 0;
    //            }
    //        }

    //        return -1;
    //    }
    //}






    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        //int[] nums = { 1,2,3,4 };
    //        //int[] nums = { -710,-107,-851,657,-14,-859,278,-182,-749,718,-640,127,-930,-462,694,969,143,309,904,-651,160,451,-159,-316,844,-60,611,-169,-73,721,-902,338,-20,-890,-819,-644,107,404,150,-219,459,-324,-385,-118,-307,993,202,-147,62,-94,-976,-329,689,870,532,-686,371,-850,-186,87,878,989,-822,-350,-948,-412,161,-88,-509,836,-207,-60,771,516,-287,-366,-512,509,904,-459,683,-563,-766,-837,-333,93,893,303,908,532,-206,990,280,826,-13,115,-732,525,-939,-787};
    //        int[] nums = { -1,-2,-3 };

    //        MaximumProduct(nums);
    //    }


    //    public static int MaximumProduct(int[] nums)
    //    {
    //        List<int> positive = new List<int>(), negative = new List<int>();
    //        int positiveOnly, ifHasNegatives = 0;
    //        nums.ToList().ForEach(j => { if (j < 0) negative.Add(j); else positive.Add(j); });

    //        positiveOnly = nums.Cast<int>().OrderByDescending(i => i).Take(3).Aggregate(1, (x, y) => x * y);

    //        var twoSmallest = nums.Cast<int>().OrderBy(i => i).Take(2).ToList();
    //        twoSmallest.Add(nums.Max());
    //        ifHasNegatives = twoSmallest.Aggregate(1, (x, y) => x * y);

    //        var finalResult = positiveOnly > ifHasNegatives ? positiveOnly : ifHasNegatives;
    //        if (!positive.Any()) finalResult = negative.Aggregate(1, (x, y) => x * y);

    //        return finalResult;
    //    }

    //}








    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

    //        Console.WriteLine(ContainsDuplicate(nums));
    //    }

    //    public static bool ContainsDuplicate(int[] nums)
    //    {
    //        HashSet<int> hash = new HashSet<int>(nums);

    //        return !nums.Length.Equals(hash.Count) ? true : false;
    //    }
    //}




    //TWO POINTER SOLUTION - WORKS BECAUSE ARRAY IS SORTED
    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[] numbers = {0,0,3,4};

    //        TwoSum(numbers, 0);

    //        //int[] numbers = { 2, 7, 11, 15 };

    //        //TwoSum(numbers, 9);
    //    }

    //    public static int[] TwoSum(int[] numbers, int target)
    //    {
    //        List<int> answer = new List<int>();
    //        int i = 0;
    //        int j = numbers.Length - 1;
    //        while (i<j)
    //        {
    //            if ((numbers[i] + numbers[j]).Equals(target) && !i.Equals(j))
    //            {
    //                answer.Add(i + 1);
    //                answer.Add(j + 1);
    //                break;
    //            }
    //            else if (numbers[i] + numbers[j] < target)
    //                i++;
    //            else
    //                j--;

    //        }            

    //        return answer.ToArray();
    //    }
    //}







    //public class Solution
    //{

    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine(Maximum69Number(9669));
    //    }

    //    public static int Maximum69Number(int num)
    //    {
    //        List<int> finalList = new List<int>() { num }; 
    //        char[] sequence = num.ToString().ToCharArray();

    //        for (int i = 0; i < sequence.Length; i++)
    //        {
    //            int temp = sequence[i];
    //            if (sequence[i].Equals('6')) sequence[i] = '9';
    //            else sequence[i] = '6';

    //            finalList.Add(int.Parse(sequence));
    //            sequence[i] = (char)temp;
    //        }

    //         return finalList.Max();
    //    }

    //}







    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {

    //        string s = "lmhfaobhjlterbwdpgheqezaivguornmffbebwyjszankhkrtjhkrchbgnsfjbeafaztgkbavarfwhnqmgemsgqxkdbsqcgwzjjlofsbmathriawzuzqqqzcfanexaowbxkwndnanhqwyxuorqckeuvbuqtnwupfnfpkkvlmczbpeuucmdodkwgolzfekjbcaqjslfavrsqmvicfwepnzzmoncwigwcvgwwavoezkbmmwrybegjfgqhukeooekuhqgfjgebyrwmmbkzeovawwgvcwgiwcnomzznpewfcivmqsrvaflsjqacbjkefzlogwkdodmcuuepbzcmlvkkpfnfpuwntqubvuekcqrouxywqhnandnwkxbwoaxenafczqqqzuzwairhtambsfoljjzwgcqsbdkxqgsmegmqnhwfravabkgtzafaebjfsngbhcrkhjtrkhknazsjywbebffmnrougviazeqehgpdwbretljhboafhm";
    //        //string s = "abc";
    //        Console.WriteLine(ValidPalindrome(s));
    //    }

    //    private static bool ValidPalindrome(string s)
    //    {

    //        var normal = s.Replace(" ", "").ToCharArray();
    //        var reversed = s.Replace(" ", "").ToCharArray().Reverse();

    //        var isPalindrome = string.Join(",", normal.Select(p => p)).Equals(string.Join(",", reversed.Select(p => p))) ? true : false;

    //        if (!isPalindrome)
    //        {            
    //            for (int i = 0; i < normal.Length; i++)
    //            {
    //                List<char> normalList = normal.ToList();
    //                normalList.RemoveAt(i);

    //                var reversedArray = normalList;

    //                var one = reversedArray.ToArray();
    //                var two = reversedArray.ToArray();
    //                Array.Reverse(two);



    //                if (string.Join(",", one).Equals(string.Join(",", two)))
    //                    isPalindrome = true;
    //            }

    //        }

    //        return isPalindrome;
    //    }
    //}









    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {

    //        //string s = "A man, a plan, a canal: Panama";
    //        string s = "A man, a plan, a canal: Panama";

    //        Console.WriteLine(IsPalindrome(s));
    //    }

    //    private static bool IsPalindrome(string s)
    //    {
    //        var normal = Array.FindAll<char>(s.Replace(" ", "").ToLower().ToCharArray(), (c => (char.IsLetterOrDigit(c)
    //                                  || char.IsWhiteSpace(c))));
    //        var reversed = Array.FindAll<char>(s.Replace(" ", "").ToLower().ToCharArray(), (c => (char.IsLetterOrDigit(c)
    //                                         || char.IsWhiteSpace(c)))).Reverse().ToList().ToArray();

    //        return string.Join(",", normal.Select(p => p)).Equals(string.Join(",", reversed.Select(p => p))) ? true : false;
    //    }
    //}




    //public class Solution
    //{

    //    public static void Main(string[] args)
    //    {

    //        int[] nums = { 1, 2 };
    //        //int[] nums = { -1, -100, 3, 99 };
    //       // int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

    //        int k = 3;
    //        Rotate(nums, k);
    //    }

    //    public static void Rotate(int[] nums, int k)
    //    {
    //        k = k % nums.Length;//Return the remainder of k / nums length
    //        int temp, previous;
    //        for (int i = 0; i < k; i++)
    //        {
    //            previous = nums[nums.Length - 1];
    //            for (int j = 0; j < nums.Length; j++)
    //            {
    //                temp = nums[j];
    //                nums[j] = previous;
    //                previous = temp;
    //            }
    //        }

    //    }
    //}



    //public class Solution 
    //{

    //    public static void Main(string[] args)
    //    {

    //        string A = "abab";
    //        string B = "abab";
    //        Console.WriteLine(BuddyStrings(A, B));
    //    }


    //    public static bool BuddyStrings(string A, string B)
    //    {
    //        bool result = false;

    //        var aArray = A.ToCharArray();
    //        var bArray = B.ToCharArray();

    //        bool allEqualA = aArray.GroupBy(o => o).Count() == 1;
    //        bool allEqualB = bArray.GroupBy(o => o).Count() == 1;


    //        for (int i = 0; i < aArray.Length; i++)
    //        {
    //            for (int j = 0; j < aArray.Length; j++)
    //            {
    //                var tempA = aArray[i];
    //                var tempB = aArray[j];
    //                aArray[i] = tempB;
    //                aArray[j] = tempA;
    //                string a = new string(aArray);
    //                string b = new string(bArray);

    //                if (a.Equals(b))
    //                    result = true;
    //                else
    //                {
    //                    aArray[i] = tempA;
    //                    aArray[j] = tempB;
    //                }

    //            }

    //        }

    //        if (allEqualA == true && allEqualB == true)
    //            result = true;
    //        if (A.Equals(B) && !allEqualA == true && !allEqualB == true && aArray.Length < 3)
    //            result = false;

    //        return result;
    //    }

    //}






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



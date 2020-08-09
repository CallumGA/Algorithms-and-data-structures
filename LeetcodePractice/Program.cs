using System;
using System.Collections.Generic;

namespace LeetcodePractice
{

    class Result
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
                if ((grades[i] + 4) / 5 * 5 - grades[i] < 3 && grades[i] >= 38)
                    grades[i] = (grades[i] + 4) / 5 * 5;
            return grades;
        }
    }


    class Program
    {

        public static void Main(string[] args)
        {


            List<int> grades = new List<int>();
            grades.Add(73);
            grades.Add(67);
            grades.Add(38);
            grades.Add(33);


            List<int> result = Result.gradingStudents(grades);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}


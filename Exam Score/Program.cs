using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
namespace ExamScore
{

    class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     * List<int>
     */

    public static int MaxSubjectsNumber(List<int> answered, List<int> needed,int q)
    {
            List<int> req = new List<int>();
            int count = 0;
            for (int i = 0; i < answered.Count; i++)
            {
                if (needed[i] > answered[i])
                {
                    int rem = needed[i] - answered[i];
                    if (q >= rem)
                    {
                        q = q - rem;
                        count++;
                    }
                }
                
            }

            return count;
    }

}


    class MainClass
    {
        public static void Main(string[] args)
        {
          //  TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> answered = new List<int>();
            List<int> needed = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                answered.Add(gradesItem);
            }
            int q = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 0; i < q; i++)
            {
                int newGradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                needed.Add(newGradesItem);
            }
            int q1 = Convert.ToInt32(Console.ReadLine().Trim());
            int result = Result.MaxSubjectsNumber(answered,needed,q1);
            Console.WriteLine("Answer : {0}",result);
            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}

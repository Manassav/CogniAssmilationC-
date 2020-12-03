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

class Solution {

    // Complete the minimumBribes function below.
    static int CheckForBribes(List<int> orignal,int[] q,int len)
    {
        List<int> check = new List<int>();
        int elem;
        for(int i =0;i<len;i++)
        {
            elem = q[i]-orignal[i];
            check.Add(elem);
        }
        return check.Max();
    }
    static void minimumBribes(int[] q) {
        int len = q.Length;
         List<int> orignalSequence = new List<int>();
         for(int i = 1;i<=len;i++)
         {
             orignalSequence.Add(i);
         }
         int noOfBribes = CheckForBribes(orignalSequence,q,len);
        /* foreach(int items in orignalSequence)
         {
             Console.Write(" {0}",items);
         }
         Console.Write("{0}",noOfBribes);*/
         if(noOfBribes<=2){
             int count = 0;
             for(int i = 0;i<len-1;i++)
             {
                 for(int j =0;j<len-1-i;j++)
                 {
                     if (q[j] > q[j + 1]) 
                      { 
                         // swap temp and arr[i] 
                         int temp = q[j]; 
                         q[j] = q[j + 1]; 
                         q[j + 1] = temp; 
                         count++;
                      } 
                 }
                 
             }
             Console.WriteLine("{0}",count);
            // break;
         }
         else{
             Console.WriteLine("Too chaotic");
             //break;
         }
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}

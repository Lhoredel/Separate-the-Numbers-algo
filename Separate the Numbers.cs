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

class Result
{

    /*
     * Complete the 'separateNumbers' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void separateNumbers(string s)
    {
        for (int len = 1; len <= s.Length / 2; len++)
        {
        long firstNumber = long.Parse(s.Substring(0, len));
        long current = firstNumber;
        string builtString = current.ToString();
        
         while (builtString.Length < s.Length)
        {
            current++;
            builtString += current.ToString();
        }
    
        if (builtString == s)
        {
            Console.WriteLine($"YES {firstNumber}");
            return;
        }
    }
    
    Console.WriteLine("NO");
}

}
class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            Result.separateNumbers(s);
        }
    }
}

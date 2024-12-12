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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
    string period = s.Substring(s.Length - 2);       
    string[] timeParts = s.Substring(0, s.Length - 2).Split(':');

    int hour = int.Parse(timeParts[0]);
    int minute = int.Parse(timeParts[1]);
    int second = int.Parse(timeParts[2]);

    if (period == "AM" && hour == 12)
    {
        hour = 0; 
    }
    else if (period == "PM" && hour != 12)
    {
        hour += 12; 
    }
    return $"{hour:D2}:{minute:D2}:{second:D2}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = Result.timeConversion(s);
        Console.WriteLine(result);
    }
}
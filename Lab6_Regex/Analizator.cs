using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab6_Regex
{
    static public class Analizator
    {
        static Regex letter;
        static Regex figure;
        static Regex identify;
        static Regex figereEnum;
        static Regex mark;
        static Regex regex;
        static public bool IsValid(string str)
        {
            letter = new Regex("[a-z]");
            figure = new Regex("[0-9]");
            identify = new Regex($"{letter}" + "(" + $"{letter}|{figure}" + ")*");
            figereEnum = new Regex("[0-9]{1,4}");
            mark = new Regex($"{identify}|{figereEnum}");
            regex = new Regex($"^LABEL ((({identify})|({figereEnum}))(, (({identify})|({figereEnum})))*)$");
            Console.WriteLine(letter);
            Console.WriteLine(figure);
            Console.WriteLine(identify);
            Console.WriteLine(figereEnum);
            Console.WriteLine(mark);
            Console.WriteLine(regex);
            return regex.IsMatch(str);
        }
    }
}

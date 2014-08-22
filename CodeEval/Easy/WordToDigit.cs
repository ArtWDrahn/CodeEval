using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        {
            while (!reader.EndOfStream)
            {
                var readLine = reader.ReadLine();
                if (readLine == null)
                {
                    continue;
                }

                var myInts = readLine.Split(';');
                var sb = new StringBuilder();

                foreach (var num in myInts)
                {
                    sb.Append(GetNumber(num));
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }

    private static string GetNumber(string number)
    {
        switch (number)
        {
            case "zero":
                return "0";
            case "one":
                return "1";
            case "two":
                return "2";
            case "three":
                return "3";
            case "four":
                return "4";
            case "five":
                return "5";
            case "six":
                return "6";
            case "seven":
                return "7";
            case "eight":
                return "8";
            case "nine":
                return "9";
            default:
                return null;
        }
    }
}
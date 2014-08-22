using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var sb = new StringBuilder();

        for (var i = 1; i <= 12; i++)
        {
            var temp = new StringBuilder();

            for (var j = 1; j <= 12; j++)
            {
                temp.Append(string.Format("  {0}  ", i * j));
            }
            sb.Append(temp.ToString().Trim());
            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString().Trim());

        //Console.ReadLine();
    }
}
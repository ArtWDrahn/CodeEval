using System;
using System.IO;
using System.Linq;
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
                var sb = new StringBuilder();
                if (readLine != null)
                {
                    var myInts = Array.ConvertAll(readLine.Split(','), int.Parse);
                    sb.Append(string.Join(",", myInts.Distinct()));
                }

                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}
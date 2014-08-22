// Currently fails validation, likely a problem with the white space.

using System;
using System.IO;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
#if !DEBUG
        using (StreamReader reader = File.OpenText(args[0]))
        {
            while (!reader.EndOfStream)
            {
                var readLine = reader.ReadLine();
#endif
#if DEBUG
        const string readLine = "86.277 60.447 39.457 46.844 -35.645 -24.570 50.077 -65.230 90.080 28.939 68.246 -3.544 -64.470 86.527 13.771";
#endif
                var sb = new StringBuilder();
                if (readLine != null)
                {
                    var myInts = Array.ConvertAll(readLine.Split(' '), double.Parse);
                    Array.Sort(myInts);
                    sb.Append(string.Join(",", myInts));
                }

                Console.WriteLine(sb.ToString().Trim());
        Console.ReadKey();
#if !DEBUG
            }
        }
#endif
    }
}
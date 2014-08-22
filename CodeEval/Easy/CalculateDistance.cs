using System;
using System.Globalization;
using System.IO;
using System.Linq;
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
        const string readLine = "(25, 4) (1, -6)";
#endif
                if (readLine != null)
                {
                    var line = Array.ConvertAll(readLine.Replace("(", string.Empty).Replace(")", string.Empty).Replace(",", string.Empty).Split(' '), double.Parse);

                    Console.WriteLine(
                        Math.Truncate(Math.Sqrt(Math.Pow(line[0] - line[2], 2) + Math.Pow(line[1] - line[3], 2)))
                        .ToString(CultureInfo.InvariantCulture)
                            .Trim());
                }
#if !DEBUG
            }
        }
#endif
    }
}
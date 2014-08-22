using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                var readLine = reader.ReadLine();
                if (readLine != null)
                {
                    Console.WriteLine(readLine.ToLower());
                }
            }
    }
}
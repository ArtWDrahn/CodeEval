using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                var myInts = Array.ConvertAll(line.Split(','), int.Parse);
                var temp = 0;

                while (temp < myInts[0])
                {
                    temp = temp + myInts[1];
                }

                Console.WriteLine(temp);
            }
    }
}
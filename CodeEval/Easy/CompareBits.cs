using System;
using System.Collections;
using System.IO;

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
                var myInts = Array.ConvertAll(readLine.Split(','), int.Parse);
                var b = new BitArray(new[] { myInts[0] });

                Console.WriteLine(CheckBits(b, myInts[1] - 1, myInts[2] - 1).ToString().ToLower());
            }
        }
    }

    private static bool CheckBits(BitArray bitArray, int bit1, int bit2)
    {
        return bitArray[bit1] == bitArray[bit2];
    }
}
using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        FileInfo file = new FileInfo(args[0]);
        Console.WriteLine(file.Length);
    }
}
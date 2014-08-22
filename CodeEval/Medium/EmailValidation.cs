using System;
using System.IO;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        {
            while (!reader.EndOfStream)
            {
                var readLine = reader.ReadLine();
                if (readLine != null)
                {
                    Console.WriteLine(IsValid(readLine).ToString().ToLower().Trim());
                }
            }
        }
    }

    public static bool IsValid(string emailaddress)
    {
        try
        {
            var m = new MailAddress(emailaddress);

            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}
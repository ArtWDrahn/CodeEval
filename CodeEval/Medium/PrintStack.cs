using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

#if !DEBUG
        using (StreamReader reader = File.OpenText(args[0]))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                {
                    continue;
                }
#endif
#if DEBUG
                //var line = "1 3 5 6";
        var line = "98 -7 -44 -78 -46 34 53 44 -26 -62 31 -55 75 80 -19 59 -59 47 92 -71 -16 -46 -47 -87";
#endif
                var stack = new Stack<string>(line.Split(' ').ToArray());
                var sb = new StringBuilder();
                var count = stack.Count + 1;

                for (var i = 1; i < count; i++)
                {
                    if (i % 2 != 0)
                    {
                        sb.Append(string.Format("{0} ", stack.Pop()));
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

                Console.WriteLine(sb.ToString().Trim());
#if DEBUG
        Console.ReadKey();
#endif
    }
        }
#if !DEBUG
    }
}
#endif
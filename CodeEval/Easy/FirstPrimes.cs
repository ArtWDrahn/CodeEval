using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var num = 7919;

        var top = Math.Floor(2.52 * Math.Sqrt(num) / Math.Log(num));

        var number = Enumerable.Range(0, Convert.ToInt32(top)).Aggregate(
            Enumerable.Range(2, num - 1).ToList(),
            (result, index) =>
            {
                var bp = result[index];
                var sqr = bp * bp;
                result.RemoveAll(i => i >= sqr && i % bp == 0);
                return result;
            });
        Console.WriteLine(number.Sum());
    }
}
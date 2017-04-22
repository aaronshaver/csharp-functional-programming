using System.Linq;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = MultiplicationFormatter.Format(Enumerable.Range(1, 10).ToList());
            foreach (var item in list)
            {
                WriteLine(item);
            }
            ReadLine();
        }
    }
}

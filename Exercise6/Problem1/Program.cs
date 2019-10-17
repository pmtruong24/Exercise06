using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("money bank");
            int money = int.Parse(Console.ReadLine());
            int c, d;
            Console.WriteLine("money with");
            int with = int.Parse(Console.ReadLine());
            c = money - with;
            Console.WriteLine("Balance " + money + "-" + with + "=" + c);
            Console.WriteLine("money bank " + c);
            Console.WriteLine("money Depo ");
            int Depo = int.Parse(Console.ReadLine());
            d = c + Depo;
            Console.WriteLine("Balance " + c + "+" + Depo + "=" + d);
        }

    }
}

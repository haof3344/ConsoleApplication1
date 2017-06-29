using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = GetMoney(120000, (decimal)0.041, 365*30);
            Console.WriteLine(result);
            Console.Read();
        }

        static decimal GetMoney(decimal start,decimal rate,int days)
        {
            for(var i = 0; i < days; i++)
            {
                start += start * rate / 365;
            }
            return start;
        }
    }
}

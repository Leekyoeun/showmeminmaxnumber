using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int first = 0;
            int second=0;
            int thrid=0;
            int four=0;
            int five=0;
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("숫자를 입력하세요");
                Console.WriteLine();
            }
            Console.WriteLine(Math.Max(first, second, thrid, four, five));
            Console.WriteLine(Math.Min(first, second, thrid, four, five));

        }
    }
}

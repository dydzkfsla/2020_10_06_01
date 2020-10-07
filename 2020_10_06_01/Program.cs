using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_06_01
{
    class Program
    {
        static void Main(string[] args)
        {
//#if TRACE
//            string name = Console.ReadLine();
//            string pwd = Console.ReadLine();
//#endif
#if DEBUG
            string name = "홍길동";
            string pwd = "1234";
#endif
            Trace.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(pwd);
            Console.ReadLine();
        }
    }
}

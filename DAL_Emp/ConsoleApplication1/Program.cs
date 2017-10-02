using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class exp
    {
        int _a;
        public int a
        {
            get { return _a; }
            set { _a = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            exp e = new exp();
            Console.WriteLine(e.a);
            e.a = 1;
            Console.WriteLine(e.a);
        }
    }
}

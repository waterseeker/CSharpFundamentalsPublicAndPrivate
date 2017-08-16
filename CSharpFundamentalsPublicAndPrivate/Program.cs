using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsPublicAndPrivate
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.ReadLine();
        }

        class Car
        {

            //public methods are available everywhere in the code
            public void DoSomething()
            {
                Console.WriteLine(helperMethod());
            }

            //private methods are only available to members of the same class
            private string helperMethod()
            {
                return "Hello world!";
            }
        }
    }
}

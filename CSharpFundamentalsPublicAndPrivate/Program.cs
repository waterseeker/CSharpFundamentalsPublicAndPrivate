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

            Car car = new Car();

            //we can't call helperMethod from outside of the class because the method is private
            //car.helperMethod();


            car.DoSomething();

            Console.ReadLine();
        }

        class Car
        {

            //public methods are available everywhere in the code
            public void DoSomething()  //when something is public, it should use PascalCase
            {
                Console.WriteLine(helperMethod());
            }

            //private methods are only available to members of the same class
            private string helperMethod() //things that are private shoudl use camelCase
            {
                return "Hello world!";
            }
        }
    }
}

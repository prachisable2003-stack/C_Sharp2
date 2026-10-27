using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Console.WriteLine(human.Leg());
            Console.WriteLine(human.Hand());
            //Console.WriteLine(human.Leg());

        }
    }
}

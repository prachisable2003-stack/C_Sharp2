using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance.Example
{
        public class Brain:Human
        {
        public string BrainFunction()
        {
            return "I can think";
        }
    }
    public class Human
    {
        public string Leg()
        {
            return "I have a two legs";
        }
        public string Hand()
        {
            return "I have two Hands";
        }
       
    }
}

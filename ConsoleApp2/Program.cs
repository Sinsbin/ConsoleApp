using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    internal class Program : TEST {

        static void Main(string[] args) {
         Stack<char> v = new Stack<char>();
            v.Push('{');
            Console.WriteLine('{'!=v.Pop());
            Console.WriteLine( v.Pop());

            Console.ReadLine();
          
        }
    }
}

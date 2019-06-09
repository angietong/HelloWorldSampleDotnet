using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldSampleDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Utlitity.WelcomeMessage();
            int sum = Utlitity.Add(2,3);
            Console.WriteLine("The Addition of Two Numbers Result:" + sum);
            Console.ReadLine();
        }
    }
}

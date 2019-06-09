using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldSampleDotnet
{
    public static class Utlitity
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Hello World for Jenkins CI");
            //Console.ReadLine();
        }
        public static int Add(int x, int y)
        {
            return (x + y);
        }
    }
}

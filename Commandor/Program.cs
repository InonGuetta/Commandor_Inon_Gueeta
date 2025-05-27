using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando c1 = new Commando("inon","mmm","not");
            Commando c2 = new Commando("a","b","c");
            //show01.Properties();



            c1.SayName("COLONEL");
            
            c1.CodeName = "lll";
            Console.WriteLine(c1.CodeName);

        }
    }
}

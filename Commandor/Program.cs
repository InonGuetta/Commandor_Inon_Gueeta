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
          
            Commando c1 = new Commando("aaa","bbb","ccc");
            SeaCommando c2 = new SeaCommando("david","dodi","lll");
            AirCommando c3 = new AirCommando("inon","llo","singal");
            c2.print();
            c3.print();
            Commando[] arr_solder = { c1,c2,c3};

            
            foreach (Commando item in arr_solder)
            {
                item.Attack();
            }

        }
    }
}

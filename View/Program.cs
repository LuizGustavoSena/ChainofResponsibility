using System;
using ChainofResponsibility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Program
    {
        static void Main()
        {
            new ClientChainofRespons().Main();
            Console.ReadKey();
        }
    }
}

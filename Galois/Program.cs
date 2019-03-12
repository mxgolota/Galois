using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galois
{
    class Program
    {
        static void Main(string[] args)
        {
            Board a = new Board();
            foreach (var item in a.tiles)
                Console.WriteLine(item.ToString());
            Console.Read();
        }
    }
}

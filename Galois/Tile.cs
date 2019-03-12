using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galois
{
    class Tile
    {
        int number { get; set; }
        int file { get; set; }
        int rank { get; set; }
        Piece piece { get; set; }

        public Tile(int number)
        {
            this.number = number;
            this.file = number % 16;
            this.rank = number / 16;
        }

        public override string ToString()
        {
            string name;
            switch (file)
            {
                case 0: name = "A"; break;
                case 1: name = "B"; break;
                case 2: name = "C"; break;
                case 3: name = "D"; break;
                case 4: name = "E"; break;
                case 5: name = "F"; break;
                case 6: name = "G"; break;
                case 7: name = "H"; break;
                default: name = "X";break;
            }
            return name + (rank+1).ToString();
        }

    }
}

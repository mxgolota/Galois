using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galois
{
    class Board
    {
        public Tile[] tiles;

        public Board()
        {
            tiles = new Tile[128];
            for (int i =0; i < 128; i++)
            {
                tiles[i] = new Tile(i);
            }
        }
    }
}

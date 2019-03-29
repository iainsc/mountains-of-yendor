using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mountains_of_yendor.TileEngine
{
    public struct Tile
    {
        public int tileIndex;
        public int tileset;

        //public int TileIndex { get { return tileIndex; } private set { tileIndex = value; } }

        //public int Tileset { get { return tileset; } private set { tileset = value; } }

        public Tile(int tileIndex, int tileset) { this.tileIndex = tileIndex; this.tileset = tileset; }

    }
}

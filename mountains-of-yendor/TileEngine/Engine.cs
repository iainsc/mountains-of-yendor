using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace mountains_of_yendor.TileEngine
{
    class Engine
    {
        static int tileWidth;
        static int tileHeight;

        public static int TileWidth { get { return tileWidth; } }
        public static int TileHeight { get { return tileHeight; } }

        public Engine(int tileWidth, int tileHeight)
        {
            Engine.tileWidth = tileWidth;
            Engine.tileHeight = tileHeight;
        }

        public static Point VectorToCell(Vector2 position) { return new Point((int)position.X / tileWidth, (int)position.Y / tileHeight); }


    }
}

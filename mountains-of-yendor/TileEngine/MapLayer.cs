﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mountains_of_yendor.TileEngine
{
    public class MapLayer
    {
        Tile[,] map;

        public int Width { get { return map.GetLength(1); } }

        public int Height { get { return map.GetLength(0); } }

        public MapLayer(Tile[,] map)
        {
            this.map = (Tile[,])map.Clone();
        }

        public MapLayer(int width, int height)
        {
            map = new Tile[height, width]; for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    map[y, x] = new Tile(0, 0);
                }
            }
        }

        public Tile GetTile(int x, int y) { return map[y, x]; }

        public void SetTile(int x, int y, Tile tile) { map[y, x] = tile; }

        public void SetTile(int x, int y, int tileIndex, int tileset) { map[y, x] = new Tile(tileIndex, tileset); }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mountains_of_yendor.TileEngine
{
    public class TileMap
    {
        List<Tileset> tilesets;
        List<MapLayer> mapLayers;

        public TileMap(List<Tileset> tilesets, List<MapLayer> layers)
        {
            this.tilesets = tilesets;
            this.mapLayers = layers;
        }

        public TileMap(Tileset tileset, MapLayer layer)
        {
            tilesets = new List<Tileset>();
            tilesets.Add(tileset);
            mapLayers = new List<MapLayer>();
            mapLayers.Add(layer);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle destination = new Rectangle(0, 0, Engine.TileWidth, Engine.TileHeight);
            Tile tile;
            
            foreach (MapLayer layer in mapLayers)
            {
                for (int y = 0; y < layer.Height; y++)
                {
                    destination.Y = y * Engine.TileHeight;

                    for (int x = 0; x < layer.Width; x++)
                    {
                        tile = layer.GetTile(x, y);
                        destination.X = x * Engine.TileWidth;

                        spriteBatch.Draw(
                            tilesets[tile.tileset].Texture,
                            destination,
                            tilesets[tile.tileset].SourceRectangles[tile.tileIndex],
                            Color.White);
                    }
                }
            }
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using mountains_of_yendor.XLib;

namespace mountains_of_yendor.GameScreens
{
    public class TitleScreen : BaseGameState
    {
        Texture2D backgroundImage;

        public TitleScreen(Game game, GameStateManager manager)
            :base(game, manager)
        {
        }

        protected override void LoadContent()
        {
            ContentManager Content = GameRef.Content;

            backgroundImage = Content.Load<Texture2D>("Backgrounds/titlescreen");

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            

            base.Draw(gameTime);

            GameRef.SpriteBatch.Draw(
                backgroundImage,
                GameRef.ScreenRectangle,
                Color.White);

        }
    }
}

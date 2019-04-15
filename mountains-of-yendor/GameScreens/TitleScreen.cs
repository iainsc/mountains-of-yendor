using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using mountains_of_yendor.XLib;
using mountains_of_yendor.XLib.Controls;

namespace mountains_of_yendor.GameScreens
{
    public class TitleScreen : BaseGameState
    {
        Texture2D backgroundImage;
        LinkLabel startLabel;

        public TitleScreen(Game game, GameStateManager manager)
            :base(game, manager)
        {
        }

        protected override void LoadContent()
        {
            ContentManager Content = GameRef.Content;

            backgroundImage = Content.Load<Texture2D>("Backgrounds/titlescreen");

            base.LoadContent();

            startLabel = new LinkLabel();
            startLabel.Position = new Vector2(350, 600);
            startLabel.Text = "Press ENTER to begin";
            startLabel.Color = Color.White;
            startLabel.TabStop = true;
            startLabel.Selected += new EventHandler(startLabel_Selected);

            ControlManager.Add(startLabel);
        }

        public override void Update(GameTime gameTime)
        {
            ControlManager.Update(gameTime, PlayerIndex.One);

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {

            base.Draw(gameTime);

            GameRef.SpriteBatch.Draw(
                backgroundImage,
                GameRef.ScreenRectangle,
                Color.White);

            ControlManager.Draw(GameRef.SpriteBatch);

        }

        private void startLabel_Selected(object sender, EventArgs e)
        {
            StateManager.PushState(GameRef.StartMenuScreen);
        }
    }
}

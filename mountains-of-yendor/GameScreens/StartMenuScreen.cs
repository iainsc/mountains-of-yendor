using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using mountains_of_yendor.XLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mountains_of_yendor.GameScreens
{
    public class StartMenuScreen : BaseGameState
    {
        public StartMenuScreen(Game game, GameStateManager manager)
            :base(game, manager)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            if (InputHandler.KeyReleased(Keys.Escape))
                Game.Exit();

            base.Draw(gameTime);
        }
    }
}

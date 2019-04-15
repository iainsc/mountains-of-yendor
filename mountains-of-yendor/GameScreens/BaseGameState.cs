﻿using System;
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
    public abstract partial class BaseGameState : GameState
    {

        protected GameRoot GameRef;

        protected ControlManager ControlManager;

        protected PlayerIndex playerIndexInControl;


        public BaseGameState(Game game, GameStateManager manager)
            : base (game, manager)
        {
            GameRef = (GameRoot)game;

            playerIndexInControl = PlayerIndex.One;
        }

        protected override void LoadContent()
        {
            ContentManager Content = Game.Content;

            SpriteFont menuFont = Content.Load<SpriteFont>("Fonts/ControlFont");
            ControlManager = new ControlManager(menuFont);

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using mountains_of_yendor.XLib;

namespace mountains_of_yendor.GameScreens
{
    public abstract partial class BaseGameState : GameState
    {

        protected GameRoot GameRef;


        public BaseGameState(Game game, GameStateManager manager)
            : base (game, manager)
        {
            GameRef = (GameRoot)game;
        }
    }
}

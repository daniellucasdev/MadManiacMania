using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadManiac_Mania
{
    internal class ScaledSprite : Sprite
    {
        public Rectangle Rect
            { get
            { return new Rectangle((int)position.X, (int)position.y)}
        public ScaledSprite(Texture2D texture, Vector2 position ) : base(texture, position

            )
       

    }
}

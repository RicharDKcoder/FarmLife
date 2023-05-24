using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FarmLife;


public abstract class Component
{
    protected SpriteBatch spriteBatch;
    protected Texture2D texture2D;
    public Vector2 position;

    public abstract void Draw(GameTime gameTime);
}
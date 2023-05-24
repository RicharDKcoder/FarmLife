using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable enable
namespace FarmLife;

public class Player : Component
{


    public Player(SpriteBatch spriteBatch)
    {
        this.spriteBatch = spriteBatch;

        texture2D = new Texture2D(spriteBatch.GraphicsDevice, 1, 1);
        texture2D.SetData<Color>(new Color[] { Color.White });
        position = new Vector2(10, 10);
    }

    public void Update(GameTime gameTime)
    {


    }

    public override void Draw(GameTime gameTime)
    {
        spriteBatch.Draw(this.texture2D, position, new Rectangle(10, 10, 15, 15), Color.Red);
    }

    public void keyboardEventHandler(object? sender, Vector2 vector2)
    {
        Console.WriteLine($"======> sender:{sender}, vector2: {vector2}");
        this.position += vector2;
    }
}
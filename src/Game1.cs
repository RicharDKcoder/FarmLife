using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FarmLife;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    // private Camera _camera;
    private ComponentManager _componentManager;
    private EventManager _eventManager;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        // this._camera = new Camera();
        this._componentManager = new ComponentManager();
        this._eventManager = new EventManager();


        // instance
        Player player = new Player(_spriteBatch);
        // component
        this._componentManager.Register(player);
        // event
        this._eventManager.RegisterMovenEvent(player.keyboardEventHandler);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        // _camera.Follow(_player);


        if (Keyboard.GetState().IsKeyDown(Keys.S))
        {
            this._eventManager.OnMoveEvent(new Vector2(0, 1));
        }
        if (Keyboard.GetState().IsKeyDown(Keys.W))
        {
            this._eventManager.OnMoveEvent(new Vector2(0, -1));
        }
        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            this._eventManager.OnMoveEvent(new Vector2(-1, 0));
        }
        if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            this._eventManager.OnMoveEvent(new Vector2(1, 0));
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        // _spriteBatch.Begin(transformMatrix: _camera.Transform);
        _spriteBatch.Begin();

        foreach (Component component in _componentManager.GetComponentList())
        {
            component.Draw(gameTime);
        }
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}

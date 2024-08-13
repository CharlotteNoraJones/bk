using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace bk;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private Texture2D _bk_graphics;

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

        _bk_graphics = Content.Load<Texture2D>("graphics");

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        Point paddle_dimensions = new(64, 16);
        Point paddle_position_in_spritesheet = new(16, 16);
        Point position = new(128, 128);
        Rectangle paddle_rectangle = new(paddle_position_in_spritesheet, paddle_dimensions);
        Rectangle destination_rectangle = new(position.X, position.Y, paddle_dimensions.X, paddle_dimensions.Y);

        _spriteBatch.Begin();
        _spriteBatch.Draw(_bk_graphics, destination_rectangle, paddle_rectangle, Color.White);
        _spriteBatch.End();
        base.Draw(gameTime);
    }
}

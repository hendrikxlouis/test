using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class HalloGame : Game
{
    public HalloGame()
    {
        this.Window.Title = "HalloGame";
        this.Content.RootDirectory = "Content";
        GraphicsDeviceManager manager;
        manager = new GraphicsDeviceManager(this);
    }

    protected override void Draw(GameTime gameTime)
    {
        this.GraphicsDevice.Clear(Color.Yellow);

        SpriteBatch spriteBatch;
        spriteBatch = new SpriteBatch(this.GraphicsDevice);
        spriteBatch.Begin();
        spriteBatch.DrawString( this.Content.Load<SpriteFont>("SpelFont")
                              , "Hallo!"
                              , new Vector2(gameTime.TotalRealTime.Milliseconds, 20)
                              , Color.Blue
                              );
        spriteBatch.End();
    }
}

class Program
{
    static void Main()
    {
        HalloGame spel;
        spel = new HalloGame();
        spel.Run();
    }
}
using Microsoft.Xna.Framework;

public class Playground : Game {
    private GraphicsDeviceManager graphics;

    public Playground() {
        graphics = new GraphicsDeviceManager(this);
    }

    protected override void Initialize() {
        base.Initialize();
    }

    protected override void Update(GameTime gameTime) {
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) {
        graphics.GraphicsDevice.Clear(Color.Black);
        base.Draw(gameTime);
    }
}

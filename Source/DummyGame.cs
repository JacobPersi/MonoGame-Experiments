using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

public class DummyGame : Game {

    private Scene scene;
    private GraphicsDeviceManager graphics;

    public DummyGame() {
        graphics = new GraphicsDeviceManager(this);
    }

    protected override void Initialize() {
        base.Initialize();
        scene = new DevScene(); 
    }

    protected override void Update(GameTime gameTime) {
        scene.Update(gameTime);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) {
        scene.Render(graphics, gameTime);
        graphics.GraphicsDevice.Clear(Color.Black);
        base.Draw(gameTime);
    }
}

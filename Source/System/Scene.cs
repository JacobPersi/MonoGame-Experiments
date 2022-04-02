using Microsoft.Xna.Framework;

public class Scene {

    private Camera Camera; 
    private Entity[] EntityList; 

    public Scene() { }

    public void Render(GraphicsDeviceManager graphics, GameTime gameTime) {
        foreach (Entity entity in EntityList) {
            if (entity.IsVisible) {
                //entity.Draw();
            }
        }
    }

    public void Update(GameTime gameTime) {
        foreach (Entity entity in EntityList) {
            if (entity.IsActive) {
                //entity.Update();
            }
        }
    }

}
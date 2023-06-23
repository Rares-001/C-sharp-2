using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project002;

public class Background
{
    private Texture2D _texture;

    public Background()
    {
        _texture = Globals.Content.Load<Texture2D>("arena");
    }

    public void Draw()
    {
        Globals.SpriteBatch.Draw(_texture, Vector2.Zero, Color.White);
    }
}

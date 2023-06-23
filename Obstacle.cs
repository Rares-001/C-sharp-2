using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project002;

public class Obstacle : Sprite
{
    private Texture2D _texture;
    private Rectangle _rectangle;

    public Vector2 Size { get; set; }

    public Obstacle(Texture2D texture, Vector2 pos, Vector2 size) : base(texture, pos)
    {
        _texture = texture;
        Size = size;
        _rectangle = new Rectangle((int)pos.X, (int)pos.Y, (int)size.X, (int)size.Y);
    }

    public bool Intersects(Sprite sprite)
    {
        return _rectangle.Intersects(sprite.Rectangle);
    }

    public void Draw(Color color)
    {
        //var borderThickness = 10; // Set border thickness here
        // var borderColor = Color.Red; // Set border color here

        //Globals.SpriteBatch.Draw(_texture, Position, null, color, Rotation, origin, Scale, SpriteEffects.None, 1);

        // Draw top border
        //Globals.SpriteBatch.Draw(_texture, new Rectangle((int)Position.X, (int)Position.Y - borderThickness, (int)Size.X, borderThickness), borderColor);
        // Draw bottom border
        //Globals.SpriteBatch.Draw(_texture, new Rectangle((int)Position.X, (int)Position.Y + (int)Size.Y, (int)Size.X, borderThickness), borderColor);
        // Draw left border
        //Globals.SpriteBatch.Draw(_texture, new Rectangle((int)Position.X - borderThickness, (int)Position.Y, borderThickness, (int)Size.Y), borderColor);
        // Draw right border
        //Globals.SpriteBatch.Draw(_texture, new Rectangle((int)Position.X + (int)Size.X, (int)Position.Y, borderThickness, (int)Size.Y), borderColor);
    }
}

namespace Project002;

public class Sprite
{
    protected readonly Texture2D texture;
    protected readonly Vector2 origin;
    public Vector2 Position { get; set; }
    public float Rotation { get; set; }
    public float Scale { get; set; }
    public Color Color { get; set; }

    // Adding Rectangle property
    public Rectangle Rectangle
    {
        get
        {
            return new Rectangle((int)Position.X, (int)Position.Y, texture.Width, texture.Height);
        }
    }

    public Sprite(Texture2D tex, Vector2 pos)
    {
        texture = tex;
        Position = pos;
        origin = new Vector2(tex.Width / 2, tex.Height / 2);
        Scale = 1f;
        Color = Color.White;
    }

    public virtual void Draw()
    {
        Globals.SpriteBatch.Draw(texture, Position, null, Color, Rotation, origin, Scale, SpriteEffects.None, 1);
    }
}

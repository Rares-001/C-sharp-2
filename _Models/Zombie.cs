namespace Project002;

public class Zombie : MovingSprite
{
    public int HP { get; private set; }

    public Zombie(Texture2D tex, Vector2 pos) : base(tex, pos)
    {
        Speed = 100;
        HP = 2;
    }

    public void TakeDamage(int dmg)
    {
        HP -= dmg;
        if (HP <= 0) ExperienceManager.AddExperience(Position);
    }

    public void Update(Player player, List<Obstacle> obstacles)
    {
        var toPlayer = player.Position - Position;
        Rotation = (float)Math.Atan2(toPlayer.Y, toPlayer.X);

        if (toPlayer.Length() > 4)
        {
            var dir = Vector2.Normalize(toPlayer);
            Vector2 newPosition = Position + dir * Speed * Globals.TotalSeconds;

            // Check if the new position intersects with any obstacle
            if (!ObstacleManager.Intersects(new Sprite(Globals.Content.Load<Texture2D>("zombie"), newPosition)))
            {
                Position = newPosition;
            }
        }
    }
}

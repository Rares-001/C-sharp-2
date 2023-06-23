using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project002;
using System.Collections.Generic;

public static class ObstacleManager
{
    private static List<Obstacle> _obstacles;

    public static List<Obstacle> Obstacles { get => _obstacles; }

    public static void Init(Texture2D texture)
    {
        _obstacles = new List<Obstacle>();

        // Add obstacles here with positions and sizes of your choice.
        // Here's an example:
        _obstacles.Add(new Obstacle(texture, new Vector2(321, 439), new Vector2(488-321, 638-439)));
        _obstacles.Add(new Obstacle(texture, new Vector2(659, 86), new Vector2(1081-659, 283 - 86)));
        _obstacles.Add(new Obstacle(texture, new Vector2(833, 482), new Vector2(967-833, 620 - 482)));
        _obstacles.Add(new Obstacle(texture, new Vector2(1274, 348), new Vector2(1442 - 1274, 544 - 348)));
        _obstacles.Add(new Obstacle(texture, new Vector2(762, 706), new Vector2(840 - 762, 907 - 706)));
        _obstacles.Add(new Obstacle(texture, new Vector2(1046, 753), new Vector2(1093 - 1046, 853 - 753)));
    }

    public static bool Intersects(Sprite sprite)
    {
        foreach (var obstacle in _obstacles)
        {
            if (obstacle.Intersects(sprite))
            {
                return true;
            }
        }
        return false;
    }

    public static void Draw()
    {
        // Draw obstacles with color of your choice. Here's an example:
        foreach (var obstacle in _obstacles)
        {
            obstacle.Draw(Color.White);
        }
    }
}

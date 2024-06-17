using GameLibrary.GL.Enum;

namespace GameLibrary.GL.Interfaces
{
    public interface ICollision
    {
        bool CheckCollisions(GameObject g1, GameObject g2);
        Action CheckCollisionAction(GameObject g1, GameObject g2);
    }
}

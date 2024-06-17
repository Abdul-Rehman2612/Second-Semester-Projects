using GameLibrary.GL.Enum;
using GameLibrary.GL.Interfaces;


namespace GameLibrary.GL.Collision
{
    public class Collisions : ICollision
    {
        public bool CheckCollisions(GameObject g1, GameObject g2)
        {
            if(g1.GetPictureBox().Bounds.IntersectsWith(g2.GetPictureBox().Bounds))
            return true;
            else
            return false;
        }
        public Action CheckCollisionAction(GameObject g1, GameObject g2)
        {
            Action action=Action.DoNothing;
            if ((g1.GetObjectType() == ObjectType.Player && g2.GetObjectType() == ObjectType.Enemy) || (g2.GetObjectType() == ObjectType.Player && g1.GetObjectType() == ObjectType.Enemy))
            {
                action = Action.RemovePlayer;
            }
            else if ((g1.GetObjectType() == ObjectType.Wall && g2.GetObjectType() == ObjectType.Enemy) || (g2.GetObjectType() == ObjectType.Wall && g1.GetObjectType() == ObjectType.Enemy))
            {
                action = Action.DoNothing;
            }
            else if ((g1.GetObjectType() == ObjectType.Player && g2.GetObjectType() == ObjectType.Wall) || (g2.GetObjectType() == ObjectType.Player && g1.GetObjectType() == ObjectType.Wall))
            {
                action = Action.DoNothing;
            }
            else if ((g1.GetObjectType() == ObjectType.Bullet && g2.GetObjectType() == ObjectType.Enemy)|| g2.GetObjectType() == ObjectType.Bullet && g1.GetObjectType() == ObjectType.Enemy)
            {
                action = Action.RemoveEB;
            }
            else if ((g1.GetObjectType() == ObjectType.Bullet && g2.GetObjectType() == ObjectType.Wall) || (g2.GetObjectType() == ObjectType.Bullet && g1.GetObjectType() == ObjectType.Wall))
            {
                action=Action.RemoveBullet;
            }
            else if ((g1.GetObjectType() == ObjectType.Bullet && g2.GetObjectType() == ObjectType.Reward) || (g2.GetObjectType() == ObjectType.Bullet && g1.GetObjectType() == ObjectType.Reward))
            {
                action=Action.RemoveBullet;
            }
            else if ((g1.GetObjectType() == ObjectType.Player && g2.GetObjectType() == ObjectType.Reward) || (g2.GetObjectType() == ObjectType.Player && g1.GetObjectType() == ObjectType.Reward))
            {
                action=Action.IncreaseScore;
            }
            return action;
        }
    }
}

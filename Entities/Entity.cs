using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThroughTheWalls.Entities
{
    public class Entity
    {
        public int PozX { get; set; }
        public int PozY { get; set; }

        public Vector MovingDirection { get; set; }
        public float MovingSpeed { get; set; }

        public bool IsMoving { get; set; }
        public int IdleFrames { get; set; }
        public int RunFrames { get; set; }

        public int CurrentAnimation { get; set; }
        public int CurrentFrame { get; set; }
        public int CurrentAnimLimit { get; set; }
        public int SpriteSize { get; set; }

        public Image SpriteSheet { get; set; }


        public void Move()
        {
            PozX += MovingDirection.X * (int)MovingSpeed;
            PozY += MovingDirection.Y * (int)MovingSpeed;
        }

        public void SetAnimationConfiguration(int currentAnimation)
        {
            if (MovingDirection.X > 0 && MovingDirection.Y == 0)
                CurrentAnimation = 1;
            else if (MovingDirection.X < 0 && MovingDirection.Y == 0)
                CurrentAnimation = 3;
            else if (MovingDirection.Y > 0 && MovingDirection.X == 0)
                CurrentAnimation = 2;
            else if (MovingDirection.Y < 0)
                CurrentAnimation = 0;
            else
                CurrentAnimation = 2;

        }
    }
}

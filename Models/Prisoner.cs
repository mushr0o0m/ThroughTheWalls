using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThroughTheWalls.Entities;

namespace ThroughTheWalls.Models
{
    public class Prisoner : Entity
    {
        private Image spriteSheet = Sprites.Prisoner;
        private int idleFrames = 3;
        private int runFrames = 3;
        private int spriteSize = 36;
        private float movingSpeed = 10f;
        private Vector startMovingDirection = Vector.Zero; 

        public Prisoner(int pozX, int pozY)
        {
            MovingDirection = startMovingDirection;
            PozX = pozX;
            PozY = pozY;
            SpriteSize = spriteSize;
            IdleFrames = idleFrames;
            RunFrames = runFrames;
            SpriteSheet = spriteSheet;
            MovingSpeed = movingSpeed;
        }
    }
}

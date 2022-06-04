using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThroughTheWalls.Control
{
    public class Input
    {
        private static int horizontalAxis = 0;
        public static int HorizontalAxis
        {
            get => horizontalAxis;
            private set
            {
                if (Math.Abs(value) > 1)
                    throw new ArgumentException();
                else
                    horizontalAxis = value;
            }
        }
        private static int verticalAxis = 0;
        public static int VerticalAxis
        {
            get => verticalAxis;
            private set
            {
                if (Math.Abs(value) > 1)
                    throw new ArgumentException();
                else
                    verticalAxis = value;
            }
        }

        public static void SetAxis(Keys key)
        {
            if (key == Keys.W || key == Keys.Up)
                VerticalAxis = -1;
            else if (key == Keys.S || key == Keys.Down)
                VerticalAxis = 1;
            else if (key == Keys.A || key == Keys.Left)
                HorizontalAxis = -1;
            else if (key == Keys.D || key == Keys.Right)
                HorizontalAxis = 1;
        }

        public static void SetAxis(char key)
        {
            if (key == 'w')
                VerticalAxis = -1;
            else if (key == 's')
                VerticalAxis = 1;
            else if (key == 'a')
                HorizontalAxis = -1;
            else if (key == 'd')
                HorizontalAxis = 1;
        }

        public static void ResetAxis(Keys key)
        {
            if (key == Keys.W || key == Keys.Up || key == Keys.S || key == Keys.Down)
                VerticalAxis = 0;
            else if (key == Keys.A || key == Keys.Left || key == Keys.D || key == Keys.Right)
                HorizontalAxis = 0;
        }

        public static void ResetAxis()
        {
                VerticalAxis = 0;
                HorizontalAxis = 0;
        }
    }
}

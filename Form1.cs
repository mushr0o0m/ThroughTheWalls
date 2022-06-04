using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThroughTheWalls.Control;
using ThroughTheWalls.Entities;
using ThroughTheWalls.Models;

namespace ThroughTheWalls
{
    public partial class Form1 : Form
    {
        private Prisoner player;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            timer1.Interval = 60;
            timer1.Tick += new EventHandler(Update);

            KeyDown += new KeyEventHandler(OnKeyDown);
            KeyUp += new KeyEventHandler(OnKeyUp);
            InitializeEntities();
        }

        public void InitializeEntities()
        {
            player = new Prisoner(0, 0);
            timer1.Start();
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            Input.SetAxis(e.KeyCode);
            player.IsMoving = true;
        }
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            Input.ResetAxis(e.KeyCode);
            if(player.MovingDirection.X == 0 && player.MovingDirection.Y == 0)
                player.IsMoving = false;
            
        }

        
        private void Update (object sender, EventArgs e)
        {
            player.MovingDirection.X = Input.HorizontalAxis;
            player.MovingDirection.Y = Input.VerticalAxis;
            player.SetAnimationConfiguration(2);
            player.Move();

            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            ClientSize = new Size(1920, 1080);
            Graphics graphics = e.Graphics;
            graphics.DrawImage(player.SpriteSheet,
                new Rectangle(new Point(player.PozX, player.PozY), new Size(player.SpriteSize, player.SpriteSize)),
                player.CurrentFrame*36, player.CurrentAnimation*36,
                player.SpriteSize, player.SpriteSize,
                GraphicsUnit.Pixel);

            if (player.CurrentFrame < player.IdleFrames - 1)
            {
                player.CurrentFrame++;
            }
            else player.CurrentFrame = 0;
        }
    }
}

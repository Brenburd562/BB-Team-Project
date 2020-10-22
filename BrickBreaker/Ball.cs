using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace BrickBreaker
{
    public class Ball
    {
        public int x, y, xSpeed, ySpeed, size;
        public Color colour;

        public static Random rand = new Random();

        SoundPlayer wallBounce = new SoundPlayer(Properties.Resources.wallSound);
        SoundPlayer paddleBounce = new SoundPlayer(Properties.Resources.paddleSound);
        SoundPlayer brickBounce = new SoundPlayer(Properties.Resources.breakSound);

        public Ball(int _x, int _y, int _xSpeed, int _ySpeed, int _ballSize)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;
               
        }

        public void Move()
        {
            x = x + xSpeed;
            y = y + ySpeed;
        }

        public bool BlockCollision(Block b)
        {
            Rectangle blockRec = new Rectangle(b.x, b.y, 50, 25);
            Rectangle ballRec = new Rectangle(x, y, size, size);

            if (ballRec.IntersectsWith(blockRec))
            {
              
                brickBounce.Play();
            }

            return blockRec.IntersectsWith(ballRec);         
        }

        public void PaddleCollision(Paddle p, bool pMovingLeft, bool pMovingRight)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (ballRec.IntersectsWith(paddleRec))
            {
                int ranDir;
                //if (x >= p.x && x <= p.x + p.height / 4)
                //{
                //    ySpeed = -1;
                //}
                //else if (x >= p.x + p.height / 4 && x <= p.x + p.height / 2)
                //{
                //    ySpeed = -2;
                //}
                //else if (x >= p.x + p.height / 2 && x <= p.x + p.height * 0.75)
                //{
                //    ySpeed = -2;
                //}
                //else if (x >= p.x + p.height * 0.75 && x <= p.x + p.height)
                //{
                //    ySpeed = -1;
                //}

                ranDir = rand.Next(0, 4);

                if (y + size >= p.y && y + size <= p.y + ySpeed + 2)
                {
                    if (ranDir == 0)
                    {
                        ySpeed = -2;
                    }
                    else if (ranDir == 1)
                    {
                        ySpeed = -4;
                    }
                    else if (ranDir == 2)
                    {
                        ySpeed = -6;
                    }
                    else if (ranDir == 3)
                    {
                        ySpeed = -8;
                    }
                }
                else if (y >= p.y && y <= p.y + p.height)
                {
                    xSpeed *= -1;
                }
                paddleBounce.Play();
                if (pMovingLeft)
                    xSpeed = -Math.Abs(xSpeed); 
                else if (pMovingRight)
                    xSpeed = Math.Abs(xSpeed);
            }
        }

        public void WallCollision(UserControl UC)
        {
            // Collision with left wall
            if (x <= 0)
            {
                wallBounce.Play();
                xSpeed *= -1;
                x = 1;
            }
            // Collision with right wall
            if (x >= (UC.Width - size))
            {
                wallBounce.Play();
                xSpeed *= -1;
                x = (UC.Width - size - 1);
            }
            // Collision with top wall
            if (y <= 2)
            {
                wallBounce.Play();
                ySpeed *= -1;
                y = 3;
            }
        }

        public bool BottomCollision(UserControl UC)
        {
            Boolean didCollide = false;

            if (y >= UC.Height)
            {
                didCollide = true;
            }

            return didCollide;
        }

    }
}

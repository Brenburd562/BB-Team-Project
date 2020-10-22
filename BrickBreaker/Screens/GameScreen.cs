/*  Created by: 
 *  Project: Brick Breaker
 *  Date: 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using System.IO;
using System.Threading;
using BrickBreaker.Properties;


namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        #region global values


        //New List for new happiness
        List<Ball> powerupBall = new List<Ball>();
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, rightArrowDown, escKeyDown, spaceDown, gamePaused;

        // Game values

        int lives = 3;
        int score = 0;
        int level = 1;
        int counter = 1;

        // Paddle and Ball objects
        Paddle paddle;
        Ball ball;

        
        

        // list of all blocks for current level
        List<Block> blocks = new List<Block>();
        List<Powerups> Powerup = new List<Powerups>();
        public static List<int> scores = new List<int>();

        // Brushes

        #endregion

        public GameScreen()
        {
            InitializeComponent();

            OnStart();

        }

        public void IanMethod()
        {
            string type = "";
            Color c = Color.White;

            int ballX = this.Width / 2 ;
            int ballY = this.Height - paddle.height - 80;
            int ballSize = 20;

            Random powerGen = new Random();

            foreach (Block b in blocks)
            {
                if (ball.BlockCollision(b))
                {
                    int powerupChance = powerGen.Next(1, 4);
                    int powerupType = powerGen.Next(1, 6);

                    if (powerupChance == 1)
                    {
                        if (powerupType == 1) // add 300 points
                        {
                            type = "points";

                            c = Color.Blue;
                        }
                        else if (powerupType == 2) // add another ball
                        {
                            type = "ball";
                            c = Color.Yellow;
                        }
                        else if (powerupType == 3) // add extra life
                        {
                            type = "life";
                            c = Color.Red;
                        }
                        else if (powerupType == 4) // bigger paddle
                        {
                            type = "big";
                            c = Color.Green;

                        }
                        else if (powerupType == 5) // makes paddle faster
                        {
                            type = "fast";
                            c = Color.Pink;
                        }
                        SolidBrush powerBrush = new SolidBrush(c);
                        Powerups newPowerup = new Powerups(b.x + b.width / 2 - 5, b.y + b.height / 2 - 5, 10, type, powerBrush);
                        Powerup.Add(newPowerup);
                    }

                }
            }
            foreach (Powerups p in Powerup)
            {
                p.Move(3);
            }
            foreach (Powerups d in Powerup)
            {
                Rectangle powerRec = new Rectangle(d.x, d.y, d.size, d.size);
                Rectangle paddleRec = new Rectangle(paddle.x, paddle.y, paddle.width, paddle.height);

                if (powerRec.IntersectsWith(paddleRec))
                {

                        if (d.type == "points")
                        {
                        score += 300;
                        }
                        else if (d.type == "ball")
                        {
                         Rectangle ballRec = new Rectangle(ball.x, ball.y, ball.size, ball.size);
                        if (powerupBall.Count == 0)
                        {
                            Ball powerball = new Ball(this.Width / 2 - 10, this.Height / 2 + 80, -6, -6, ballSize);
                            powerupBall.Add(powerball);
                        }
                    }
                        else if (d.type == "life")
                        {
                            lives++;
                        }
                        else if (d.type == "big")
                        {
                         paddle.width += 100;
                   
                    }
                    else if (d.type == "fast")
                    {
                        paddle.speed += 1;
                    }
                    d.y = this.Height + 1;
                }
            }
            int index = Powerup.FindIndex(b => b.y > this.Height);
            if (index >= 0 && Powerup.Count() > 0)
            {
                Powerup.RemoveAt(index);
            }
        }

        public void OnStart()
        {

            #region Global variables

           

            //set all button presses to false.
            leftArrowDown = rightArrowDown = escKeyDown = false;


            // setup starting paddle values and create paddle object
            int paddleWidth = 80;
            int paddleHeight = 20;
            int paddleX = ((this.Width / 2) - (paddleWidth / 2));
            int paddleY = (this.Height - paddleHeight) - 60;
            int paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.White);

            // setup starting ball values
            int ballX = this.Width / 2 - 10;
            int ballY = this.Height - paddle.height - 80;

            // Creates a new ball
            int xSpeed = 0;
            int ySpeed = 0;
            int ballSize = 20;
            ball = new Ball(ballX, ballY, xSpeed, ySpeed, ballSize);
           

            #endregion

            pauseLabel.Visible = false;
            menuButton.Enabled = false;
            menuButton.Visible = false;
            resumeButton.Enabled = false;
            resumeButton.Visible = false;
            TsunamiLevelLoad();

            // start the game engine loop
            gameTimer.Enabled = true;
        }

        private void TsunamiLevelLoad()
        {
  
            XmlTextReader reader = new XmlTextReader("Resources/level" + level + ".xml");


                while (reader.Read())
                {

                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        int x = Convert.ToInt32(reader.ReadString());

                        reader.ReadToNextSibling("y");
                        int y = Convert.ToInt32(reader.ReadString());

                        reader.ReadToNextSibling("hp");
                        int hp = Convert.ToInt32(reader.ReadString());


                        Block newBlock = new Block(x, y, hp);
                        blocks.Add(newBlock);
                    }
                }

            }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Escape:
                    escKeyDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;

                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Escape:
                    escKeyDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;

                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            livesLabel.Text = "Lives: " + lives;
            scoreLabel.Text = "Score: " + score;

            IanMethod();

            #region Move the paddle

            if (paddle.width > 80 && counter %5 == 0)
            {
                paddle.width--;
            }

            // Move the paddle

            if (leftArrowDown && paddle.x > 0 && ball.xSpeed == 0 &&ball.ySpeed == 0)
            {
                paddle.Move("left");
                ball.x = paddle.x + paddle.width / 2 - 10;
            }
            if (rightArrowDown && paddle.x < (this.Width - paddle.width) && ball.xSpeed == 0 && ball.ySpeed == 0)
            {
                paddle.Move("right");
                ball.x = paddle.x + paddle.width / 2 - 10;
            }

            else if (leftArrowDown && paddle.x > 0)
            {
                paddle.Move("left");
            }
            else if (rightArrowDown && paddle.x < (this.Width - paddle.width))
            {
                paddle.Move("right");
            }

            if(ball.xSpeed == 0 && ball.ySpeed == 00 && spaceDown == true && leftArrowDown == true)
            {
                ball.xSpeed = -6;
                ball.ySpeed = 6;
            }

            else if(ball.xSpeed == 0 && ball.ySpeed == 00 && spaceDown == true)
            {
                ball.xSpeed = 6;
                ball.ySpeed = 6;
            }

            #endregion

            #region Move ball
            ball.Move();

            if (powerupBall.Count() >= 1) 
            {
                foreach(Ball p in powerupBall)
                {
                    p.Move();
                }
            }
            #endregion

            #region Check for collision with top and side walls

            IanMethod();

            // Check for collision with top and side walls

            ball.WallCollision(this);

            if (powerupBall.Count() >= 1)
            {
                powerupBall[0].WallCollision(this);
            }
            #endregion

            #region Check for ball hitting bottom of screen
            if (ball.BottomCollision(this))
            {
                lives--;

                livesLabel.Text = "";
                livesLabel.Text = "Lives: " + lives;

                ball.xSpeed = 0;
                ball.ySpeed = 0;
                // Moves the ball back to origin
                ball.x = ((paddle.x - (ball.size / 2)) + (paddle.width / 2));
                ball.y = (this.Height - paddle.height) - 85;

                paddle.width = 80;

                powerupBall.RemoveAt(0);
                
                paddle.x = this.Width / 2 - paddle.width / 2;
                #endregion

                #region check if game over

                if (lives == 0)
                {
                    scores.Add(score);
                    scores.Sort();

                    gameTimer.Enabled = false;
                    OnEnd();
                }
                #endregion
            }
            int index = Powerup.FindIndex(b => b.y > this.Height);
            if (powerupBall.Count() >= 1 && index >= 0)
            {
                powerupBall.RemoveAt(index);
            }

            #region Check for collision of ball with paddle, (incl. paddle movement)
            ball.PaddleCollision(paddle, leftArrowDown, rightArrowDown);
            if (powerupBall.Count() >= 1)
            {
                powerupBall[0].PaddleCollision(paddle, leftArrowDown, rightArrowDown);
            }
            #endregion

            #region Check if ball has collided with any blocks
            foreach (Block b in blocks)
            {
                if (ball.BlockCollision(b))
                {
                    Rectangle blockRec = new Rectangle(b.x, b.y, 50, 25);
                    Rectangle ballRec = new Rectangle(ball.x, ball.y, ball.size, ball.size);
                    if (ballRec.IntersectsWith(blockRec))
                    {
                        if (ball.x <= b.x + 50 && ball.x >= b.x)
                        {
                            ball.xSpeed = ball.xSpeed * -1;
                        }
                        else if (ball.y >= b.y - ball.size && ball.y <= b.y + 25)
                        {

                            ball.ySpeed = ball.ySpeed * -1;
                        }

                        SoundPlayer brickPlayer = new SoundPlayer(Properties.Resources.breakSound);
                        brickPlayer.Play();

                    }

                    b.hp--;

                    score += 100;

                    if (b.hp == 0)
                    {
                        blocks.Remove(b);
                    }

                    if (blocks.Count == 0 && level == 5)

                    {

                        gameTimer.Enabled = false;
                        OnWin();
                        
                    }
                    else if(blocks.Count == 0)
                    {
                        level++;
                        OnStart();
                    }

                    break;
                }
            }
            #endregion


            pauseScreenEnabled();
            counter++;
            //redraw the screen
            Refresh();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            gamePaused = false;
            OnEnd();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (level < 6)
            {
                gameTimer.Enabled = true;
                pauseLabel.Visible = false;
                resumeButton.Enabled = false;
                resumeButton.Visible = false;
                menuButton.Enabled = false;
                menuButton.Visible = false;
                gamePaused = false;
                this.Focus();
            }
            else
            {
                Application.Exit();
            }



        }
        // Both below functions error out when given time to load
        public void OnEnd()
        {
            gameTimer.Stop();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen gos = new GameOverScreen();
            f.Controls.Add(gos);

            gos.Location = new Point((f.Width - gos.Width) / 2, (f.Height - gos.Height) / 2);

            gos.Focus();
        }
        public void OnWin()
        {

            gameTimer.Stop();

            pauseLabel.Visible = true;
            pauseLabel.Text = "You Win!";
            menuButton.Enabled = true;
            menuButton.Visible = true;
            resumeButton.Enabled = true;
            resumeButton.Visible = true;
            resumeButton.Text = "Quit Game";

            //gameTimer.Stop();
            //Form f = this.FindForm();

            //f.Controls.Remove(this);
            //playAgainButton ws = new playAgainButton();

            //ws.Location = new Point((f.Width - ws.Width) / 2, (f.Height - ws.Height) / 2);

            //f.Controls.Add(ws);
        }

        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            #region Draws paddle
            e.Graphics.DrawImage(Properties.Resources.paddleSword, paddle.x, paddle.y, paddle.width, paddle.height);
            #endregion


            // Draws blocks
            foreach (Block b in blocks)
            {
                if (b.hp == 1)
                {
                    e.Graphics.DrawImage(Properties.Resources.cobbleBrick_1hit, b.x, b.y, 50, 25);
                }
                else if (b.hp == 2)
                {
                    e.Graphics.DrawImage(Properties.Resources.cobbleBrick_2hits, b.x, b.y, 50, 25);
                }
                else if (b.hp == 3)
                {
                    e.Graphics.DrawImage(Properties.Resources.cobbleBrick_3hits, b.x, b.y, 50, 25);
                }
            }

            #region Draws ball
            e.Graphics.DrawImage(Resources.cannonBall, ball.x, ball.y, ball.size, ball.size);
            // draws powerupball
            if (powerupBall.Count() >= 1)
            {
                foreach (Ball p in powerupBall)
                {
                    e.Graphics.DrawImage(Resources.cannonBall, p.x, p.y, p.size, p.size);
                }
            }

            #endregion

            //Draws Powerup
            if (Powerup.Count() > 0)
            {
                foreach (Powerups p in Powerup)
                {
                    e.Graphics.FillRectangle(p.powerupBrush, p.x, p.y, p.size, p.size);
                }
            }

        }

        public void pauseScreenEnabled()
        {
            if (escKeyDown)
            {
                gamePaused = true;
            }
            if (gamePaused)
            {
                pauseLabel.Visible = true;
                gameTimer.Enabled = false;
                menuButton.Enabled = true;
                menuButton.Visible = true;
                resumeButton.Enabled = true;
                resumeButton.Visible = true;
            }
            else
            {
                gameTimer.Enabled = true;
            }

        }
    }
}



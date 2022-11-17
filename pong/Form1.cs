using System;
using System.Drawing;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        private Boolean paused = false;
        //scores
        private int rightScore = 0;
        private int leftScore = 0;
        //ball variables
        private int xDir = 1;
        private int yDir = 1;
        private int vel = 6;
        private Point ballPoint = new Point(384, 196); 

        //paddle variables
        private Boolean goingUp1 = false;
        private Boolean goingDown1 = false;
        private Boolean goingUp2 = false;
        private Boolean goingDown2 = false;

        private Point paddlePoint1 = new Point(12, 196);
        private Point paddlePoint2 = new Point(772, 196);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ball movement
            BallMove();
            if (ballPoint.Y <= 0 || ballPoint.Y + 3*ball.Height >= this.Height)
            {
                yDir *= -1;
            }

            bool bounce1 = (ballPoint.X <= paddlePoint1.X + paddle1.Width && ballPoint.Y >= paddlePoint1.Y && ballPoint.Y <= paddlePoint1.Y + paddle1.Height);
            bool bounce2 = (ballPoint.X + ball.Width >= paddlePoint2.X && ballPoint.Y >= paddlePoint2.Y && ballPoint.Y <= paddlePoint2.Y + paddle2.Height);
            if (bounce1 || bounce2)
            {
                xDir *= -1;
            }

            //score
            if (ballPoint.X <= 0)
            {
                ballPoint = new Point(384, 196);
                xDir *= -1;
                rightScore += 1;
                lblScore2.Text = rightScore.ToString();
            }
            if (ballPoint.X + ball.Width >= this.Width)
            {
                ballPoint = new Point (384, 196);
                xDir *= -1;
                leftScore += 1;
                lblScore1.Text = leftScore.ToString();
            }

            //paddle1 movement
            if (!paused)
            {
                if (goingUp1 && paddlePoint1.Y >= 0)
                {
                    paddlePoint1.Y -= 10;
                }
                if (goingDown1 && (paddlePoint1.Y + 1.5 * paddle1.Height) <= this.Height)
                {
                    paddlePoint1.Y += 10;
                }

                //paddle2 movement
                if (goingUp2 && paddlePoint2.Y >= 0)
                {
                    paddlePoint2.Y -= 10;
                }
                if (goingDown2 && (paddlePoint2.Y + 1.5 * paddle2.Height) <= this.Height)
                {
                    paddlePoint2.Y += 10;
                }
                paddle1.Location = paddlePoint1;
                paddle2.Location = paddlePoint2;
            }
            
        }

        private void BallMove()
        {
            if (!paused)
            {
                ballPoint.X += xDir * vel;
                ballPoint.Y += yDir * vel;
                ball.Location = new Point(ballPoint.X, ballPoint.Y);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                rightScore += 1;
                lblScore1.Text = rightScore.ToString();
            }*/
            if (e.KeyCode == Keys.S)
            {
                goingUp1 = false;
                goingDown1 = true;
            }
            if (e.KeyCode == Keys.W)
            {
                goingUp1 = true;
                goingDown1 = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goingUp2 = false;
                goingDown2 = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goingUp2 = true;
                goingDown2 = false;
            }

            if(e.KeyCode == Keys.Escape)
            {
                paused = !paused;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S)
            {
                goingDown1 = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goingUp1 = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goingDown2 = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goingUp2 = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ball.Location = new Point(384, 196);
        }
    }
}

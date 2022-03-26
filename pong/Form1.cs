using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        private Boolean goingUp = false;
        private Boolean goingDown = false;  

        private Point paddlePoint = new Point(12, 196);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goingUp)
            {
                paddlePoint.Y -= 10;
            }
            if (goingDown)
            {
                paddlePoint.Y += 10;
            }
            paddle1.Location = paddlePoint;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                goingUp = false;
                goingDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goingUp = true;
                goingDown = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                goingDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goingUp = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

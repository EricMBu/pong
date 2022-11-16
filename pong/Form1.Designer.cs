namespace pong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paddle1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.Panel();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.paddle2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // paddle1
            // 
            this.paddle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paddle1.Location = new System.Drawing.Point(12, 196);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(16, 63);
            this.paddle1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 17;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ball.Location = new System.Drawing.Point(384, 196);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(13, 14);
            this.ball.TabIndex = 1;
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("MGS2 Menu", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.Color.Crimson;
            this.lblScore1.Location = new System.Drawing.Point(213, 55);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(68, 32);
            this.lblScore1.TabIndex = 2;
            this.lblScore1.Text = "0";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("MGS2 Menu", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.Crimson;
            this.lblScore2.Location = new System.Drawing.Point(487, 55);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(68, 32);
            this.lblScore2.TabIndex = 3;
            this.lblScore2.Text = "0";
            // 
            // paddle2
            // 
            this.paddle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paddle2.Location = new System.Drawing.Point(772, 196);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(16, 63);
            this.paddle2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle1);
            this.Name = "Form1";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paddle1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Panel paddle2;
    }
}


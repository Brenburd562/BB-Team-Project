namespace BrickBreaker
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.livesLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.resumeButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // livesLabel
            // 
            this.livesLabel.BackColor = System.Drawing.Color.Transparent;
            this.livesLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.Color.White;
            this.livesLabel.Location = new System.Drawing.Point(4, 639);
            this.livesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(148, 39);
            this.livesLabel.TabIndex = 0;
            this.livesLabel.Text = "label1";
            this.livesLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(809, 639);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(255, 39);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "label1";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.DarkGray;
            this.resumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resumeButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.resumeButton.ForeColor = System.Drawing.Color.Black;
            this.resumeButton.Location = new System.Drawing.Point(470, 372);
            this.resumeButton.Margin = new System.Windows.Forms.Padding(4);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(126, 48);
            this.resumeButton.TabIndex = 5;
            this.resumeButton.Text = "resume game";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkGray;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.menuButton.ForeColor = System.Drawing.Color.Black;
            this.menuButton.Location = new System.Drawing.Point(470, 318);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(126, 48);
            this.menuButton.TabIndex = 4;
            this.menuButton.Text = "return to menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // pauseLabel
            // 
            this.pauseLabel.BackColor = System.Drawing.Color.DarkGray;
            this.pauseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.pauseLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.pauseLabel.Location = new System.Drawing.Point(0, 264);
            this.pauseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(1068, 48);
            this.pauseLabel.TabIndex = 3;
            this.pauseLabel.Text = "Game Paused";
            this.pauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.game_screen_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.pauseLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1068, 678);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;

        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label scoreLabel;

        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label pauseLabel;

    }
}

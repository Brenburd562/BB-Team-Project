namespace BrickBreaker
{
    partial class MenuScreen
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
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.highScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.playButton.Location = new System.Drawing.Point(330, 250);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(194, 77);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.playButton_Enter);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(330, 437);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 77);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // highScoreButton
            // 
            this.highScoreButton.BackColor = System.Drawing.Color.White;
            this.highScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.highScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.highScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.highScoreButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.highScoreButton.Location = new System.Drawing.Point(330, 342);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(194, 77);
            this.highScoreButton.TabIndex = 2;
            this.highScoreButton.Text = "High Scores";
            this.highScoreButton.UseVisualStyleBackColor = false;
            this.highScoreButton.Click += new System.EventHandler(this.highScoreButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.title_screen_brick_breaker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.highScoreButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button highScoreButton;
    }
}

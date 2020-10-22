namespace BrickBreaker
{
    partial class GameOverScreen
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
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.letter3Output = new System.Windows.Forms.Label();
            this.letter2Output = new System.Windows.Forms.Label();
            this.letter1Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Old English Text MT", 50F);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Salmon;
            this.gameOverLabel.Location = new System.Drawing.Point(0, 67);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(854, 105);
            this.gameOverLabel.TabIndex = 3;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(171, 423);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 77);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.White;
            this.playAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.playAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgainButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.playAgainButton.Location = new System.Drawing.Point(495, 423);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(194, 77);
            this.playAgainButton.TabIndex = 4;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            this.playAgainButton.Enter += new System.EventHandler(this.playAgainButton_Enter);
            // 
            // letter3Output
            // 
            this.letter3Output.BackColor = System.Drawing.Color.White;
            this.letter3Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.letter3Output.Location = new System.Drawing.Point(493, 211);
            this.letter3Output.Name = "letter3Output";
            this.letter3Output.Size = new System.Drawing.Size(120, 120);
            this.letter3Output.TabIndex = 11;
            this.letter3Output.Text = "A";
            this.letter3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letter2Output
            // 
            this.letter2Output.BackColor = System.Drawing.Color.White;
            this.letter2Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.letter2Output.Location = new System.Drawing.Point(367, 211);
            this.letter2Output.Name = "letter2Output";
            this.letter2Output.Size = new System.Drawing.Size(120, 120);
            this.letter2Output.TabIndex = 10;
            this.letter2Output.Text = "A";
            this.letter2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letter1Output
            // 
            this.letter1Output.BackColor = System.Drawing.Color.White;
            this.letter1Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.letter1Output.ForeColor = System.Drawing.Color.Black;
            this.letter1Output.Location = new System.Drawing.Point(241, 211);
            this.letter1Output.Name = "letter1Output";
            this.letter1Output.Size = new System.Drawing.Size(120, 120);
            this.letter1Output.TabIndex = 9;
            this.letter1Output.Text = "A";
            this.letter1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.letter3Output);
            this.Controls.Add(this.letter2Output);
            this.Controls.Add(this.letter1Output);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label letter3Output;
        private System.Windows.Forms.Label letter2Output;
        private System.Windows.Forms.Label letter1Output;
    }
}

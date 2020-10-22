namespace BrickBreaker
{
    partial class playAgainButton
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
            this.winLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.letter1Output = new System.Windows.Forms.Label();
            this.letter2Output = new System.Windows.Forms.Label();
            this.letter3Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.Font = new System.Drawing.Font("Old English Text MT", 50F);
            this.winLabel.ForeColor = System.Drawing.Color.Salmon;
            this.winLabel.Location = new System.Drawing.Point(0, 67);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(854, 76);
            this.winLabel.TabIndex = 5;
            this.winLabel.Text = "You Win!";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.menuButton.Location = new System.Drawing.Point(171, 423);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(194, 77);
            this.menuButton.TabIndex = 4;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.Enter += new System.EventHandler(this.menuButton_Enter);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(500, 423);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 77);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Quit Game";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // letter1Output
            // 
            this.letter1Output.BackColor = System.Drawing.Color.White;
            this.letter1Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.letter1Output.ForeColor = System.Drawing.Color.Black;
            this.letter1Output.Location = new System.Drawing.Point(241, 211);
            this.letter1Output.Name = "letter1Output";
            this.letter1Output.Size = new System.Drawing.Size(120, 120);
            this.letter1Output.TabIndex = 6;
            this.letter1Output.Text = "A";
            this.letter1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letter2Output
            // 
            this.letter2Output.BackColor = System.Drawing.Color.White;
            this.letter2Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.letter2Output.Location = new System.Drawing.Point(367, 211);
            this.letter2Output.Name = "letter2Output";
            this.letter2Output.Size = new System.Drawing.Size(120, 120);
            this.letter2Output.TabIndex = 7;
            this.letter2Output.Text = "A";
            this.letter2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letter3Output
            // 
            this.letter3Output.BackColor = System.Drawing.Color.White;
            this.letter3Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.letter3Output.Location = new System.Drawing.Point(493, 211);
            this.letter3Output.Name = "letter3Output";
            this.letter3Output.Size = new System.Drawing.Size(120, 120);
            this.letter3Output.TabIndex = 8;
            this.letter3Output.Text = "A";
            this.letter3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.letter3Output);
            this.Controls.Add(this.letter2Output);
            this.Controls.Add(this.letter1Output);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.exitButton);
            this.Name = "playAgainButton";
            this.Size = new System.Drawing.Size(854, 542);
            this.Load += new System.EventHandler(this.playAgainButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label letter1Output;
        private System.Windows.Forms.Label letter2Output;
        private System.Windows.Forms.Label letter3Output;
    }
}

namespace BrickBreaker
{
    partial class HighScoreScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.nameOutput = new System.Windows.Forms.Label();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(67, 35);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(277, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "HIGH SCORES";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.outputLabel.Location = new System.Drawing.Point(200, 81);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(447, 439);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameOutput
            // 
            this.nameOutput.BackColor = System.Drawing.Color.White;
            this.nameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.nameOutput.Location = new System.Drawing.Point(200, 81);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(217, 439);
            this.nameOutput.TabIndex = 3;
            this.nameOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreOutput
            // 
            this.scoreOutput.BackColor = System.Drawing.Color.White;
            this.scoreOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.scoreOutput.Location = new System.Drawing.Point(413, 81);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(234, 439);
            this.scoreOutput.TabIndex = 4;
            this.scoreOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.Load += new System.EventHandler(this.HighScoreScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Label scoreOutput;
    }
}

namespace RockPaperScissors
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblWinTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(477, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pick Rock, Paper, or Scissors";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(279, 343);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(263, 59);
            this.lblOutput.TabIndex = 4;
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = global::RockPaperScissors.Properties.Resources.Scissors;
            this.btnScissors.Location = new System.Drawing.Point(499, 147);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(314, 145);
            this.btnScissors.TabIndex = 3;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = global::RockPaperScissors.Properties.Resources.Paper;
            this.btnPaper.Location = new System.Drawing.Point(223, 138);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(270, 162);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = global::RockPaperScissors.Properties.Resources.TheRock;
            this.btnRock.Location = new System.Drawing.Point(10, 138);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(188, 189);
            this.btnRock.TabIndex = 1;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // lblWins
            // 
            this.lblWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(633, 378);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(85, 24);
            this.lblWins.TabIndex = 5;
            // 
            // lblWinTitle
            // 
            this.lblWinTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinTitle.Location = new System.Drawing.Point(649, 343);
            this.lblWinTitle.Name = "lblWinTitle";
            this.lblWinTitle.Size = new System.Drawing.Size(53, 28);
            this.lblWinTitle.TabIndex = 6;
            this.lblWinTitle.Text = "Wins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.lblWinTitle);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblWinTitle;
    }
}


namespace Twitter
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblPostMessage = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(85, 52);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(166, 84);
            this.txtMessage.TabIndex = 0;
            // 
            // lblPostMessage
            // 
            this.lblPostMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostMessage.Location = new System.Drawing.Point(109, 226);
            this.lblPostMessage.Name = "lblPostMessage";
            this.lblPostMessage.Size = new System.Drawing.Size(120, 20);
            this.lblPostMessage.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPost.Location = new System.Drawing.Point(131, 180);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCounter.Location = new System.Drawing.Point(121, 148);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(96, 20);
            this.lblCounter.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 330);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblPostMessage);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblPostMessage;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblCounter;
    }
}


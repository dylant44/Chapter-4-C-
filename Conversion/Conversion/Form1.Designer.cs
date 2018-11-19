namespace Conversion
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
            this.txtTemp8 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblCelsius8Title = new System.Windows.Forms.Label();
            this.lblCelsius12Title = new System.Windows.Forms.Label();
            this.lblCelsius5Title = new System.Windows.Forms.Label();
            this.txtTemp12 = new System.Windows.Forms.TextBox();
            this.txtTemp5 = new System.Windows.Forms.TextBox();
            this.lblFahrenheit8 = new System.Windows.Forms.Label();
            this.lblFahrenheit12 = new System.Windows.Forms.Label();
            this.lblFahrenheit5 = new System.Windows.Forms.Label();
            this.lblResult8 = new System.Windows.Forms.Label();
            this.lblResult12 = new System.Windows.Forms.Label();
            this.lblResult5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(117, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter The Temperatures In Celcius To Convert";
            // 
            // txtTemp8
            // 
            this.txtTemp8.Location = new System.Drawing.Point(284, 85);
            this.txtTemp8.Name = "txtTemp8";
            this.txtTemp8.Size = new System.Drawing.Size(100, 20);
            this.txtTemp8.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(112, 214);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(121, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert To Fahrenheit";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblCelsius8Title
            // 
            this.lblCelsius8Title.AutoSize = true;
            this.lblCelsius8Title.Location = new System.Drawing.Point(117, 92);
            this.lblCelsius8Title.Name = "lblCelsius8Title";
            this.lblCelsius8Title.Size = new System.Drawing.Size(70, 13);
            this.lblCelsius8Title.TabIndex = 3;
            this.lblCelsius8Title.Text = "Temp at 8:00";
            // 
            // lblCelsius12Title
            // 
            this.lblCelsius12Title.AutoSize = true;
            this.lblCelsius12Title.Location = new System.Drawing.Point(117, 128);
            this.lblCelsius12Title.Name = "lblCelsius12Title";
            this.lblCelsius12Title.Size = new System.Drawing.Size(76, 13);
            this.lblCelsius12Title.TabIndex = 4;
            this.lblCelsius12Title.Text = "Temp at 12:00";
            // 
            // lblCelsius5Title
            // 
            this.lblCelsius5Title.AutoSize = true;
            this.lblCelsius5Title.Location = new System.Drawing.Point(117, 168);
            this.lblCelsius5Title.Name = "lblCelsius5Title";
            this.lblCelsius5Title.Size = new System.Drawing.Size(70, 13);
            this.lblCelsius5Title.TabIndex = 5;
            this.lblCelsius5Title.Text = "Temp at 5:00";
            // 
            // txtTemp12
            // 
            this.txtTemp12.Location = new System.Drawing.Point(284, 121);
            this.txtTemp12.Name = "txtTemp12";
            this.txtTemp12.Size = new System.Drawing.Size(100, 20);
            this.txtTemp12.TabIndex = 6;
            // 
            // txtTemp5
            // 
            this.txtTemp5.Location = new System.Drawing.Point(284, 161);
            this.txtTemp5.Name = "txtTemp5";
            this.txtTemp5.Size = new System.Drawing.Size(100, 20);
            this.txtTemp5.TabIndex = 7;
            // 
            // lblFahrenheit8
            // 
            this.lblFahrenheit8.AutoSize = true;
            this.lblFahrenheit8.Location = new System.Drawing.Point(117, 272);
            this.lblFahrenheit8.Name = "lblFahrenheit8";
            this.lblFahrenheit8.Size = new System.Drawing.Size(70, 13);
            this.lblFahrenheit8.TabIndex = 8;
            this.lblFahrenheit8.Text = "Temp at 8:00";
            // 
            // lblFahrenheit12
            // 
            this.lblFahrenheit12.AutoSize = true;
            this.lblFahrenheit12.Location = new System.Drawing.Point(117, 312);
            this.lblFahrenheit12.Name = "lblFahrenheit12";
            this.lblFahrenheit12.Size = new System.Drawing.Size(76, 13);
            this.lblFahrenheit12.TabIndex = 9;
            this.lblFahrenheit12.Text = "Temp at 12:00";
            // 
            // lblFahrenheit5
            // 
            this.lblFahrenheit5.AutoSize = true;
            this.lblFahrenheit5.Location = new System.Drawing.Point(117, 347);
            this.lblFahrenheit5.Name = "lblFahrenheit5";
            this.lblFahrenheit5.Size = new System.Drawing.Size(70, 13);
            this.lblFahrenheit5.TabIndex = 10;
            this.lblFahrenheit5.Text = "Temp at 5:00";
            // 
            // lblResult8
            // 
            this.lblResult8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult8.Location = new System.Drawing.Point(281, 272);
            this.lblResult8.Name = "lblResult8";
            this.lblResult8.Size = new System.Drawing.Size(100, 23);
            this.lblResult8.TabIndex = 11;
            this.lblResult8.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResult12
            // 
            this.lblResult12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult12.Location = new System.Drawing.Point(281, 303);
            this.lblResult12.Name = "lblResult12";
            this.lblResult12.Size = new System.Drawing.Size(100, 22);
            this.lblResult12.TabIndex = 12;
            // 
            // lblResult5
            // 
            this.lblResult5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult5.Location = new System.Drawing.Point(281, 338);
            this.lblResult5.Name = "lblResult5";
            this.lblResult5.Size = new System.Drawing.Size(100, 22);
            this.lblResult5.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult5);
            this.Controls.Add(this.lblResult12);
            this.Controls.Add(this.lblResult8);
            this.Controls.Add(this.lblFahrenheit5);
            this.Controls.Add(this.lblFahrenheit12);
            this.Controls.Add(this.lblFahrenheit8);
            this.Controls.Add(this.txtTemp5);
            this.Controls.Add(this.txtTemp12);
            this.Controls.Add(this.lblCelsius5Title);
            this.Controls.Add(this.lblCelsius12Title);
            this.Controls.Add(this.lblCelsius8Title);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtTemp8);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTemp8;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblCelsius8Title;
        private System.Windows.Forms.Label lblCelsius12Title;
        private System.Windows.Forms.Label lblCelsius5Title;
        private System.Windows.Forms.TextBox txtTemp12;
        private System.Windows.Forms.TextBox txtTemp5;
        private System.Windows.Forms.Label lblFahrenheit8;
        private System.Windows.Forms.Label lblFahrenheit12;
        private System.Windows.Forms.Label lblFahrenheit5;
        private System.Windows.Forms.Label lblResult8;
        private System.Windows.Forms.Label lblResult12;
        private System.Windows.Forms.Label lblResult5;
    }
}


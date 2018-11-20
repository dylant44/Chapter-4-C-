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
            this.btnFahrenheitConversion = new System.Windows.Forms.Button();
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
            this.lblAverageFahrenheit = new System.Windows.Forms.Label();
            this.lblResultAverageFah = new System.Windows.Forms.Label();
            this.lblTitleCel8 = new System.Windows.Forms.Label();
            this.lblTitleCel12 = new System.Windows.Forms.Label();
            this.lblTitleCel5 = new System.Windows.Forms.Label();
            this.lblAverageCel = new System.Windows.Forms.Label();
            this.lblResultCel8 = new System.Windows.Forms.Label();
            this.lblResultCel12 = new System.Windows.Forms.Label();
            this.lblResultCel5 = new System.Windows.Forms.Label();
            this.lblResultAverageCel = new System.Windows.Forms.Label();
            this.btnCelsiusConversion = new System.Windows.Forms.Button();
            this.lblMessageF1 = new System.Windows.Forms.Label();
            this.lblMessageF2 = new System.Windows.Forms.Label();
            this.lblMessageF3 = new System.Windows.Forms.Label();
            this.lblMessageC1 = new System.Windows.Forms.Label();
            this.lblMessageC2 = new System.Windows.Forms.Label();
            this.lblMessageC3 = new System.Windows.Forms.Label();
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
            // btnFahrenheitConversion
            // 
            this.btnFahrenheitConversion.Location = new System.Drawing.Point(48, 240);
            this.btnFahrenheitConversion.Name = "btnFahrenheitConversion";
            this.btnFahrenheitConversion.Size = new System.Drawing.Size(121, 23);
            this.btnFahrenheitConversion.TabIndex = 2;
            this.btnFahrenheitConversion.Text = "Convert To Fahrenheit";
            this.btnFahrenheitConversion.UseVisualStyleBackColor = true;
            this.btnFahrenheitConversion.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblCelsius8Title
            // 
            this.lblCelsius8Title.AutoSize = true;
            this.lblCelsius8Title.Location = new System.Drawing.Point(117, 92);
            this.lblCelsius8Title.Name = "lblCelsius8Title";
            this.lblCelsius8Title.Size = new System.Drawing.Size(118, 13);
            this.lblCelsius8Title.TabIndex = 3;
            this.lblCelsius8Title.Text = "Temp at 8:00 in Celcius";
            // 
            // lblCelsius12Title
            // 
            this.lblCelsius12Title.AutoSize = true;
            this.lblCelsius12Title.Location = new System.Drawing.Point(117, 128);
            this.lblCelsius12Title.Name = "lblCelsius12Title";
            this.lblCelsius12Title.Size = new System.Drawing.Size(124, 13);
            this.lblCelsius12Title.TabIndex = 4;
            this.lblCelsius12Title.Text = "Temp at 12:00 in Celcius";
            // 
            // lblCelsius5Title
            // 
            this.lblCelsius5Title.AutoSize = true;
            this.lblCelsius5Title.Location = new System.Drawing.Point(117, 168);
            this.lblCelsius5Title.Name = "lblCelsius5Title";
            this.lblCelsius5Title.Size = new System.Drawing.Size(118, 13);
            this.lblCelsius5Title.TabIndex = 5;
            this.lblCelsius5Title.Text = "Temp at 5:00 in Celcius";
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
            this.lblFahrenheit8.Location = new System.Drawing.Point(45, 272);
            this.lblFahrenheit8.Name = "lblFahrenheit8";
            this.lblFahrenheit8.Size = new System.Drawing.Size(134, 13);
            this.lblFahrenheit8.TabIndex = 8;
            this.lblFahrenheit8.Text = "Temp at 8:00 in Fahrenheit";
            this.lblFahrenheit8.Visible = false;
            // 
            // lblFahrenheit12
            // 
            this.lblFahrenheit12.AutoSize = true;
            this.lblFahrenheit12.Location = new System.Drawing.Point(45, 303);
            this.lblFahrenheit12.Name = "lblFahrenheit12";
            this.lblFahrenheit12.Size = new System.Drawing.Size(140, 13);
            this.lblFahrenheit12.TabIndex = 9;
            this.lblFahrenheit12.Text = "Temp at 12:00 in Fahrenheit";
            this.lblFahrenheit12.Visible = false;
            // 
            // lblFahrenheit5
            // 
            this.lblFahrenheit5.AutoSize = true;
            this.lblFahrenheit5.Location = new System.Drawing.Point(45, 338);
            this.lblFahrenheit5.Name = "lblFahrenheit5";
            this.lblFahrenheit5.Size = new System.Drawing.Size(134, 13);
            this.lblFahrenheit5.TabIndex = 10;
            this.lblFahrenheit5.Text = "Temp at 5:00 in Fahrenheit";
            this.lblFahrenheit5.Visible = false;
            // 
            // lblResult8
            // 
            this.lblResult8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult8.Location = new System.Drawing.Point(216, 271);
            this.lblResult8.Name = "lblResult8";
            this.lblResult8.Size = new System.Drawing.Size(103, 23);
            this.lblResult8.TabIndex = 11;
            this.lblResult8.Visible = false;
            // 
            // lblResult12
            // 
            this.lblResult12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult12.Location = new System.Drawing.Point(216, 302);
            this.lblResult12.Name = "lblResult12";
            this.lblResult12.Size = new System.Drawing.Size(103, 22);
            this.lblResult12.TabIndex = 12;
            this.lblResult12.Visible = false;
            // 
            // lblResult5
            // 
            this.lblResult5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult5.Location = new System.Drawing.Point(216, 337);
            this.lblResult5.Name = "lblResult5";
            this.lblResult5.Size = new System.Drawing.Size(103, 22);
            this.lblResult5.TabIndex = 13;
            this.lblResult5.Visible = false;
            // 
            // lblAverageFahrenheit
            // 
            this.lblAverageFahrenheit.AutoSize = true;
            this.lblAverageFahrenheit.Location = new System.Drawing.Point(45, 372);
            this.lblAverageFahrenheit.Name = "lblAverageFahrenheit";
            this.lblAverageFahrenheit.Size = new System.Drawing.Size(141, 13);
            this.lblAverageFahrenheit.TabIndex = 14;
            this.lblAverageFahrenheit.Text = "Average Temp in Fahrenheit";
            this.lblAverageFahrenheit.Visible = false;
            // 
            // lblResultAverageFah
            // 
            this.lblResultAverageFah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultAverageFah.Location = new System.Drawing.Point(216, 371);
            this.lblResultAverageFah.Name = "lblResultAverageFah";
            this.lblResultAverageFah.Size = new System.Drawing.Size(103, 22);
            this.lblResultAverageFah.TabIndex = 15;
            this.lblResultAverageFah.Visible = false;
            // 
            // lblTitleCel8
            // 
            this.lblTitleCel8.AutoSize = true;
            this.lblTitleCel8.Location = new System.Drawing.Point(465, 282);
            this.lblTitleCel8.Name = "lblTitleCel8";
            this.lblTitleCel8.Size = new System.Drawing.Size(53, 13);
            this.lblTitleCel8.TabIndex = 16;
            this.lblTitleCel8.Text = "In Celcius";
            this.lblTitleCel8.Visible = false;
            // 
            // lblTitleCel12
            // 
            this.lblTitleCel12.AutoSize = true;
            this.lblTitleCel12.Location = new System.Drawing.Point(466, 312);
            this.lblTitleCel12.Name = "lblTitleCel12";
            this.lblTitleCel12.Size = new System.Drawing.Size(52, 13);
            this.lblTitleCel12.TabIndex = 17;
            this.lblTitleCel12.Text = "In Celsius";
            this.lblTitleCel12.Visible = false;
            // 
            // lblTitleCel5
            // 
            this.lblTitleCel5.AutoSize = true;
            this.lblTitleCel5.Location = new System.Drawing.Point(466, 347);
            this.lblTitleCel5.Name = "lblTitleCel5";
            this.lblTitleCel5.Size = new System.Drawing.Size(52, 13);
            this.lblTitleCel5.TabIndex = 18;
            this.lblTitleCel5.Text = "In Celsius";
            this.lblTitleCel5.Visible = false;
            // 
            // lblAverageCel
            // 
            this.lblAverageCel.AutoSize = true;
            this.lblAverageCel.Location = new System.Drawing.Point(465, 381);
            this.lblAverageCel.Name = "lblAverageCel";
            this.lblAverageCel.Size = new System.Drawing.Size(52, 13);
            this.lblAverageCel.TabIndex = 19;
            this.lblAverageCel.Text = "In Celsius";
            this.lblAverageCel.Visible = false;
            // 
            // lblResultCel8
            // 
            this.lblResultCel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultCel8.Location = new System.Drawing.Point(543, 272);
            this.lblResultCel8.Name = "lblResultCel8";
            this.lblResultCel8.Size = new System.Drawing.Size(110, 23);
            this.lblResultCel8.TabIndex = 20;
            this.lblResultCel8.Visible = false;
            // 
            // lblResultCel12
            // 
            this.lblResultCel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultCel12.Location = new System.Drawing.Point(543, 302);
            this.lblResultCel12.Name = "lblResultCel12";
            this.lblResultCel12.Size = new System.Drawing.Size(110, 22);
            this.lblResultCel12.TabIndex = 21;
            this.lblResultCel12.Visible = false;
            // 
            // lblResultCel5
            // 
            this.lblResultCel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultCel5.Location = new System.Drawing.Point(543, 337);
            this.lblResultCel5.Name = "lblResultCel5";
            this.lblResultCel5.Size = new System.Drawing.Size(110, 22);
            this.lblResultCel5.TabIndex = 22;
            this.lblResultCel5.Visible = false;
            // 
            // lblResultAverageCel
            // 
            this.lblResultAverageCel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultAverageCel.Location = new System.Drawing.Point(543, 371);
            this.lblResultAverageCel.Name = "lblResultAverageCel";
            this.lblResultAverageCel.Size = new System.Drawing.Size(110, 22);
            this.lblResultAverageCel.TabIndex = 23;
            this.lblResultAverageCel.Visible = false;
            // 
            // btnCelsiusConversion
            // 
            this.btnCelsiusConversion.Location = new System.Drawing.Point(451, 240);
            this.btnCelsiusConversion.Name = "btnCelsiusConversion";
            this.btnCelsiusConversion.Size = new System.Drawing.Size(107, 23);
            this.btnCelsiusConversion.TabIndex = 24;
            this.btnCelsiusConversion.Text = "Convert To Celsius";
            this.btnCelsiusConversion.UseVisualStyleBackColor = true;
            this.btnCelsiusConversion.Click += new System.EventHandler(this.btnCelsiusConversion_Click);
            // 
            // lblMessageF1
            // 
            this.lblMessageF1.Location = new System.Drawing.Point(340, 271);
            this.lblMessageF1.Name = "lblMessageF1";
            this.lblMessageF1.Size = new System.Drawing.Size(100, 23);
            this.lblMessageF1.TabIndex = 25;
            // 
            // lblMessageF2
            // 
            this.lblMessageF2.Location = new System.Drawing.Point(340, 303);
            this.lblMessageF2.Name = "lblMessageF2";
            this.lblMessageF2.Size = new System.Drawing.Size(100, 21);
            this.lblMessageF2.TabIndex = 26;
            // 
            // lblMessageF3
            // 
            this.lblMessageF3.Location = new System.Drawing.Point(340, 337);
            this.lblMessageF3.Name = "lblMessageF3";
            this.lblMessageF3.Size = new System.Drawing.Size(100, 23);
            this.lblMessageF3.TabIndex = 27;
            // 
            // lblMessageC1
            // 
            this.lblMessageC1.Location = new System.Drawing.Point(670, 281);
            this.lblMessageC1.Name = "lblMessageC1";
            this.lblMessageC1.Size = new System.Drawing.Size(35, 13);
            this.lblMessageC1.TabIndex = 28;
            // 
            // lblMessageC2
            // 
            this.lblMessageC2.Location = new System.Drawing.Point(670, 303);
            this.lblMessageC2.Name = "lblMessageC2";
            this.lblMessageC2.Size = new System.Drawing.Size(35, 13);
            this.lblMessageC2.TabIndex = 29;
            // 
            // lblMessageC3
            // 
            this.lblMessageC3.Location = new System.Drawing.Point(670, 338);
            this.lblMessageC3.Name = "lblMessageC3";
            this.lblMessageC3.Size = new System.Drawing.Size(35, 13);
            this.lblMessageC3.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessageC3);
            this.Controls.Add(this.lblMessageC2);
            this.Controls.Add(this.lblMessageC1);
            this.Controls.Add(this.lblMessageF3);
            this.Controls.Add(this.lblMessageF2);
            this.Controls.Add(this.lblMessageF1);
            this.Controls.Add(this.btnCelsiusConversion);
            this.Controls.Add(this.lblResultAverageCel);
            this.Controls.Add(this.lblResultCel5);
            this.Controls.Add(this.lblResultCel12);
            this.Controls.Add(this.lblResultCel8);
            this.Controls.Add(this.lblAverageCel);
            this.Controls.Add(this.lblTitleCel5);
            this.Controls.Add(this.lblTitleCel12);
            this.Controls.Add(this.lblTitleCel8);
            this.Controls.Add(this.lblResultAverageFah);
            this.Controls.Add(this.lblAverageFahrenheit);
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
            this.Controls.Add(this.btnFahrenheitConversion);
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
        private System.Windows.Forms.Button btnFahrenheitConversion;
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
        private System.Windows.Forms.Label lblAverageFahrenheit;
        private System.Windows.Forms.Label lblResultAverageFah;
        private System.Windows.Forms.Label lblTitleCel8;
        private System.Windows.Forms.Label lblTitleCel12;
        private System.Windows.Forms.Label lblTitleCel5;
        private System.Windows.Forms.Label lblAverageCel;
        private System.Windows.Forms.Label lblResultCel8;
        private System.Windows.Forms.Label lblResultCel12;
        private System.Windows.Forms.Label lblResultCel5;
        private System.Windows.Forms.Label lblResultAverageCel;
        private System.Windows.Forms.Button btnCelsiusConversion;
        private System.Windows.Forms.Label lblMessageF1;
        private System.Windows.Forms.Label lblMessageF2;
        private System.Windows.Forms.Label lblMessageF3;
        private System.Windows.Forms.Label lblMessageC1;
        private System.Windows.Forms.Label lblMessageC2;
        private System.Windows.Forms.Label lblMessageC3;
    }
}


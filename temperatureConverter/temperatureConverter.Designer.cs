namespace temperatureConverter
{
    partial class temperatureConverterForm
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
            this.inputTemperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.degreesLabel1 = new System.Windows.Forms.Label();
            this.convertToGroupBox = new System.Windows.Forms.GroupBox();
            this.celsiusRadioButton = new System.Windows.Forms.RadioButton();
            this.fahrenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.outputTemperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.degreesLabel3 = new System.Windows.Forms.Label();
            this.degreesLabel2 = new System.Windows.Forms.Label();
            this.temperatureInCelsiusTextBox = new System.Windows.Forms.TextBox();
            this.temperatureInFahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.temperatureCelsiusLabel = new System.Windows.Forms.Label();
            this.temperatureFahrenheitLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.inputTemperatureGroupBox.SuspendLayout();
            this.convertToGroupBox.SuspendLayout();
            this.outputTemperatureGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTemperatureGroupBox
            // 
            this.inputTemperatureGroupBox.Controls.Add(this.temperatureTextBox);
            this.inputTemperatureGroupBox.Controls.Add(this.temperatureLabel);
            this.inputTemperatureGroupBox.Controls.Add(this.degreesLabel1);
            this.inputTemperatureGroupBox.Location = new System.Drawing.Point(40, 62);
            this.inputTemperatureGroupBox.Name = "inputTemperatureGroupBox";
            this.inputTemperatureGroupBox.Size = new System.Drawing.Size(520, 100);
            this.inputTemperatureGroupBox.TabIndex = 0;
            this.inputTemperatureGroupBox.TabStop = false;
            this.inputTemperatureGroupBox.Text = "Input Temperature";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(115, 33);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(146, 20);
            this.temperatureTextBox.TabIndex = 1;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(33, 36);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(76, 13);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "&Temperature : ";
            // 
            // degreesLabel1
            // 
            this.degreesLabel1.AutoSize = true;
            this.degreesLabel1.Location = new System.Drawing.Point(267, 36);
            this.degreesLabel1.Name = "degreesLabel1";
            this.degreesLabel1.Size = new System.Drawing.Size(45, 13);
            this.degreesLabel1.TabIndex = 2;
            this.degreesLabel1.Text = "degrees";
            // 
            // convertToGroupBox
            // 
            this.convertToGroupBox.Controls.Add(this.celsiusRadioButton);
            this.convertToGroupBox.Controls.Add(this.fahrenheitRadioButton);
            this.convertToGroupBox.Location = new System.Drawing.Point(40, 180);
            this.convertToGroupBox.Name = "convertToGroupBox";
            this.convertToGroupBox.Size = new System.Drawing.Size(520, 100);
            this.convertToGroupBox.TabIndex = 1;
            this.convertToGroupBox.TabStop = false;
            this.convertToGroupBox.Text = "Convert To";
            // 
            // celsiusRadioButton
            // 
            this.celsiusRadioButton.AutoSize = true;
            this.celsiusRadioButton.Location = new System.Drawing.Point(36, 30);
            this.celsiusRadioButton.Name = "celsiusRadioButton";
            this.celsiusRadioButton.Size = new System.Drawing.Size(58, 17);
            this.celsiusRadioButton.TabIndex = 0;
            this.celsiusRadioButton.TabStop = true;
            this.celsiusRadioButton.Text = "&Celsius";
            this.celsiusRadioButton.UseVisualStyleBackColor = true;
            this.celsiusRadioButton.CheckedChanged += new System.EventHandler(this.changedRadioButton_CheckedChanged);
            // 
            // fahrenheitRadioButton
            // 
            this.fahrenheitRadioButton.AutoSize = true;
            this.fahrenheitRadioButton.Location = new System.Drawing.Point(36, 65);
            this.fahrenheitRadioButton.Name = "fahrenheitRadioButton";
            this.fahrenheitRadioButton.Size = new System.Drawing.Size(75, 17);
            this.fahrenheitRadioButton.TabIndex = 1;
            this.fahrenheitRadioButton.TabStop = true;
            this.fahrenheitRadioButton.Text = "&Fahrenheit";
            this.fahrenheitRadioButton.UseVisualStyleBackColor = true;
            this.fahrenheitRadioButton.CheckedChanged += new System.EventHandler(this.changedRadioButton_CheckedChanged);
            // 
            // outputTemperatureGroupBox
            // 
            this.outputTemperatureGroupBox.Controls.Add(this.degreesLabel3);
            this.outputTemperatureGroupBox.Controls.Add(this.degreesLabel2);
            this.outputTemperatureGroupBox.Controls.Add(this.temperatureInCelsiusTextBox);
            this.outputTemperatureGroupBox.Controls.Add(this.temperatureInFahrenheitTextBox);
            this.outputTemperatureGroupBox.Controls.Add(this.temperatureCelsiusLabel);
            this.outputTemperatureGroupBox.Controls.Add(this.temperatureFahrenheitLabel);
            this.outputTemperatureGroupBox.Location = new System.Drawing.Point(40, 298);
            this.outputTemperatureGroupBox.Name = "outputTemperatureGroupBox";
            this.outputTemperatureGroupBox.Size = new System.Drawing.Size(520, 97);
            this.outputTemperatureGroupBox.TabIndex = 7;
            this.outputTemperatureGroupBox.TabStop = false;
            this.outputTemperatureGroupBox.Text = "Output Temperature";
            // 
            // degreesLabel3
            // 
            this.degreesLabel3.AutoSize = true;
            this.degreesLabel3.Location = new System.Drawing.Point(338, 63);
            this.degreesLabel3.Name = "degreesLabel3";
            this.degreesLabel3.Size = new System.Drawing.Size(45, 13);
            this.degreesLabel3.TabIndex = 12;
            this.degreesLabel3.Text = "degrees";
            // 
            // degreesLabel2
            // 
            this.degreesLabel2.AutoSize = true;
            this.degreesLabel2.Location = new System.Drawing.Point(338, 30);
            this.degreesLabel2.Name = "degreesLabel2";
            this.degreesLabel2.Size = new System.Drawing.Size(45, 13);
            this.degreesLabel2.TabIndex = 2;
            this.degreesLabel2.Text = "degrees";
            // 
            // temperatureInCelsiusTextBox
            // 
            this.temperatureInCelsiusTextBox.Location = new System.Drawing.Point(179, 27);
            this.temperatureInCelsiusTextBox.Name = "temperatureInCelsiusTextBox";
            this.temperatureInCelsiusTextBox.ReadOnly = true;
            this.temperatureInCelsiusTextBox.Size = new System.Drawing.Size(153, 20);
            this.temperatureInCelsiusTextBox.TabIndex = 1;
            this.temperatureInCelsiusTextBox.TabStop = false;
            // 
            // temperatureInFahrenheitTextBox
            // 
            this.temperatureInFahrenheitTextBox.Location = new System.Drawing.Point(179, 60);
            this.temperatureInFahrenheitTextBox.Name = "temperatureInFahrenheitTextBox";
            this.temperatureInFahrenheitTextBox.ReadOnly = true;
            this.temperatureInFahrenheitTextBox.Size = new System.Drawing.Size(153, 20);
            this.temperatureInFahrenheitTextBox.TabIndex = 3;
            this.temperatureInFahrenheitTextBox.TabStop = false;
            // 
            // temperatureCelsiusLabel
            // 
            this.temperatureCelsiusLabel.AutoSize = true;
            this.temperatureCelsiusLabel.Location = new System.Drawing.Point(33, 34);
            this.temperatureCelsiusLabel.Name = "temperatureCelsiusLabel";
            this.temperatureCelsiusLabel.Size = new System.Drawing.Size(123, 13);
            this.temperatureCelsiusLabel.TabIndex = 0;
            this.temperatureCelsiusLabel.Text = "Temperature in Celsius : ";
            // 
            // temperatureFahrenheitLabel
            // 
            this.temperatureFahrenheitLabel.AutoSize = true;
            this.temperatureFahrenheitLabel.Location = new System.Drawing.Point(33, 63);
            this.temperatureFahrenheitLabel.Name = "temperatureFahrenheitLabel";
            this.temperatureFahrenheitLabel.Size = new System.Drawing.Size(140, 13);
            this.temperatureFahrenheitLabel.TabIndex = 1;
            this.temperatureFahrenheitLabel.Text = "Temperature in Fahrenheit : ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(179, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(236, 25);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Temperature Converter";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(441, 465);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(141, 22);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Blake Murdock";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(76, 424);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "C&onvert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(260, 424);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(444, 424);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // temperatureConverterForm
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(594, 496);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.convertToGroupBox);
            this.Controls.Add(this.outputTemperatureGroupBox);
            this.Controls.Add(this.inputTemperatureGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "temperatureConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.temperatureConverterForm_Load);
            this.inputTemperatureGroupBox.ResumeLayout(false);
            this.inputTemperatureGroupBox.PerformLayout();
            this.convertToGroupBox.ResumeLayout(false);
            this.convertToGroupBox.PerformLayout();
            this.outputTemperatureGroupBox.ResumeLayout(false);
            this.outputTemperatureGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputTemperatureGroupBox;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label degreesLabel1;
        private System.Windows.Forms.GroupBox convertToGroupBox;
        private System.Windows.Forms.RadioButton celsiusRadioButton;
        private System.Windows.Forms.RadioButton fahrenheitRadioButton;
        private System.Windows.Forms.GroupBox outputTemperatureGroupBox;
        private System.Windows.Forms.Label degreesLabel3;
        private System.Windows.Forms.Label degreesLabel2;
        private System.Windows.Forms.TextBox temperatureInCelsiusTextBox;
        private System.Windows.Forms.TextBox temperatureInFahrenheitTextBox;
        private System.Windows.Forms.Label temperatureCelsiusLabel;
        private System.Windows.Forms.Label temperatureFahrenheitLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}


namespace ColorMixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstColorGroupBox = new System.Windows.Forms.GroupBox();
            this.firstRedRadioButton = new System.Windows.Forms.RadioButton();
            this.firstBlueRadioButton = new System.Windows.Forms.RadioButton();
            this.firstYellowRadioButton = new System.Windows.Forms.RadioButton();
            this.secondColorGroupBox = new System.Windows.Forms.GroupBox();
            this.secondYellowRadioButton = new System.Windows.Forms.RadioButton();
            this.secondBlueRadioButton = new System.Windows.Forms.RadioButton();
            this.secondRedRadioButton = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstColorGroupBox.SuspendLayout();
            this.secondColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstColorGroupBox
            // 
            this.firstColorGroupBox.Controls.Add(this.firstYellowRadioButton);
            this.firstColorGroupBox.Controls.Add(this.firstBlueRadioButton);
            this.firstColorGroupBox.Controls.Add(this.firstRedRadioButton);
            this.firstColorGroupBox.Location = new System.Drawing.Point(21, 48);
            this.firstColorGroupBox.Name = "firstColorGroupBox";
            this.firstColorGroupBox.Size = new System.Drawing.Size(218, 242);
            this.firstColorGroupBox.TabIndex = 0;
            this.firstColorGroupBox.TabStop = false;
            this.firstColorGroupBox.Text = "Select the first color";
            // 
            // firstRedRadioButton
            // 
            this.firstRedRadioButton.AutoSize = true;
            this.firstRedRadioButton.Checked = true;
            this.firstRedRadioButton.Location = new System.Drawing.Point(44, 62);
            this.firstRedRadioButton.Name = "firstRedRadioButton";
            this.firstRedRadioButton.Size = new System.Drawing.Size(45, 17);
            this.firstRedRadioButton.TabIndex = 0;
            this.firstRedRadioButton.TabStop = true;
            this.firstRedRadioButton.Text = "Red";
            this.firstRedRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstBlueRadioButton
            // 
            this.firstBlueRadioButton.AutoSize = true;
            this.firstBlueRadioButton.Location = new System.Drawing.Point(44, 119);
            this.firstBlueRadioButton.Name = "firstBlueRadioButton";
            this.firstBlueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.firstBlueRadioButton.TabIndex = 1;
            this.firstBlueRadioButton.TabStop = true;
            this.firstBlueRadioButton.Text = "Blue";
            this.firstBlueRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstYellowRadioButton
            // 
            this.firstYellowRadioButton.AutoSize = true;
            this.firstYellowRadioButton.Location = new System.Drawing.Point(44, 173);
            this.firstYellowRadioButton.Name = "firstYellowRadioButton";
            this.firstYellowRadioButton.Size = new System.Drawing.Size(56, 17);
            this.firstYellowRadioButton.TabIndex = 2;
            this.firstYellowRadioButton.TabStop = true;
            this.firstYellowRadioButton.Text = "Yellow";
            this.firstYellowRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondColorGroupBox
            // 
            this.secondColorGroupBox.Controls.Add(this.secondYellowRadioButton);
            this.secondColorGroupBox.Controls.Add(this.secondBlueRadioButton);
            this.secondColorGroupBox.Controls.Add(this.secondRedRadioButton);
            this.secondColorGroupBox.Location = new System.Drawing.Point(378, 48);
            this.secondColorGroupBox.Name = "secondColorGroupBox";
            this.secondColorGroupBox.Size = new System.Drawing.Size(218, 242);
            this.secondColorGroupBox.TabIndex = 3;
            this.secondColorGroupBox.TabStop = false;
            this.secondColorGroupBox.Text = "Select the second color";
            // 
            // secondYellowRadioButton
            // 
            this.secondYellowRadioButton.AutoSize = true;
            this.secondYellowRadioButton.Location = new System.Drawing.Point(44, 173);
            this.secondYellowRadioButton.Name = "secondYellowRadioButton";
            this.secondYellowRadioButton.Size = new System.Drawing.Size(56, 17);
            this.secondYellowRadioButton.TabIndex = 2;
            this.secondYellowRadioButton.TabStop = true;
            this.secondYellowRadioButton.Text = "Yellow";
            this.secondYellowRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondBlueRadioButton
            // 
            this.secondBlueRadioButton.AutoSize = true;
            this.secondBlueRadioButton.Location = new System.Drawing.Point(44, 119);
            this.secondBlueRadioButton.Name = "secondBlueRadioButton";
            this.secondBlueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.secondBlueRadioButton.TabIndex = 1;
            this.secondBlueRadioButton.TabStop = true;
            this.secondBlueRadioButton.Text = "Blue";
            this.secondBlueRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondRedRadioButton
            // 
            this.secondRedRadioButton.AutoSize = true;
            this.secondRedRadioButton.Checked = true;
            this.secondRedRadioButton.Location = new System.Drawing.Point(44, 62);
            this.secondRedRadioButton.Name = "secondRedRadioButton";
            this.secondRedRadioButton.Size = new System.Drawing.Size(45, 17);
            this.secondRedRadioButton.TabIndex = 0;
            this.secondRedRadioButton.TabStop = true;
            this.secondRedRadioButton.Text = "Red";
            this.secondRedRadioButton.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(256, 110);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(101, 23);
            this.mixButton.TabIndex = 4;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(256, 221);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 386);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.secondColorGroupBox);
            this.Controls.Add(this.firstColorGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Color Mixer Application";
            this.firstColorGroupBox.ResumeLayout(false);
            this.firstColorGroupBox.PerformLayout();
            this.secondColorGroupBox.ResumeLayout(false);
            this.secondColorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox firstColorGroupBox;
        private System.Windows.Forms.RadioButton firstRedRadioButton;
        private System.Windows.Forms.RadioButton firstYellowRadioButton;
        private System.Windows.Forms.RadioButton firstBlueRadioButton;
        private System.Windows.Forms.GroupBox secondColorGroupBox;
        private System.Windows.Forms.RadioButton secondYellowRadioButton;
        private System.Windows.Forms.RadioButton secondBlueRadioButton;
        private System.Windows.Forms.RadioButton secondRedRadioButton;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}


namespace Tut4_1_TestScoreAverage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.test1Label = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test2Label = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test3Label = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.calcAvgButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.averageTextBox);
            this.groupBox1.Controls.Add(this.averageLabel);
            this.groupBox1.Controls.Add(this.test3TextBox);
            this.groupBox1.Controls.Add(this.test3Label);
            this.groupBox1.Controls.Add(this.test2TextBox);
            this.groupBox1.Controls.Add(this.test2Label);
            this.groupBox1.Controls.Add(this.test1TextBox);
            this.groupBox1.Controls.Add(this.test1Label);
            this.groupBox1.Location = new System.Drawing.Point(65, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter three test scores:";
            // 
            // test1Label
            // 
            this.test1Label.AutoSize = true;
            this.test1Label.Location = new System.Drawing.Point(49, 73);
            this.test1Label.Name = "test1Label";
            this.test1Label.Size = new System.Drawing.Size(149, 25);
            this.test1Label.TabIndex = 0;
            this.test1Label.Text = "Test score #1:";
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(231, 73);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(131, 31);
            this.test1TextBox.TabIndex = 1;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(231, 129);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(131, 31);
            this.test2TextBox.TabIndex = 3;
            // 
            // test2Label
            // 
            this.test2Label.AutoSize = true;
            this.test2Label.Location = new System.Drawing.Point(49, 129);
            this.test2Label.Name = "test2Label";
            this.test2Label.Size = new System.Drawing.Size(149, 25);
            this.test2Label.TabIndex = 2;
            this.test2Label.Text = "Test score #2:";
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(231, 191);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(131, 31);
            this.test3TextBox.TabIndex = 5;
            // 
            // test3Label
            // 
            this.test3Label.AutoSize = true;
            this.test3Label.Location = new System.Drawing.Point(49, 191);
            this.test3Label.Name = "test3Label";
            this.test3Label.Size = new System.Drawing.Size(149, 25);
            this.test3Label.TabIndex = 4;
            this.test3Label.Text = "Test score #3:";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(100, 284);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(98, 25);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.Text = "Average:";
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(231, 278);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(131, 31);
            this.averageTextBox.TabIndex = 7;
            // 
            // calcAvgButton
            // 
            this.calcAvgButton.Location = new System.Drawing.Point(119, 458);
            this.calcAvgButton.Name = "calcAvgButton";
            this.calcAvgButton.Size = new System.Drawing.Size(144, 117);
            this.calcAvgButton.TabIndex = 1;
            this.calcAvgButton.Text = "Calculate Average";
            this.calcAvgButton.UseVisualStyleBackColor = true;
            this.calcAvgButton.Click += new System.EventHandler(this.calcAvgButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(296, 458);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 50);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(296, 525);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 613);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcAvgButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Test Score Average";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Label test3Label;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.Label test2Label;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Label test1Label;
        private System.Windows.Forms.Button calcAvgButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}


namespace AccountBalanceCalculator
{
    partial class EndingBalance
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
            this.startingBalanceLabel = new System.Windows.Forms.Label();
            this.startingBalTextBox = new System.Windows.Forms.TextBox();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.monthsLabel = new System.Windows.Forms.Label();
            this.endingBalanceTextBox = new System.Windows.Forms.TextBox();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingBalanceLabel
            // 
            this.startingBalanceLabel.AutoSize = true;
            this.startingBalanceLabel.Location = new System.Drawing.Point(44, 80);
            this.startingBalanceLabel.Name = "startingBalanceLabel";
            this.startingBalanceLabel.Size = new System.Drawing.Size(85, 13);
            this.startingBalanceLabel.TabIndex = 0;
            this.startingBalanceLabel.Text = "Starting Balance";
            // 
            // startingBalTextBox
            // 
            this.startingBalTextBox.Location = new System.Drawing.Point(228, 77);
            this.startingBalTextBox.Name = "startingBalTextBox";
            this.startingBalTextBox.Size = new System.Drawing.Size(100, 20);
            this.startingBalTextBox.TabIndex = 1;
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(228, 118);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthsTextBox.TabIndex = 3;
            // 
            // monthsLabel
            // 
            this.monthsLabel.AutoSize = true;
            this.monthsLabel.Location = new System.Drawing.Point(44, 121);
            this.monthsLabel.Name = "monthsLabel";
            this.monthsLabel.Size = new System.Drawing.Size(94, 13);
            this.monthsLabel.TabIndex = 2;
            this.monthsLabel.Text = "Number of Months";
            // 
            // endingBalanceTextBox
            // 
            this.endingBalanceTextBox.Location = new System.Drawing.Point(228, 158);
            this.endingBalanceTextBox.Name = "endingBalanceTextBox";
            this.endingBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.endingBalanceTextBox.TabIndex = 5;
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.AutoSize = true;
            this.endingBalanceLabel.Location = new System.Drawing.Point(44, 161);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(82, 13);
            this.endingBalanceLabel.TabIndex = 4;
            this.endingBalanceLabel.Text = "Ending Balance";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(47, 206);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(157, 206);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(253, 205);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // EndingBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 324);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endingBalanceTextBox);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.monthsLabel);
            this.Controls.Add(this.startingBalTextBox);
            this.Controls.Add(this.startingBalanceLabel);
            this.Name = "EndingBalance";
            this.Text = "Ending Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingBalanceLabel;
        private System.Windows.Forms.TextBox startingBalTextBox;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.Label monthsLabel;
        private System.Windows.Forms.TextBox endingBalanceTextBox;
        private System.Windows.Forms.Label endingBalanceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}


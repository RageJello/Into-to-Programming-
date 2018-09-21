namespace SalePriceCalculator4
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
            this.originalPricePromptLabel = new System.Windows.Forms.Label();
            this.originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.discPercentagePromptLabel = new System.Windows.Forms.Label();
            this.salePriceLabel = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalPricePromptLabel
            // 
            this.originalPricePromptLabel.AutoSize = true;
            this.originalPricePromptLabel.Location = new System.Drawing.Point(99, 43);
            this.originalPricePromptLabel.Name = "originalPricePromptLabel";
            this.originalPricePromptLabel.Size = new System.Drawing.Size(295, 25);
            this.originalPricePromptLabel.TabIndex = 0;
            this.originalPricePromptLabel.Text = "Enter the item\'s original price:";
            // 
            // originalPriceTextBox
            // 
            this.originalPriceTextBox.Location = new System.Drawing.Point(463, 36);
            this.originalPriceTextBox.Name = "originalPriceTextBox";
            this.originalPriceTextBox.Size = new System.Drawing.Size(100, 31);
            this.originalPriceTextBox.TabIndex = 1;
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.Location = new System.Drawing.Point(463, 100);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(100, 31);
            this.discountPercentageTextBox.TabIndex = 3;
            // 
            // discPercentagePromptLabel
            // 
            this.discPercentagePromptLabel.AutoSize = true;
            this.discPercentagePromptLabel.Location = new System.Drawing.Point(88, 107);
            this.discPercentagePromptLabel.Name = "discPercentagePromptLabel";
            this.discPercentagePromptLabel.Size = new System.Drawing.Size(306, 25);
            this.discPercentagePromptLabel.TabIndex = 2;
            this.discPercentagePromptLabel.Text = "Enter the discount percentage:";
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.Location = new System.Drawing.Point(463, 197);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(100, 31);
            this.salePriceLabel.TabIndex = 4;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(278, 202);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(116, 25);
            this.outputDescriptionLabel.TabIndex = 5;
            this.outputDescriptionLabel.Text = "Sale Price:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(48, 289);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(261, 52);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Sale Price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(348, 289);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(261, 52);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 397);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.discPercentagePromptLabel);
            this.Controls.Add(this.originalPriceTextBox);
            this.Controls.Add(this.originalPricePromptLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalPricePromptLabel;
        private System.Windows.Forms.TextBox originalPriceTextBox;
        private System.Windows.Forms.TextBox discountPercentageTextBox;
        private System.Windows.Forms.Label discPercentagePromptLabel;
        private System.Windows.Forms.TextBox salePriceLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}


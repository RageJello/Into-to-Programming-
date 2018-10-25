namespace CupsToOunces
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
            this.cupsToOuncesLabel = new System.Windows.Forms.Label();
            this.cupsLabel = new System.Windows.Forms.Label();
            this.cupsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesLabel = new System.Windows.Forms.TextBox();
            this.fluidOuncesLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cupsToOuncesLabel
            // 
            this.cupsToOuncesLabel.AutoSize = true;
            this.cupsToOuncesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupsToOuncesLabel.Location = new System.Drawing.Point(12, 22);
            this.cupsToOuncesLabel.Name = "cupsToOuncesLabel";
            this.cupsToOuncesLabel.Size = new System.Drawing.Size(310, 24);
            this.cupsToOuncesLabel.TabIndex = 0;
            this.cupsToOuncesLabel.Text = "Cups to Fluid Ounces Converter";
            // 
            // cupsLabel
            // 
            this.cupsLabel.AutoSize = true;
            this.cupsLabel.Location = new System.Drawing.Point(100, 77);
            this.cupsLabel.Name = "cupsLabel";
            this.cupsLabel.Size = new System.Drawing.Size(34, 13);
            this.cupsLabel.TabIndex = 1;
            this.cupsLabel.Text = "Cups:";
            // 
            // cupsTextBox
            // 
            this.cupsTextBox.Location = new System.Drawing.Point(153, 69);
            this.cupsTextBox.Name = "cupsTextBox";
            this.cupsTextBox.Size = new System.Drawing.Size(100, 20);
            this.cupsTextBox.TabIndex = 2;
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.Location = new System.Drawing.Point(153, 110);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(100, 20);
            this.ouncesLabel.TabIndex = 4;
            // 
            // fluidOuncesLabel
            // 
            this.fluidOuncesLabel.AutoSize = true;
            this.fluidOuncesLabel.Location = new System.Drawing.Point(62, 117);
            this.fluidOuncesLabel.Name = "fluidOuncesLabel";
            this.fluidOuncesLabel.Size = new System.Drawing.Size(72, 13);
            this.fluidOuncesLabel.TabIndex = 3;
            this.fluidOuncesLabel.Text = "Fluid Ounces:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(65, 170);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = " Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(178, 170);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 226);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.fluidOuncesLabel);
            this.Controls.Add(this.cupsTextBox);
            this.Controls.Add(this.cupsLabel);
            this.Controls.Add(this.cupsToOuncesLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cupsToOuncesLabel;
        private System.Windows.Forms.Label cupsLabel;
        private System.Windows.Forms.TextBox cupsTextBox;
        private System.Windows.Forms.TextBox ouncesLabel;
        private System.Windows.Forms.Label fluidOuncesLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}


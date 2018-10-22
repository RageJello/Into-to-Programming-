namespace SouthAmerica
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
            this.countriesLabel = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countriesLabel
            // 
            this.countriesLabel.AutoSize = true;
            this.countriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countriesLabel.Location = new System.Drawing.Point(30, 9);
            this.countriesLabel.Name = "countriesLabel";
            this.countriesLabel.Size = new System.Drawing.Size(270, 20);
            this.countriesLabel.TabIndex = 0;
            this.countriesLabel.Text = "The Countries of South America:";
            this.countriesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.Location = new System.Drawing.Point(32, 48);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(266, 160);
            this.countriesListBox.TabIndex = 1;
            // 
            // getCountriesButton
            // 
            this.getCountriesButton.Location = new System.Drawing.Point(54, 247);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(99, 44);
            this.getCountriesButton.TabIndex = 2;
            this.getCountriesButton.Text = "Get Countries";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            this.getCountriesButton.Click += new System.EventHandler(this.getCountriesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(169, 247);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 44);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 320);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.countriesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "South America";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countriesLabel;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.Button exitButton;
    }
}


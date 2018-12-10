namespace RocketFinal
{
    partial class RocketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RocketForm));
            this.rocketListBox = new System.Windows.Forms.ListBox();
            this.rocketSelectionLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.rocketManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.rocketNameTextBox = new System.Windows.Forms.TextBox();
            this.rocketNameLabel = new System.Windows.Forms.Label();
            this.rocketStatusTextBox = new System.Windows.Forms.TextBox();
            this.rocketStatusLabel = new System.Windows.Forms.Label();
            this.rocketLastLaunchDateTextBox = new System.Windows.Forms.TextBox();
            this.lastLaunchDateLabel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rocketListBox
            // 
            this.rocketListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketListBox.FormattingEnabled = true;
            this.rocketListBox.ItemHeight = 24;
            this.rocketListBox.Items.AddRange(new object[] {
            "Atlas III",
            "Minotaur II",
            "Atlas V",
            "Delta IV",
            "Minotaur I",
            "Minotaur IV",
            "Falcon 1",
            "Falcon 9",
            "Antares",
            "Falcon Heavy"});
            this.rocketListBox.Location = new System.Drawing.Point(55, 65);
            this.rocketListBox.Name = "rocketListBox";
            this.rocketListBox.Size = new System.Drawing.Size(165, 124);
            this.rocketListBox.TabIndex = 0;
            this.rocketListBox.SelectedIndexChanged += new System.EventHandler(this.rocketListBox_SelectedIndexChanged);
            // 
            // rocketSelectionLabel
            // 
            this.rocketSelectionLabel.AutoSize = true;
            this.rocketSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketSelectionLabel.Location = new System.Drawing.Point(51, 33);
            this.rocketSelectionLabel.Name = "rocketSelectionLabel";
            this.rocketSelectionLabel.Size = new System.Drawing.Size(185, 25);
            this.rocketSelectionLabel.TabIndex = 1;
            this.rocketSelectionLabel.Text = "Select a Rocket:";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.Location = new System.Drawing.Point(307, 131);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(125, 24);
            this.manufacturerLabel.TabIndex = 2;
            this.manufacturerLabel.Text = "Manufacturer:";
            // 
            // rocketManufacturerTextBox
            // 
            this.rocketManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketManufacturerTextBox.Location = new System.Drawing.Point(311, 173);
            this.rocketManufacturerTextBox.Name = "rocketManufacturerTextBox";
            this.rocketManufacturerTextBox.ReadOnly = true;
            this.rocketManufacturerTextBox.Size = new System.Drawing.Size(244, 29);
            this.rocketManufacturerTextBox.TabIndex = 3;
            // 
            // abortButton
            // 
            this.abortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortButton.Location = new System.Drawing.Point(56, 335);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(164, 43);
            this.abortButton.TabIndex = 4;
            this.abortButton.Text = "ABORT";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // rocketNameTextBox
            // 
            this.rocketNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketNameTextBox.Location = new System.Drawing.Point(311, 75);
            this.rocketNameTextBox.Name = "rocketNameTextBox";
            this.rocketNameTextBox.ReadOnly = true;
            this.rocketNameTextBox.Size = new System.Drawing.Size(244, 29);
            this.rocketNameTextBox.TabIndex = 6;
            // 
            // rocketNameLabel
            // 
            this.rocketNameLabel.AutoSize = true;
            this.rocketNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketNameLabel.Location = new System.Drawing.Point(307, 33);
            this.rocketNameLabel.Name = "rocketNameLabel";
            this.rocketNameLabel.Size = new System.Drawing.Size(129, 24);
            this.rocketNameLabel.TabIndex = 5;
            this.rocketNameLabel.Text = "Rocket Name:";
            // 
            // rocketStatusTextBox
            // 
            this.rocketStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketStatusTextBox.Location = new System.Drawing.Point(311, 290);
            this.rocketStatusTextBox.Name = "rocketStatusTextBox";
            this.rocketStatusTextBox.ReadOnly = true;
            this.rocketStatusTextBox.Size = new System.Drawing.Size(244, 29);
            this.rocketStatusTextBox.TabIndex = 8;
            // 
            // rocketStatusLabel
            // 
            this.rocketStatusLabel.AutoSize = true;
            this.rocketStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketStatusLabel.Location = new System.Drawing.Point(307, 248);
            this.rocketStatusLabel.Name = "rocketStatusLabel";
            this.rocketStatusLabel.Size = new System.Drawing.Size(128, 24);
            this.rocketStatusLabel.TabIndex = 7;
            this.rocketStatusLabel.Text = "Rocket Status:";
            // 
            // rocketLastLaunchDateTextBox
            // 
            this.rocketLastLaunchDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketLastLaunchDateTextBox.Location = new System.Drawing.Point(311, 396);
            this.rocketLastLaunchDateTextBox.Name = "rocketLastLaunchDateTextBox";
            this.rocketLastLaunchDateTextBox.ReadOnly = true;
            this.rocketLastLaunchDateTextBox.Size = new System.Drawing.Size(244, 29);
            this.rocketLastLaunchDateTextBox.TabIndex = 10;
            // 
            // lastLaunchDateLabel
            // 
            this.lastLaunchDateLabel.AutoSize = true;
            this.lastLaunchDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLaunchDateLabel.Location = new System.Drawing.Point(307, 354);
            this.lastLaunchDateLabel.Name = "lastLaunchDateLabel";
            this.lastLaunchDateLabel.Size = new System.Drawing.Size(159, 24);
            this.lastLaunchDateLabel.TabIndex = 9;
            this.lastLaunchDateLabel.Text = "Last Launch Date:";
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.Color.Maroon;
            this.launchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.Location = new System.Drawing.Point(56, 248);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(164, 43);
            this.launchButton.TabIndex = 11;
            this.launchButton.Text = "LAUNCH";
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // RocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.rocketLastLaunchDateTextBox);
            this.Controls.Add(this.lastLaunchDateLabel);
            this.Controls.Add(this.rocketStatusTextBox);
            this.Controls.Add(this.rocketStatusLabel);
            this.Controls.Add(this.rocketNameTextBox);
            this.Controls.Add(this.rocketNameLabel);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.rocketManufacturerTextBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.rocketSelectionLabel);
            this.Controls.Add(this.rocketListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RocketForm";
            this.Text = "Rocket Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rocketListBox;
        private System.Windows.Forms.Label rocketSelectionLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.TextBox rocketManufacturerTextBox;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.TextBox rocketNameTextBox;
        private System.Windows.Forms.Label rocketNameLabel;
        private System.Windows.Forms.TextBox rocketStatusTextBox;
        private System.Windows.Forms.Label rocketStatusLabel;
        private System.Windows.Forms.TextBox rocketLastLaunchDateTextBox;
        private System.Windows.Forms.Label lastLaunchDateLabel;
        private System.Windows.Forms.Button launchButton;
    }
}


namespace QuickPickConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.FromInput = new System.Windows.Forms.TextBox();
            this.ToInput = new System.Windows.Forms.TextBox();
            this.UnitInput = new System.Windows.Forms.TextBox();
            this.Notification = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProcessedDir = new System.Windows.Forms.PictureBox();
            this.ToDir = new System.Windows.Forms.PictureBox();
            this.ProcessedInput = new System.Windows.Forms.TextBox();
            this.ProcessedLabel = new System.Windows.Forms.Label();
            this.FromDir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDir)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(636, 234);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 28);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Convert";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitLabel.Location = new System.Drawing.Point(44, 31);
            this.UnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(61, 18);
            this.UnitLabel.TabIndex = 3;
            this.UnitLabel.Text = "Unit #";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLabel.Location = new System.Drawing.Point(27, 75);
            this.SourceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(69, 18);
            this.SourceLabel.TabIndex = 4;
            this.SourceLabel.Text = "Source:";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(8, 124);
            this.DestinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(110, 18);
            this.DestinationLabel.TabIndex = 5;
            this.DestinationLabel.Text = "Destination:";
            // 
            // FromInput
            // 
            this.FromInput.BackColor = System.Drawing.SystemColors.Window;
            this.FromInput.Location = new System.Drawing.Point(125, 76);
            this.FromInput.Margin = new System.Windows.Forms.Padding(4);
            this.FromInput.Name = "FromInput";
            this.FromInput.Size = new System.Drawing.Size(552, 22);
            this.FromInput.TabIndex = 3;
            // 
            // ToInput
            // 
            this.ToInput.Enabled = false;
            this.ToInput.Location = new System.Drawing.Point(125, 124);
            this.ToInput.Margin = new System.Windows.Forms.Padding(4);
            this.ToInput.Name = "ToInput";
            this.ToInput.Size = new System.Drawing.Size(552, 22);
            this.ToInput.TabIndex = 6;
            // 
            // UnitInput
            // 
            this.UnitInput.Location = new System.Drawing.Point(125, 31);
            this.UnitInput.Margin = new System.Windows.Forms.Padding(4);
            this.UnitInput.Name = "UnitInput";
            this.UnitInput.Size = new System.Drawing.Size(317, 22);
            this.UnitInput.TabIndex = 1;
            this.UnitInput.TextChanged += new System.EventHandler(this.UnitInput_TextChanged);
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification.ForeColor = System.Drawing.Color.DarkRed;
            this.Notification.Location = new System.Drawing.Point(240, 238);
            this.Notification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Notification.Name = "Notification";
            this.Notification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Notification.Size = new System.Drawing.Size(99, 18);
            this.Notification.TabIndex = 9;
            this.Notification.Text = "Status bar";
            this.Notification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Notification.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ProgressBar.Location = new System.Drawing.Point(12, 234);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar.Minimum = 1;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(596, 28);
            this.ProgressBar.TabIndex = 10;
            this.ProgressBar.Value = 1;
            this.ProgressBar.Visible = false;
            // 
            // ProcessedDir
            // 
            this.ProcessedDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessedDir.Image = ((System.Drawing.Image)(resources.GetObject("ProcessedDir.Image")));
            this.ProcessedDir.Location = new System.Drawing.Point(700, 174);
            this.ProcessedDir.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessedDir.Name = "ProcessedDir";
            this.ProcessedDir.Size = new System.Drawing.Size(36, 33);
            this.ProcessedDir.TabIndex = 15;
            this.ProcessedDir.TabStop = false;
            this.ProcessedDir.Visible = false;
            this.ProcessedDir.Click += new System.EventHandler(this.ProcessedDir_Click);
            // 
            // ToDir
            // 
            this.ToDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToDir.Image = ((System.Drawing.Image)(resources.GetObject("ToDir.Image")));
            this.ToDir.Location = new System.Drawing.Point(700, 124);
            this.ToDir.Margin = new System.Windows.Forms.Padding(4);
            this.ToDir.Name = "ToDir";
            this.ToDir.Size = new System.Drawing.Size(36, 33);
            this.ToDir.TabIndex = 15;
            this.ToDir.TabStop = false;
            this.ToDir.Visible = false;
            this.ToDir.Click += new System.EventHandler(this.ToDir_Click);
            // 
            // ProcessedInput
            // 
            this.ProcessedInput.Enabled = false;
            this.ProcessedInput.Location = new System.Drawing.Point(125, 174);
            this.ProcessedInput.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessedInput.Name = "ProcessedInput";
            this.ProcessedInput.Size = new System.Drawing.Size(552, 22);
            this.ProcessedInput.TabIndex = 7;
            // 
            // ProcessedLabel
            // 
            this.ProcessedLabel.AutoSize = true;
            this.ProcessedLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessedLabel.Location = new System.Drawing.Point(8, 174);
            this.ProcessedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcessedLabel.Name = "ProcessedLabel";
            this.ProcessedLabel.Size = new System.Drawing.Size(97, 18);
            this.ProcessedLabel.TabIndex = 8;
            this.ProcessedLabel.Text = "Processed:";
            // 
            // FromDir
            // 
            this.FromDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FromDir.Image = ((System.Drawing.Image)(resources.GetObject("FromDir.Image")));
            this.FromDir.Location = new System.Drawing.Point(700, 74);
            this.FromDir.Margin = new System.Windows.Forms.Padding(4);
            this.FromDir.Name = "FromDir";
            this.FromDir.Size = new System.Drawing.Size(36, 33);
            this.FromDir.TabIndex = 14;
            this.FromDir.TabStop = false;
            this.FromDir.Click += new System.EventHandler(this.FromDir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 283);
            this.Controls.Add(this.ProcessedDir);
            this.Controls.Add(this.FromDir);
            this.Controls.Add(this.ToDir);
            this.Controls.Add(this.ProcessedInput);
            this.Controls.Add(this.ProcessedLabel);
            this.Controls.Add(this.ToInput);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Notification);
            this.Controls.Add(this.UnitInput);
            this.Controls.Add(this.FromInput);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.UnitLabel);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Quick Pic File Name Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.TextBox FromInput;
        private System.Windows.Forms.TextBox ToInput;
        private System.Windows.Forms.TextBox UnitInput;
        private System.Windows.Forms.Label Notification;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProcessedLabel;
        private System.Windows.Forms.TextBox ProcessedInput;
        private System.Windows.Forms.PictureBox FromDir;
        private System.Windows.Forms.PictureBox ToDir;
        private System.Windows.Forms.PictureBox ProcessedDir;
    }
}


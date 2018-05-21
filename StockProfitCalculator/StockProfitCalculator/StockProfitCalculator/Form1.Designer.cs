namespace StockProfitCalculator
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
            this.BrowseFile = new System.Windows.Forms.Button();
            this.GainLabel = new System.Windows.Forms.Label();
            this.GainDetailText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrowseFile
            // 
            this.BrowseFile.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BrowseFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BrowseFile.Location = new System.Drawing.Point(135, 41);
            this.BrowseFile.Margin = new System.Windows.Forms.Padding(8);
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.Size = new System.Drawing.Size(201, 34);
            this.BrowseFile.TabIndex = 0;
            this.BrowseFile.Text = "Input Stock Rate File";
            this.BrowseFile.UseVisualStyleBackColor = false;
            this.BrowseFile.Click += new System.EventHandler(this.BrowseFile_Click);
            // 
            // GainLabel
            // 
            this.GainLabel.AutoSize = true;
            this.GainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GainLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GainLabel.Location = new System.Drawing.Point(83, 132);
            this.GainLabel.Name = "GainLabel";
            this.GainLabel.Size = new System.Drawing.Size(0, 20);
            this.GainLabel.TabIndex = 2;
            this.GainLabel.Visible = false;
            // 
            // GainDetailText
            // 
            this.GainDetailText.AutoSize = true;
            this.GainDetailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GainDetailText.Location = new System.Drawing.Point(306, 134);
            this.GainDetailText.Name = "GainDetailText";
            this.GainDetailText.Size = new System.Drawing.Size(0, 18);
            this.GainDetailText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(510, 233);
            this.Controls.Add(this.GainLabel);
            this.Controls.Add(this.GainDetailText);
            this.Controls.Add(this.BrowseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "DeLorean";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseFile;
        private System.Windows.Forms.Label GainDetailText;
        private System.Windows.Forms.Label GainLabel;
    }
}


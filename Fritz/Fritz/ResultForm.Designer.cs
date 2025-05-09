namespace Fritz
{
    partial class ResultForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTopJobs = new System.Windows.Forms.Label();
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form Styling
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke; // Set background color
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Prevent resizing
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Center the form
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Modern font
            // 
            // lblTopJobs
            // 
            this.lblTopJobs.AutoSize = true;
            this.lblTopJobs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopJobs.ForeColor = System.Drawing.Color.DarkSlateGray; // Set text color
            this.lblTopJobs.Location = new System.Drawing.Point(30, 20);
            this.lblTopJobs.Name = "lblTopJobs";
            this.lblTopJobs.Size = new System.Drawing.Size(180, 21); // Adjusted for new font size
            this.lblTopJobs.TabIndex = 0;
            this.lblTopJobs.Text = "Top Job Matches for You";
            // 
            // lstJobs
            // 
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.Location = new System.Drawing.Point(30, 50);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(320, 160); // Adjusted dimensions
            this.lstJobs.TabIndex = 1;
            this.lstJobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Add border for better appearance
            this.lstJobs.BackColor = System.Drawing.Color.White; // Set background color
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(30, 230);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(120, 35); // Adjusted size
            this.btnViewDetails.TabIndex = 2;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.BackColor = System.Drawing.Color.DarkSlateGray; // Set button background color
            this.btnViewDetails.ForeColor = System.Drawing.Color.White; // Set button text color
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Apply flat style
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(230, 230);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35); // Adjusted size
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray; // Set button background color
            this.btnBack.ForeColor = System.Drawing.Color.White; // Set button text color
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Apply flat style
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Updated for new font size
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300); // Adjusted for better layout
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.lstJobs);
            this.Controls.Add(this.lblTopJobs);
            this.Name = "ResultForm";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTopJobs;
        private System.Windows.Forms.ListBox lstJobs;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnBack;
    }
}
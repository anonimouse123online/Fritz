namespace Fritz
{
    partial class JobDetailsForm
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
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form Styling
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke; // Set background color
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Prevent resizing
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Center the form
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Modern font
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.ForeColor = System.Drawing.Color.DarkSlateGray; // Set text color
            this.lblJobTitle.Location = new System.Drawing.Point(16, 10);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(100, 25);
            this.lblJobTitle.TabIndex = 0;
            this.lblJobTitle.Text = "Job Title";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(20, 50);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Add scroll bars for long descriptions
            this.txtDescription.Size = new System.Drawing.Size(600, 150);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.BackColor = System.Drawing.Color.White; // Set background color
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Add border
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkills.ForeColor = System.Drawing.Color.DarkSlateGray; // Set text color
            this.lblSkills.Location = new System.Drawing.Point(20, 210);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(43, 19);
            this.lblSkills.TabIndex = 2;
            this.lblSkills.Text = "Skills:";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducation.ForeColor = System.Drawing.Color.DarkSlateGray; // Set text color
            this.lblEducation.Location = new System.Drawing.Point(20, 240);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(70, 19);
            this.lblEducation.TabIndex = 3;
            this.lblEducation.Text = "Education:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(540, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30); // Adjust size for better appearance
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateGray; // Set button background color
            this.btnClose.ForeColor = System.Drawing.Color.White; // Set button text color
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Apply flat style
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Updated for new font size
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 320); // Adjusted for better layout
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblJobTitle);
            this.Name = "JobDetailsForm";
            this.Text = "Job Details";
            this.Load += new System.EventHandler(this.JobDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Button btnClose;
    }
}
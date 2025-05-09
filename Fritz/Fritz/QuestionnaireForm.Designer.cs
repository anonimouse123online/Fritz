namespace Fritz
{
    partial class QuestionnaireForm
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
            this.grpQuestion1 = new System.Windows.Forms.GroupBox();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.cmbQ1 = new System.Windows.Forms.ComboBox();
            this.grpQuestion2 = new System.Windows.Forms.GroupBox();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.cmbQ2 = new System.Windows.Forms.ComboBox();
            this.grpQuestion3 = new System.Windows.Forms.GroupBox();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.cmbQ3 = new System.Windows.Forms.ComboBox();
            this.btnSubmitAnswers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form Styling
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Questionnaire";
            // 
            // grpQuestion1
            // 
            this.grpQuestion1.Controls.Add(this.lblQ1);
            this.grpQuestion1.Controls.Add(this.cmbQ1);
            this.grpQuestion1.Location = new System.Drawing.Point(20, 20);
            this.grpQuestion1.Name = "grpQuestion1";
            this.grpQuestion1.Size = new System.Drawing.Size(400, 80);
            this.grpQuestion1.TabIndex = 0;
            this.grpQuestion1.TabStop = false;
            this.grpQuestion1.Text = "Question 1";
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.Location = new System.Drawing.Point(15, 25);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(250, 19);
            this.lblQ1.TabIndex = 0;
            this.lblQ1.Text = "What do you enjoy doing the most?";
            this.lblQ1.ForeColor = System.Drawing.Color.DarkSlateGray;
            // 
            // cmbQ1
            // 
            this.cmbQ1.FormattingEnabled = true;
            this.cmbQ1.Items.AddRange(new object[] {
            "Solving Problems",
            "Helping People",
            "Building Things"});
            this.cmbQ1.Location = new System.Drawing.Point(15, 50);
            this.cmbQ1.Name = "cmbQ1";
            this.cmbQ1.Size = new System.Drawing.Size(350, 25);
            this.cmbQ1.TabIndex = 1;
            this.cmbQ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // grpQuestion2
            // 
            this.grpQuestion2.Controls.Add(this.lblQ2);
            this.grpQuestion2.Controls.Add(this.cmbQ2);
            this.grpQuestion2.Location = new System.Drawing.Point(20, 110);
            this.grpQuestion2.Name = "grpQuestion2";
            this.grpQuestion2.Size = new System.Drawing.Size(400, 80);
            this.grpQuestion2.TabIndex = 1;
            this.grpQuestion2.TabStop = false;
            this.grpQuestion2.Text = "Question 2";
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Location = new System.Drawing.Point(15, 25);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(200, 19);
            this.lblQ2.TabIndex = 0;
            this.lblQ2.Text = "What is your education level?";
            this.lblQ2.ForeColor = System.Drawing.Color.DarkSlateGray;
            // 
            // cmbQ2
            // 
            this.cmbQ2.FormattingEnabled = true;
            this.cmbQ2.Items.AddRange(new object[] {
            "High School",
            "College",
            "Vocational Training"});
            this.cmbQ2.Location = new System.Drawing.Point(15, 50);
            this.cmbQ2.Name = "cmbQ2";
            this.cmbQ2.Size = new System.Drawing.Size(350, 25);
            this.cmbQ2.TabIndex = 1;
            this.cmbQ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // grpQuestion3
            // 
            this.grpQuestion3.Controls.Add(this.lblQ3);
            this.grpQuestion3.Controls.Add(this.cmbQ3);
            this.grpQuestion3.Location = new System.Drawing.Point(20, 200);
            this.grpQuestion3.Name = "grpQuestion3";
            this.grpQuestion3.Size = new System.Drawing.Size(400, 80);
            this.grpQuestion3.TabIndex = 2;
            this.grpQuestion3.TabStop = false;
            this.grpQuestion3.Text = "Question 3";
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.Location = new System.Drawing.Point(15, 25);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(280, 19);
            this.lblQ3.TabIndex = 0;
            this.lblQ3.Text = "Would you describe yourself as introverted?";
            this.lblQ3.ForeColor = System.Drawing.Color.DarkSlateGray;
            // 
            // cmbQ3
            // 
            this.cmbQ3.FormattingEnabled = true;
            this.cmbQ3.Items.AddRange(new object[] {
            "Introverted",
            "Extroverted"});
            this.cmbQ3.Location = new System.Drawing.Point(15, 50);
            this.cmbQ3.Name = "cmbQ3";
            this.cmbQ3.Size = new System.Drawing.Size(350, 25);
            this.cmbQ3.TabIndex = 1;
            this.cmbQ3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // btnSubmitAnswers
            // 
            this.btnSubmitAnswers.Location = new System.Drawing.Point(150, 300);
            this.btnSubmitAnswers.Name = "btnSubmitAnswers";
            this.btnSubmitAnswers.Size = new System.Drawing.Size(150, 40);
            this.btnSubmitAnswers.TabIndex = 3;
            this.btnSubmitAnswers.Text = "Submit";
            this.btnSubmitAnswers.UseVisualStyleBackColor = false;
            this.btnSubmitAnswers.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmitAnswers.ForeColor = System.Drawing.Color.White;
            this.btnSubmitAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAnswers.Click += new System.EventHandler(this.btnSubmitAnswers_Click);
            // 
            // QuestionnaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 370);
            this.Controls.Add(this.btnSubmitAnswers);
            this.Controls.Add(this.grpQuestion3);
            this.Controls.Add(this.grpQuestion2);
            this.Controls.Add(this.grpQuestion1);
            this.Name = "QuestionnaireForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpQuestion1;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.ComboBox cmbQ1;
        private System.Windows.Forms.GroupBox grpQuestion2;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.ComboBox cmbQ2;
        private System.Windows.Forms.GroupBox grpQuestion3;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.ComboBox cmbQ3;
        private System.Windows.Forms.Button btnSubmitAnswers;
    }
}
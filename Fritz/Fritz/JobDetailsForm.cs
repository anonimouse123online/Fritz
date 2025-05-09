using System;
using System.Windows.Forms;

namespace Fritz
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm(string jobTitle)
        {
            InitializeComponent();

            // Use JobMatcher to get job details
            var jobDetails = JobMatcher.GetJobDetails(jobTitle);

            lblJobTitle.Text = jobDetails.Title;
            txtDescription.Text = jobDetails.Description;
            lblSkills.Text = $"Suggested Skills: {jobDetails.Skills}";
            lblEducation.Text = $"Education Level: {jobDetails.EducationLevel}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JobDetailsForm_Load(object sender, EventArgs e)
        {
            // Handle any additional loading behavior
        }
    }
}
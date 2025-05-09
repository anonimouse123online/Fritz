using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fritz
{
    public partial class ResultForm : Form
    {
        private List<string> jobMatches;

        public ResultForm(string answer1, string answer2, string answer3)
        {
            InitializeComponent();

            // Calculate job matches using the provided answers
            jobMatches = JobMatcher.GetJobMatches(answer1, answer2, answer3);

            // Populate the ListBox with job matches
            PopulateJobList();
        }

        private void PopulateJobList()
        {
            try
            {
                if (jobMatches != null && jobMatches.Count > 0)
                {
                    lstJobs.Items.Clear();
                    foreach (var job in jobMatches)
                    {
                        lstJobs.Items.Add(job);
                    }
                }
                else
                {
                    MessageBox.Show("No jobs found matching your profile.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error populating job list: {ex.Message}");
                MessageBox.Show($"An error occurred while populating the job list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstJobs.SelectedItem != null)
                {
                    string selectedJob = lstJobs.SelectedItem.ToString();
                    var jobDetailsForm = new JobDetailsForm(selectedJob);
                    jobDetailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a job to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening job details: {ex.Message}");
                MessageBox.Show($"An error occurred while opening the job details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstJobs_DoubleClick(object sender, EventArgs e)
        {
            btnViewDetails_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            var questionnaireForm = new QuestionnaireForm();
            questionnaireForm.Show();

            this.Hide();
        }
    }
}
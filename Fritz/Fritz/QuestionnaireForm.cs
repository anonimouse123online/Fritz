using System;
using System.Windows.Forms;

namespace Fritz
{
    public partial class QuestionnaireForm : Form
    {
        public QuestionnaireForm()
        {
            InitializeComponent();
        }

        private void btnSubmitAnswers_Click(object sender, EventArgs e)
        {
            // Collect user answers
            string answer1 = cmbQ1.SelectedItem?.ToString();
            string answer2 = cmbQ2.SelectedItem?.ToString();
            string answer3 = cmbQ3.SelectedItem?.ToString();

            // In a real app, validate answers here
            if (string.IsNullOrEmpty(answer1) || string.IsNullOrEmpty(answer2) || string.IsNullOrEmpty(answer3))
            {
                MessageBox.Show("Please answer all questions.");
                return;
            }

            // Pass answers to the next form
            var resultForm = new ResultForm(answer1, answer2, answer3);
            this.Hide();
            resultForm.ShowDialog();
            this.Close();
        }
    }
}
using Examinator3000.Helper;
using Examinator3000.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examinator3000
{
    public partial class CreateTestForm : Form
    {
        private List<Answer> answerList = new List<Answer>();
        public CreateTestForm()
        {
            
            InitializeComponent();
            QuestionTypeSet();
            AnswerTypeSet();
            LoadQuestions();
        }

        private void IsPictureQuestionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            QuestionTypeSet();
        }

        private void QuestionTypeSet()
        {
            if (IsPictureQuestionCheckBox.Checked)
            {
                TextAboveImageLabel.Text = "Text Above Image:";

                ImagePathLabel.Visible = true;
                ImagePathTextBox.Visible = true;
            }
            else
            {
                TextAboveImageLabel.Text = "Question Text:";

                ImagePathLabel.Visible = false;
                ImagePathTextBox.Visible = false;
                ImagePathTextBox.Clear();
            }
        }
        private void AnswerTypeSet()
        {
            if (HasImageAnswerCheckBox.Checked)
            {
                AnswerImagePathLabel.Visible = true;
                AnswerImagePathTextBox.Visible = true;
            }
            else
            {
                AnswerImagePathLabel.Visible = false;
                AnswerImagePathTextBox.Visible = false;
                AnswerImagePathTextBox.Clear();
            }
        }
        private void LoadQuestions() 
        {
            foreach(var question in Globals.CurrentActiveTest.Questions) 
            {
                QuestionsListBox.Items.Add(question.QuestionText);   
            }
        }
        private bool SendQuestion()
        {
            if (IsPictureQuestionCheckBox.Checked)
            {
                if (!String.IsNullOrWhiteSpace(ImagePathTextBox.Text))
                {
                    if (answerList.Count() != 0)
                    {
                        foreach (var answer in answerList)
                        {
                            if (answer.isCorrectAnswer())
                            {
                                Question question = new Question(TextAboveImageRichTextBox.Text, ImagePathTextBox.Text, answerList);
                                Globals.CurrentActiveTest.AddNewQuestion(question);
                                QuestionsListBox.Items.Add($"Question {Globals.CurrentActiveTest.Questions.Count()}: {question.QuestionImage}");

                                return true;
                            }
                        }
                    }
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(TextAboveImageRichTextBox.Text))
                {
                    if (answerList.Count() != 0)
                    {
                        foreach (var answer in answerList)
                        {
                            if (answer.isCorrectAnswer())
                            {
                                Question question = new Question(TextAboveImageRichTextBox.Text, null, answerList);
                                Globals.CurrentActiveTest.AddNewQuestion(question);
                                QuestionsListBox.Items.Add($"Question {Globals.CurrentActiveTest.Questions.Count()}: {question.QuestionText}");
                                return true;

                            }
                        }
                    }
                }
            }
            return false;
        }
        private void AddNewAnswer()
        {
            if (HasImageAnswerCheckBox.Checked)
            {
                if (!String.IsNullOrWhiteSpace(AnswerImagePathTextBox.Text))
                {
                    var answer = new Answer(true, AnswerImagePathTextBox.Text);
                    answerList.Add(answer);
                    AnswersListBox.Items.Add($"Answer {answerList.Count}: {answer.GetImagePath()}\t Correct Answer: {answer.isCorrectAnswer()}");
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(AnswerTextRichTextBox.Text))
                {
                    var answer = new Answer(AnswerTextRichTextBox.Text, IsCorrectAnswerCheckBox.Checked);
                    answerList.Add(answer);
                    AnswersListBox.Items.Add($"Answer {answerList.Count}: {answer.GetAnswerText()}\t Correct Answer: {answer.isCorrectAnswer()}");
                }
            }
        }

        private void AddAnswerButton_Click(object sender, EventArgs e)
        {
            AddNewAnswer();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            bool success = SendQuestion();
            if (success)
            {
                answerList.Clear();
                AnswersListBox.Items.Clear();
            }
        }

        private void ImagePathTextBox_TextChanged(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, $"Images/Images{Globals.CurrentActiveTest.TestName}", ImagePathTextBox.Text);
            PicturePreviewPictureBox.ImageLocation = imagePath;
            PicturePreviewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void AnswerImagePathTextBox_TextChanged(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, $"Images/Images{Globals.CurrentActiveTest.TestName}", AnswerImagePathTextBox.Text);
            AnswerPictureBox.ImageLocation = imagePath;
            PicturePreviewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void HasImageAnswerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AnswerTypeSet();
        }

        private void FinishTestButton_Click(object sender, EventArgs e)
        {
            FileWriter.SaveTests(Globals.LoadedTests);
            this.Close();
        }
    }
}

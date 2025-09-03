using Examinator3000.Helper;
using Examinator3000.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examinator3000
{
    public partial class CreateTestForm : Form
    {
        private List<Answer> answerList = new List<Answer>();
        private bool editMode;
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
            foreach (var question in Globals.CurrentActiveTest.Questions)
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
                                if(Globals.CurrentActiveTest.Questions.Contains(Globals.CurrentActiveQuestion) && editMode == true) 
                                {
                                    var index = Globals.CurrentActiveTest.Questions.IndexOf(Globals.CurrentActiveQuestion);
                                    Globals.CurrentActiveTest.Questions[index] = Globals.CurrentActiveQuestion;

                                }
                                else 
                                {
                                    Globals.CurrentActiveTest.AddNewQuestion(question);
                                    QuestionsListBox.Items.Add($"Question {Globals.CurrentActiveTest.Questions.Count()}: {question.QuestionImage}");
                                }
                                

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
                                if (Globals.CurrentActiveTest.Questions.Contains(Globals.CurrentActiveQuestion) && editMode == true)
                                {
                                    var index = Globals.CurrentActiveTest.Questions.IndexOf(Globals.CurrentActiveQuestion);
                                    Globals.CurrentActiveTest.Questions[index] = Globals.CurrentActiveQuestion; 
                                }
                                else 
                                {
                                    Globals.CurrentActiveTest.AddNewQuestion(question);
                                    QuestionsListBox.Items.Add($"Question {Globals.CurrentActiveTest.Questions.Count()}: {question.QuestionText}");
                                }
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
            if (editMode) 
            {

            }
            else 
            {
                bool success = SendQuestion();
                if (success)
                {
                    answerList.Clear();
                    AnswersListBox.Items.Clear();
                }
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

        private void EditAnswerButton_Click(object sender, EventArgs e)
        {
            if (AnswersListBox.SelectedItem == null)
            {
                MessageBox.Show("No Answer selected!");
                return;
            }
            foreach (var answer in answerList)
            {
                if (AnswersListBox.GetItemText(AnswersListBox.SelectedItem).Contains(answer.answerText))
                {

                    Globals.CurrentActiveAnswer = answer;

                    EditAnswerForm editAnswerForm = new EditAnswerForm();
                    editAnswerForm.ShowDialog();
                }
            }


        }

        private void DeleteAnswerButton_Click(object sender, EventArgs e)
        {
            if (AnswersListBox.SelectedItem == null)
            {
                MessageBox.Show("No Answer selected!");
                return;
            }
            Answer answerToRemove = null;
            foreach (var answer in answerList)
            {
                if (AnswersListBox.GetItemText(AnswersListBox.SelectedItem).Contains(answer.answerText))
                {
                    answerToRemove = (Answer)answer;
                }
            }
            if (answerToRemove != null)
            {
                answerList.Remove(answerToRemove);
                AnswersListBox.Items.Remove(AnswersListBox.SelectedItem);
            }

        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            if (QuestionsListBox.SelectedItem == null)
            {
                MessageBox.Show("No Answer selected!");
                return;
            }
            Question questionsToRemove = null;
            foreach (var question in Globals.CurrentActiveTest.Questions)
            {
                if (QuestionsListBox.GetItemText(QuestionsListBox.SelectedItem).Contains(question.QuestionText))
                {
                    questionsToRemove = (Question)question;
                }
            }
            if (questionsToRemove != null)
            {
                Globals.CurrentActiveTest.Questions.Remove(questionsToRemove);
                QuestionsListBox.Items.Remove(QuestionsListBox.SelectedItem);
            }
        }

        private void EditQuestionButton_Click(object sender, EventArgs e)
        {
            AddQuestionButton.Text = "Update Question";
            editMode = true;    
            foreach(var question in Globals.CurrentActiveTest.Questions) 
            {
                if (QuestionsListBox.GetItemText(QuestionsListBox.SelectedItem).Contains(question.QuestionText))
                {
                    Globals.CurrentActiveQuestion = question;
                }
            }
            FillFieldsOnEdit();

        }
        private void FillFieldsOnEdit() 
        {
            if (Globals.CurrentActiveQuestion.isPictureQuestion) 
            {
                IsPictureQuestionCheckBox.Checked = true;   
                ImagePathTextBox.Text = Globals.CurrentActiveQuestion.QuestionImage;
                PicturePreviewPictureBox.ImageLocation = Path.Combine(Application.StartupPath, $"Images/Images{Globals.CurrentActiveTest.TestName}", ImagePathTextBox.Text);
                PicturePreviewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            TextAboveImageRichTextBox.Text = Globals.CurrentActiveQuestion.QuestionText;
            foreach (var answer in Globals.CurrentActiveQuestion.AnswerList) 
            {
 
               if (!String.IsNullOrWhiteSpace(answer.imagePath))
               {
                  answerList.Add(answer);
                  AnswersListBox.Items.Add($"Answer {answerList.Count}: {answer.GetImagePath()}\t Correct Answer: {answer.isCorrectAnswer()}");
               }

                if (!String.IsNullOrWhiteSpace(answer.answerText))
                {
                  answerList.Add(answer);
                  AnswersListBox.Items.Add($"Answer {answerList.Count}: {answer.GetAnswerText()}\t Correct Answer: {answer.isCorrectAnswer()}");
                }
                
            }
        }
    }
}

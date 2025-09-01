using Examinator3000.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examinator3000
{
    public partial class TestForm : Form
    {
        public int CurrentQuestion = 0;
        public int repeaterCounter = 1;
        public TestForm()
        {
            InitializeComponent();
            SetQuestion();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SetQuestion()
        {
            var currentQuestion = Globals.CurrentActiveTest.Questions[0];
            if (repeaterCounter == 3 && Globals.CurrentActiveTest.RepeatQuestions.Count > 2) 
            {

                Random r = new Random();
                var questionIndex = r.Next(0, Globals.CurrentActiveTest.RepeatQuestions.Count - 1);
                currentQuestion = Globals.CurrentActiveTest.RepeatQuestions[questionIndex];
                repeaterCounter = 1;
            }
            else 
            {
                currentQuestion = Globals.CurrentActiveTest.Questions[CurrentQuestion];
                CurrentQuestion += 1;
                repeaterCounter++;  
            }
                
            Globals.CurrentActiveQuestion = currentQuestion;
            if (currentQuestion.IsPictureQuestion())
            {
                QuestionPictureBox.ImageLocation = currentQuestion.QuestionImage;
            }
            AboveImageTextQuestionLabel.Text = currentQuestion.QuestionText;
            SetAnswers(currentQuestion);
        }
        private void SetAnswers(Question question)
        {
            AnswerFlowLayoutPanel.Controls.Clear();

            if(question.AnswerList.Count != 1) 
            {
                foreach (var answer in question.AnswerList)
                {
                    var checkBox = new CheckBox
                    {
                        Text = answer.GetAnswerText(),
                        Font = new Font("Verdana", 12f, FontStyle.Regular),
                        AutoSize = false,  // turn off autosize!
                        Width = AnswerFlowLayoutPanel.ClientSize.Width - 25,
                        MaximumSize = new Size(AnswerFlowLayoutPanel.ClientSize.Width - 25, 0),
                        Tag = answer,
                        TextAlign = ContentAlignment.TopLeft
                    };

                    checkBox.Height = TextRenderer.MeasureText(
                        checkBox.Text,
                        checkBox.Font,
                        new Size(checkBox.Width, int.MaxValue),
                        TextFormatFlags.WordBreak
                    ).Height + 5;

                    AnswerFlowLayoutPanel.Controls.Add(checkBox);
                }
            }
           
        }
        private void flowLayoutPanelAnswers_SizeChanged(object sender, EventArgs e)
        {
            foreach (CheckBox cb in AnswerFlowLayoutPanel.Controls.OfType<CheckBox>())
            {
                cb.MaximumSize = new Size(AnswerFlowLayoutPanel.ClientSize.Width - 20, 0);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (!Globals.Checked) 
            {
                NextButton.Text = "Next Question";
                if (Globals.CurrentActiveQuestion.AnswerList.Count != 1)
                {
                    bool allCorrect = true;

                    foreach (CheckBox cb in AnswerFlowLayoutPanel.Controls.OfType<CheckBox>())
                    {
                        var answer = (Answer)cb.Tag;  

                        if (answer.isCorrectAnswer())
                        {
                            
                            if (!cb.Checked)
                            {
                                allCorrect = false;
                                cb.BackColor = Color.LightGreen;  
                            }
                            else
                            {
                                cb.BackColor = Color.LightGreen;  
                            }
                        }
                        else
                        {
                            
                            if (cb.Checked)
                            {
                                allCorrect = false;
                                cb.BackColor = Color.IndianRed; 
                            }
                        }
                    }

                    if (allCorrect)
                    {
                        MessageBox.Show("Correct! 🎉");
                        Globals.CurrentActiveQuestion.SetResult(true);  
                        Globals.Checked = true; 
                    }
                    else
                    {
                        MessageBox.Show("Some answers were wrong.");
                        Globals.CurrentActiveQuestion.SetResult(false);
                        Globals.Checked = true;
                    }
                }
                else 
                {
                    Globals.Checked = true;
                    var answerForm = new AnswerForm();
                    answerForm.ShowDialog();    
                }
            }
            else
            {
                NextButton.Text = "Check Answer";
                SetQuestion();
                Globals.Checked = false;

            }
        }
    }
}

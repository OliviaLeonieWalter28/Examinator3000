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
            var currentQuestion = Globals.CurrentActiveTest.Questions[CurrentQuestion];
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
        private void flowLayoutPanelAnswers_SizeChanged(object sender, EventArgs e)
        {
            foreach (CheckBox cb in AnswerFlowLayoutPanel.Controls.OfType<CheckBox>())
            {
                cb.MaximumSize = new Size(AnswerFlowLayoutPanel.ClientSize.Width - 20, 0);
            }
        }
    }
}

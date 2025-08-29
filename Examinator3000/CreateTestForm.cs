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
        private List<Answer> answerList;    
        public CreateTestForm()
        {
            InitializeComponent();
            QuestionTypeSet();
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

                TextBelowImageLabel.Visible = true;
                TextBelowImageRichTextBox.Visible = true;
            }
            else
            {
                TextAboveImageLabel.Text = "Question Text:";

                ImagePathLabel.Visible = false;
                ImagePathTextBox.Visible = false;
                ImagePathTextBox.Clear();

                TextBelowImageLabel.Visible = false;
                TextBelowImageRichTextBox.Visible = false;
                TextBelowImageRichTextBox.Clear();
            }
        }
        private void SendQuestion()
        {
            if (IsPictureQuestionCheckBox.Checked)
            {
                
            }
            else
            {

            }
        }
        private void AddNewAnswer() 
        {
            if (HasImageAnswerCheckBox.Checked) 
            {
                if(String.IsNullOrWhiteSpace(ImagePathTextBox.Text)) 
                {
                    answerList.Add(new Answer(true, ImagePathTextBox.Text));
                }
            }
            else 
            {
                if (String.IsNullOrWhiteSpace(AnswerTextRichTextBox.Text)) 
                {
                    answerList.Add(new Answer(AnswerTextRichTextBox.Text, IsCorrectAnswerCheckBox.Checked));
                }
            }
        }
    }
}

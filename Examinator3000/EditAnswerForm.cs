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
    public partial class EditAnswerForm : Form
    {
        public EditAnswerForm()
        {
            InitializeComponent();
            if(Globals.CurrentActiveAnswer.answerText != String.Empty) 
            {
                AnswerTextRichTextBox.Text = Globals.CurrentActiveAnswer.answerText;
            } 
            if(Globals.CurrentActiveAnswer.isAnswerCorrect) 
            {
                IsCorrectAnswerCheckBox.Checked = true;
            }
            if (Globals.CurrentActiveAnswer.isImageAnswer) 
            {
               HasImageAnswerCheckBox.Checked = true;
            }
            if(Globals.CurrentActiveAnswer.imagePath != String.Empty) 
            {
                AnswerImagePathTextBox.Text = Globals.CurrentActiveAnswer.imagePath;
            }
        }

        private void UpdateAnswerButton_Click(object sender, EventArgs e)
        {
            if (HasImageAnswerCheckBox.Checked) 
            {
                Globals.CurrentActiveAnswer = new Model.Answer(true, AnswerTextRichTextBox.Text);
            }
            else 
            {
                Globals.CurrentActiveAnswer = new Model.Answer(AnswerTextRichTextBox.Text, IsCorrectAnswerCheckBox.Checked);
            }   
        }
    }
}

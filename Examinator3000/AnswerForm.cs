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
    public partial class AnswerForm : Form
    {
        public AnswerForm()
        {
            InitializeComponent();
        }
        private void SetAnswer() 
        {
            AnswerPictureBox.ImageLocation = Path.Combine(Application.StartupPath, $"Images/Images{Globals.CurrentActiveTest.TestName}", Globals.CurrentActiveQuestion.AnswerList[0].GetImagePath());
        }
        private void CorrectAnswerButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentActiveQuestion.SetResult(true);
            this.Close();
        }

        private void IncorrectAnswerButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentActiveQuestion.SetResult(false);
            this.Close();
        }
    }
}

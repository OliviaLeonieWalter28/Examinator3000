using Examinator3000.Helper;
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
    public partial class TestSummeryForm : Form
    {
        public TestSummeryForm()
        {
            InitializeComponent();
            SetLabels();
            ResetValues();
            FileWriter.SaveTests(Globals.LoadedTests);
            //Examinator3000Main.Instance.ReloadTests();
        }
        private void SetLabels() 
        {
            TestnameLabel.Text = Globals.CurrentActiveTest.TestName;
            QuestionsCorrectDataLabel.Text = Globals.CurrentTestCorrectAnswers.ToString();  
            IncorrectQuestionsDataLabel.Text = (Globals.CurrentActiveTest.Questions.Count - Globals.CurrentTestCorrectAnswers).ToString();
            CorrectPercentageDataLabel.Text = $"{Globals.CurrentActiveTest.CalculatePercentage()}%";
            AmountOfWeakQuestionsDataLabel.Text = Globals.CurrentActiveTest.WeakQuestions.Count.ToString();  
        }
        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ResetValues() 
        {
            Globals.CurrentActiveTest.AmountOfTimesRepeated += 1;
            Globals.Checked = false;
            Globals.LastQuestion = false;
            Globals.CurrentTestCorrectAnswers = 0;

            foreach (var question in Globals.CurrentActiveTest.Questions) 
            {
                question.timesRepeated = 0;
                question.correcltyRepeated = 0;
            }
        }
    }
}

using Examinator3000.Helper;

namespace Examinator3000
{
    public partial class Examinator3000Main : Form
    {
        public Examinator3000Main()
        {
            InitializeComponent();
            Globals.AddTestTest();
            FileWriter.LoadTests();
            foreach (var test in Globals.LoadedTests)
            {
                TestsListBox.Items.Add(test.TestName);
            }

        }

        private void CreateNewTestButton_Click(object sender, EventArgs e)
        {
            CreateTestMainForm createTestMainForm = new CreateTestMainForm();
            createTestMainForm.ShowDialog();
        }

        private void StartAllQuestionsButton_Click(object sender, EventArgs e)
        {
            TestForm TestForm = new TestForm();
            TestForm.ShowDialog();
        }
        private void TestsListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            foreach (var test in Globals.LoadedTests)
            {
                if(TestsListBox.SelectedItem != null) 
                {
                    if (test.TestName == TestsListBox.SelectedItem.ToString())
                    {
                        Globals.CurrentActiveTest = test;
                        SelectedTestName.Text = test.TestName;
                        SelectedAmountOfQuestions.Text = test.Questions.Count().ToString();
                        SelectedCorrectPercentage.Text = test.ProcentageCorrect.ToString();
                        SelectedAmountOfRepetition.Text = test.AmountOfTimesRepeated.ToString();
                        SelectedAmountOfArchivedQuestions.Text = test.ArchivedQuestions.Count().ToString();
                        SelectedAmountOfWeakQuestions.Text = test.WeakQuestions.Count().ToString();
                    }
                }          
            }
        }

    }
}

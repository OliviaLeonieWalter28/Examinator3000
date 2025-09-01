using Examinator3000.Helper;
using System.Windows.Forms;

namespace Examinator3000
{
    public partial class Examinator3000Main : Form
    {
        // Static reference to the active instance
        public static Examinator3000Main Instance { get; private set; }
        public Examinator3000Main()
        {
            InitializeComponent();
            Globals.AddTestTest();
            FileWriter.LoadTests();
            foreach (var test in Globals.LoadedTests)
            {
                TestsListBox.Items.Add(test.TestName);
            }
            Instance = this;

        }

        private void CreateNewTestButton_Click(object sender, EventArgs e)
        {
            CreateTestMainForm createTestMainForm = new CreateTestMainForm();
            createTestMainForm.ShowDialog();
        }

        private void StartAllQuestionsButton_Click(object sender, EventArgs e)
        {
            if (TestsListBox.SelectedItem != null)
            {
                TestForm TestForm = new TestForm();
                TestForm.ShowDialog();
            }
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
        public void ReloadTests()
        {
            FileWriter.LoadTests();

            // Refresh ListBox
            TestsListBox.Items.Clear();
            foreach (var test in Globals.LoadedTests)
            {
                TestsListBox.Items.Add(test.TestName);
            }

            TestsListBox.SelectedItem = TestsListBox.Items[1];

            foreach (var test in Globals.LoadedTests)
            {
                if (TestsListBox.SelectedItem != null)
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

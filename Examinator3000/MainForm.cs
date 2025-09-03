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

            FileWriter.LoadTests();

            TestsListBox.DataSource = Globals.LoadedTests;
            TestsListBox.DisplayMember = "TestName";

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
                Globals.ActiveTestMode = Globals.TestMode.QuestionsWithoutArchived;
                TestForm TestForm = new TestForm();
                TestForm.ShowDialog();
            }
        }
        private void TestsListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            foreach (var test in Globals.LoadedTests)
            {
                if (TestsListBox.SelectedItem != null)
                {
                    if (test.TestName == TestsListBox.GetItemText(TestsListBox.SelectedItem))
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

        private void EditTestButton_Click(object sender, EventArgs e)
        {
            CreateTestForm createTestForm = new CreateTestForm();
            createTestForm.ShowDialog();
        }

        private void StartArchivedQuestionsButton_Click(object sender, EventArgs e)
        {
            if (TestsListBox.SelectedItem != null)
            {
                Globals.ActiveTestMode = Globals.TestMode.ArchivedQuestions;
                TestForm TestForm = new TestForm();
                TestForm.ShowDialog();
            }
        }
    }
}

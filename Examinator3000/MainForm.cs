namespace Examinator3000
{
    public partial class Examinator3000Main : Form
    {
        public Examinator3000Main()
        {
            InitializeComponent();
        }

        private void CreateNewTestButton_Click(object sender, EventArgs e)
        {
           CreateTestMainForm createTestMainForm = new CreateTestMainForm();
           createTestMainForm.ShowDialog();
        }
    }
}

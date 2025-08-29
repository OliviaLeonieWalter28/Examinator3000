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
    public partial class CreateTestMainForm : Form
    {
        public CreateTestMainForm()
        {
            InitializeComponent();
        }

        private void AddQuestionsToTestButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TestNameTextBox.Text)) 
            {
                Globals.AddTest(TestNameTextBox.Text);
                CreateTestForm createTestForm = new CreateTestForm();
                createTestForm.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Invalid Test Name!");
            }
        }
    }
}

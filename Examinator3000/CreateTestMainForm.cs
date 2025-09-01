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
                foreach(var test in Globals.LoadedTests) 
                {
                    if(test.TestName == TestNameTextBox.Text) 
                    {
                        MessageBox.Show("A Test with this name already exists, please choose another name!");
                        break;
                    }
                }



                Globals.AddTest(TestNameTextBox.Text);
                string imagesRoot = Path.Combine(Application.StartupPath, "Images");
                string testImagesFolder = Path.Combine(imagesRoot, $"Images{TestNameTextBox.Text}");

                if (!Directory.Exists(imagesRoot))
                {
                    Directory.CreateDirectory(imagesRoot);
                }
                if (!Directory.Exists(testImagesFolder))
                {
                    Directory.CreateDirectory(testImagesFolder);
                }


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

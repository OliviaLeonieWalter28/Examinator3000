namespace Examinator3000
{
    partial class Examinator3000Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TestsListBox = new ListBox();
            CreateNewTestButton = new Button();
            StartAllQuestionsButton = new Button();
            colorDialog1 = new ColorDialog();
            TestNameLabel = new Label();
            StartArchivedQuestionsButton = new Button();
            StartWeakQuestionsButton = new Button();
            StartMixedQuestionsButton = new Button();
            AmountOfQuestionsLabel = new Label();
            CorrectPrecentageLabel = new Label();
            AmountOfRepetitionsLabel = new Label();
            AmountOfArchivedQuestionsLabel = new Label();
            panel1 = new Panel();
            SelectedAmountOfWeakQuestions = new Label();
            AmountOfWeakQuestionsLabel = new Label();
            SelectedAmountOfArchivedQuestions = new Label();
            SelectedAmountOfRepetition = new Label();
            SelectedCorrectPercentage = new Label();
            SelectedAmountOfQuestions = new Label();
            SelectedTestName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TestsListBox
            // 
            TestsListBox.FormattingEnabled = true;
            TestsListBox.ItemHeight = 15;
            TestsListBox.Location = new Point(42, 69);
            TestsListBox.Name = "TestsListBox";
            TestsListBox.Size = new Size(499, 709);
            TestsListBox.TabIndex = 0;
            TestsListBox.SelectedIndexChanged += TestsListBox_SelectedIndexChanged;
            // 
            // CreateNewTestButton
            // 
            CreateNewTestButton.BackColor = Color.FromArgb(225, 137, 59);
            CreateNewTestButton.FlatStyle = FlatStyle.Popup;
            CreateNewTestButton.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateNewTestButton.Location = new Point(42, 818);
            CreateNewTestButton.Name = "CreateNewTestButton";
            CreateNewTestButton.Size = new Size(499, 118);
            CreateNewTestButton.TabIndex = 1;
            CreateNewTestButton.Text = "Create New Test";
            CreateNewTestButton.UseVisualStyleBackColor = false;
            CreateNewTestButton.Click += CreateNewTestButton_Click;
            // 
            // StartAllQuestionsButton
            // 
            StartAllQuestionsButton.BackColor = Color.FromArgb(0, 75, 98);
            StartAllQuestionsButton.FlatStyle = FlatStyle.Popup;
            StartAllQuestionsButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartAllQuestionsButton.ForeColor = SystemColors.Control;
            StartAllQuestionsButton.Location = new Point(690, 818);
            StartAllQuestionsButton.Name = "StartAllQuestionsButton";
            StartAllQuestionsButton.Size = new Size(236, 118);
            StartAllQuestionsButton.TabIndex = 2;
            StartAllQuestionsButton.Text = "Start - All Questions";
            StartAllQuestionsButton.UseVisualStyleBackColor = false;
            StartAllQuestionsButton.Click += StartAllQuestionsButton_Click;
            // 
            // TestNameLabel
            // 
            TestNameLabel.AutoSize = true;
            TestNameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TestNameLabel.ForeColor = SystemColors.Control;
            TestNameLabel.Location = new Point(31, 85);
            TestNameLabel.Name = "TestNameLabel";
            TestNameLabel.Size = new Size(124, 25);
            TestNameLabel.TabIndex = 3;
            TestNameLabel.Text = "Testname:";
            // 
            // StartArchivedQuestionsButton
            // 
            StartArchivedQuestionsButton.BackColor = Color.FromArgb(0, 75, 98);
            StartArchivedQuestionsButton.FlatStyle = FlatStyle.Popup;
            StartArchivedQuestionsButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartArchivedQuestionsButton.ForeColor = SystemColors.Control;
            StartArchivedQuestionsButton.Location = new Point(950, 818);
            StartArchivedQuestionsButton.Name = "StartArchivedQuestionsButton";
            StartArchivedQuestionsButton.Size = new Size(236, 118);
            StartArchivedQuestionsButton.TabIndex = 4;
            StartArchivedQuestionsButton.Text = "Start - Archived Questions";
            StartArchivedQuestionsButton.UseVisualStyleBackColor = false;
            // 
            // StartWeakQuestionsButton
            // 
            StartWeakQuestionsButton.BackColor = Color.FromArgb(0, 75, 98);
            StartWeakQuestionsButton.FlatStyle = FlatStyle.Popup;
            StartWeakQuestionsButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartWeakQuestionsButton.ForeColor = SystemColors.Control;
            StartWeakQuestionsButton.Location = new Point(1211, 818);
            StartWeakQuestionsButton.Name = "StartWeakQuestionsButton";
            StartWeakQuestionsButton.Size = new Size(236, 118);
            StartWeakQuestionsButton.TabIndex = 5;
            StartWeakQuestionsButton.Text = "Start - Weak Questions";
            StartWeakQuestionsButton.UseVisualStyleBackColor = false;
            // 
            // StartMixedQuestionsButton
            // 
            StartMixedQuestionsButton.BackColor = Color.FromArgb(0, 75, 98);
            StartMixedQuestionsButton.FlatStyle = FlatStyle.Popup;
            StartMixedQuestionsButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartMixedQuestionsButton.ForeColor = SystemColors.Control;
            StartMixedQuestionsButton.Location = new Point(1473, 818);
            StartMixedQuestionsButton.Name = "StartMixedQuestionsButton";
            StartMixedQuestionsButton.Size = new Size(236, 118);
            StartMixedQuestionsButton.TabIndex = 6;
            StartMixedQuestionsButton.Text = "Start - Mixed Questions";
            StartMixedQuestionsButton.UseVisualStyleBackColor = false;
            // 
            // AmountOfQuestionsLabel
            // 
            AmountOfQuestionsLabel.AutoSize = true;
            AmountOfQuestionsLabel.Font = new Font("Verdana", 15.75F);
            AmountOfQuestionsLabel.ForeColor = SystemColors.Control;
            AmountOfQuestionsLabel.Location = new Point(31, 169);
            AmountOfQuestionsLabel.Name = "AmountOfQuestionsLabel";
            AmountOfQuestionsLabel.Size = new Size(242, 25);
            AmountOfQuestionsLabel.TabIndex = 7;
            AmountOfQuestionsLabel.Text = "Amount of Questions:";
            // 
            // CorrectPrecentageLabel
            // 
            CorrectPrecentageLabel.AutoSize = true;
            CorrectPrecentageLabel.Font = new Font("Verdana", 15.75F);
            CorrectPrecentageLabel.ForeColor = SystemColors.Control;
            CorrectPrecentageLabel.Location = new Point(31, 261);
            CorrectPrecentageLabel.Name = "CorrectPrecentageLabel";
            CorrectPrecentageLabel.Size = new Size(225, 25);
            CorrectPrecentageLabel.TabIndex = 8;
            CorrectPrecentageLabel.Text = "Correct Percentage:";
            // 
            // AmountOfRepetitionsLabel
            // 
            AmountOfRepetitionsLabel.AutoSize = true;
            AmountOfRepetitionsLabel.Font = new Font("Verdana", 15.75F);
            AmountOfRepetitionsLabel.ForeColor = SystemColors.Control;
            AmountOfRepetitionsLabel.Location = new Point(31, 355);
            AmountOfRepetitionsLabel.Name = "AmountOfRepetitionsLabel";
            AmountOfRepetitionsLabel.Size = new Size(255, 25);
            AmountOfRepetitionsLabel.TabIndex = 9;
            AmountOfRepetitionsLabel.Text = "Amount of Repetitions:";
            // 
            // AmountOfArchivedQuestionsLabel
            // 
            AmountOfArchivedQuestionsLabel.AutoSize = true;
            AmountOfArchivedQuestionsLabel.Font = new Font("Verdana", 15.75F);
            AmountOfArchivedQuestionsLabel.ForeColor = SystemColors.Control;
            AmountOfArchivedQuestionsLabel.Location = new Point(31, 447);
            AmountOfArchivedQuestionsLabel.Name = "AmountOfArchivedQuestionsLabel";
            AmountOfArchivedQuestionsLabel.Size = new Size(340, 25);
            AmountOfArchivedQuestionsLabel.TabIndex = 10;
            AmountOfArchivedQuestionsLabel.Text = "Amount of Archived Questions:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 90);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(SelectedAmountOfWeakQuestions);
            panel1.Controls.Add(AmountOfWeakQuestionsLabel);
            panel1.Controls.Add(SelectedAmountOfArchivedQuestions);
            panel1.Controls.Add(SelectedAmountOfRepetition);
            panel1.Controls.Add(SelectedCorrectPercentage);
            panel1.Controls.Add(SelectedAmountOfQuestions);
            panel1.Controls.Add(SelectedTestName);
            panel1.Controls.Add(AmountOfArchivedQuestionsLabel);
            panel1.Controls.Add(TestNameLabel);
            panel1.Controls.Add(AmountOfRepetitionsLabel);
            panel1.Controls.Add(AmountOfQuestionsLabel);
            panel1.Controls.Add(CorrectPrecentageLabel);
            panel1.Location = new Point(690, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 709);
            panel1.TabIndex = 1;
            // 
            // SelectedAmountOfWeakQuestions
            // 
            SelectedAmountOfWeakQuestions.AutoSize = true;
            SelectedAmountOfWeakQuestions.Font = new Font("Verdana", 15.75F);
            SelectedAmountOfWeakQuestions.ForeColor = SystemColors.Control;
            SelectedAmountOfWeakQuestions.Location = new Point(344, 528);
            SelectedAmountOfWeakQuestions.Name = "SelectedAmountOfWeakQuestions";
            SelectedAmountOfWeakQuestions.Size = new Size(0, 25);
            SelectedAmountOfWeakQuestions.TabIndex = 17;
            // 
            // AmountOfWeakQuestionsLabel
            // 
            AmountOfWeakQuestionsLabel.AutoSize = true;
            AmountOfWeakQuestionsLabel.Font = new Font("Verdana", 15.75F);
            AmountOfWeakQuestionsLabel.ForeColor = SystemColors.Control;
            AmountOfWeakQuestionsLabel.Location = new Point(31, 528);
            AmountOfWeakQuestionsLabel.Name = "AmountOfWeakQuestionsLabel";
            AmountOfWeakQuestionsLabel.Size = new Size(307, 25);
            AmountOfWeakQuestionsLabel.TabIndex = 16;
            AmountOfWeakQuestionsLabel.Text = "Amount of Weak Questions:";
            // 
            // SelectedAmountOfArchivedQuestions
            // 
            SelectedAmountOfArchivedQuestions.AutoSize = true;
            SelectedAmountOfArchivedQuestions.Font = new Font("Verdana", 15.75F);
            SelectedAmountOfArchivedQuestions.ForeColor = SystemColors.Control;
            SelectedAmountOfArchivedQuestions.Location = new Point(377, 447);
            SelectedAmountOfArchivedQuestions.Name = "SelectedAmountOfArchivedQuestions";
            SelectedAmountOfArchivedQuestions.Size = new Size(0, 25);
            SelectedAmountOfArchivedQuestions.TabIndex = 15;
            // 
            // SelectedAmountOfRepetition
            // 
            SelectedAmountOfRepetition.AutoSize = true;
            SelectedAmountOfRepetition.Font = new Font("Verdana", 15.75F);
            SelectedAmountOfRepetition.ForeColor = SystemColors.Control;
            SelectedAmountOfRepetition.Location = new Point(295, 355);
            SelectedAmountOfRepetition.Name = "SelectedAmountOfRepetition";
            SelectedAmountOfRepetition.Size = new Size(0, 25);
            SelectedAmountOfRepetition.TabIndex = 14;
            // 
            // SelectedCorrectPercentage
            // 
            SelectedCorrectPercentage.AutoSize = true;
            SelectedCorrectPercentage.Font = new Font("Verdana", 15.75F);
            SelectedCorrectPercentage.ForeColor = SystemColors.Control;
            SelectedCorrectPercentage.Location = new Point(262, 261);
            SelectedCorrectPercentage.Name = "SelectedCorrectPercentage";
            SelectedCorrectPercentage.Size = new Size(0, 25);
            SelectedCorrectPercentage.TabIndex = 13;
            // 
            // SelectedAmountOfQuestions
            // 
            SelectedAmountOfQuestions.AutoSize = true;
            SelectedAmountOfQuestions.Font = new Font("Verdana", 15.75F);
            SelectedAmountOfQuestions.ForeColor = SystemColors.Control;
            SelectedAmountOfQuestions.Location = new Point(279, 169);
            SelectedAmountOfQuestions.Name = "SelectedAmountOfQuestions";
            SelectedAmountOfQuestions.Size = new Size(0, 25);
            SelectedAmountOfQuestions.TabIndex = 12;
            // 
            // SelectedTestName
            // 
            SelectedTestName.AutoSize = true;
            SelectedTestName.Font = new Font("Verdana", 15.75F);
            SelectedTestName.ForeColor = SystemColors.Control;
            SelectedTestName.Location = new Point(159, 85);
            SelectedTestName.Name = "SelectedTestName";
            SelectedTestName.Size = new Size(0, 25);
            SelectedTestName.TabIndex = 11;
            // 
            // Examinator3000Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 59, 76);
            ClientSize = new Size(1822, 971);
            Controls.Add(panel1);
            Controls.Add(StartMixedQuestionsButton);
            Controls.Add(StartWeakQuestionsButton);
            Controls.Add(StartArchivedQuestionsButton);
            Controls.Add(StartAllQuestionsButton);
            Controls.Add(CreateNewTestButton);
            Controls.Add(TestsListBox);
            Name = "Examinator3000Main";
            Text = "Examinator3000Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox TestsListBox;
        private Button CreateNewTestButton;
        private Button StartAllQuestionsButton;
        private ColorDialog colorDialog1;
        private Label TestNameLabel;
        private Button StartArchivedQuestionsButton;
        private Button StartWeakQuestionsButton;
        private Button StartMixedQuestionsButton;
        private Label AmountOfQuestionsLabel;
        private Label CorrectPrecentageLabel;
        private Label AmountOfRepetitionsLabel;
        private Label AmountOfArchivedQuestionsLabel;
        private Panel panel1;
        private Label SelectedAmountOfArchivedQuestions;
        private Label SelectedAmountOfRepetition;
        private Label SelectedCorrectPercentage;
        private Label SelectedAmountOfQuestions;
        private Label SelectedTestName;
        private Label AmountOfWeakQuestionsLabel;
        private Label SelectedAmountOfWeakQuestions;
    }
}

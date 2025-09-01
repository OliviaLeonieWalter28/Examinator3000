namespace Examinator3000
{
    partial class TestSummeryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BackToMainButton = new Button();
            QuestionsCorrectLabel = new Label();
            TestnameLabel = new Label();
            IncorrectQuestionLabel = new Label();
            PrecentageCorrectLabel = new Label();
            QuestionsCorrectDataLabel = new Label();
            IncorrectQuestionsDataLabel = new Label();
            CorrectPercentageDataLabel = new Label();
            AmountOfWeakQuestionsLabel = new Label();
            AmountOfWeakQuestionsDataLabel = new Label();
            SuspendLayout();
            // 
            // BackToMainButton
            // 
            BackToMainButton.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackToMainButton.Location = new Point(471, 444);
            BackToMainButton.Name = "BackToMainButton";
            BackToMainButton.Size = new Size(222, 64);
            BackToMainButton.TabIndex = 0;
            BackToMainButton.Text = "Back to main";
            BackToMainButton.UseVisualStyleBackColor = true;
            BackToMainButton.Click += BackToMainButton_Click;
            // 
            // QuestionsCorrectLabel
            // 
            QuestionsCorrectLabel.AutoSize = true;
            QuestionsCorrectLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuestionsCorrectLabel.ForeColor = SystemColors.Control;
            QuestionsCorrectLabel.Location = new Point(382, 166);
            QuestionsCorrectLabel.Name = "QuestionsCorrectLabel";
            QuestionsCorrectLabel.Size = new Size(212, 25);
            QuestionsCorrectLabel.TabIndex = 1;
            QuestionsCorrectLabel.Text = "Correct Questions:";
            // 
            // TestnameLabel
            // 
            TestnameLabel.AutoSize = true;
            TestnameLabel.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TestnameLabel.ForeColor = SystemColors.Control;
            TestnameLabel.Location = new Point(495, 92);
            TestnameLabel.Name = "TestnameLabel";
            TestnameLabel.Size = new Size(188, 35);
            TestnameLabel.TabIndex = 2;
            TestnameLabel.Text = "Test Name";
            // 
            // IncorrectQuestionLabel
            // 
            IncorrectQuestionLabel.AutoSize = true;
            IncorrectQuestionLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncorrectQuestionLabel.ForeColor = SystemColors.Control;
            IncorrectQuestionLabel.Location = new Point(382, 230);
            IncorrectQuestionLabel.Name = "IncorrectQuestionLabel";
            IncorrectQuestionLabel.Size = new Size(229, 25);
            IncorrectQuestionLabel.TabIndex = 3;
            IncorrectQuestionLabel.Text = "Incorrect Questions:";
            // 
            // PrecentageCorrectLabel
            // 
            PrecentageCorrectLabel.AutoSize = true;
            PrecentageCorrectLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecentageCorrectLabel.ForeColor = SystemColors.Control;
            PrecentageCorrectLabel.Location = new Point(385, 289);
            PrecentageCorrectLabel.Name = "PrecentageCorrectLabel";
            PrecentageCorrectLabel.Size = new Size(225, 25);
            PrecentageCorrectLabel.TabIndex = 4;
            PrecentageCorrectLabel.Text = "Percentage Correct:";
            // 
            // QuestionsCorrectDataLabel
            // 
            QuestionsCorrectDataLabel.AutoSize = true;
            QuestionsCorrectDataLabel.Font = new Font("Verdana", 15.75F);
            QuestionsCorrectDataLabel.ForeColor = SystemColors.Control;
            QuestionsCorrectDataLabel.Location = new Point(699, 166);
            QuestionsCorrectDataLabel.Name = "QuestionsCorrectDataLabel";
            QuestionsCorrectDataLabel.Size = new Size(38, 25);
            QuestionsCorrectDataLabel.TabIndex = 5;
            QuestionsCorrectDataLabel.Text = "20";
            // 
            // IncorrectQuestionsDataLabel
            // 
            IncorrectQuestionsDataLabel.AutoSize = true;
            IncorrectQuestionsDataLabel.Font = new Font("Verdana", 15.75F);
            IncorrectQuestionsDataLabel.ForeColor = SystemColors.Control;
            IncorrectQuestionsDataLabel.Location = new Point(699, 230);
            IncorrectQuestionsDataLabel.Name = "IncorrectQuestionsDataLabel";
            IncorrectQuestionsDataLabel.Size = new Size(38, 25);
            IncorrectQuestionsDataLabel.TabIndex = 6;
            IncorrectQuestionsDataLabel.Text = "20";
            // 
            // CorrectPercentageDataLabel
            // 
            CorrectPercentageDataLabel.AutoSize = true;
            CorrectPercentageDataLabel.Font = new Font("Verdana", 15.75F);
            CorrectPercentageDataLabel.ForeColor = SystemColors.Control;
            CorrectPercentageDataLabel.Location = new Point(699, 289);
            CorrectPercentageDataLabel.Name = "CorrectPercentageDataLabel";
            CorrectPercentageDataLabel.Size = new Size(38, 25);
            CorrectPercentageDataLabel.TabIndex = 7;
            CorrectPercentageDataLabel.Text = "20";
            // 
            // AmountOfWeakQuestionsLabel
            // 
            AmountOfWeakQuestionsLabel.AutoSize = true;
            AmountOfWeakQuestionsLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountOfWeakQuestionsLabel.ForeColor = SystemColors.Control;
            AmountOfWeakQuestionsLabel.Location = new Point(382, 349);
            AmountOfWeakQuestionsLabel.Name = "AmountOfWeakQuestionsLabel";
            AmountOfWeakQuestionsLabel.Size = new Size(311, 25);
            AmountOfWeakQuestionsLabel.TabIndex = 8;
            AmountOfWeakQuestionsLabel.Text = "Amount Of Weak Questions:";
            // 
            // AmountOfWeakQuestionsDataLabel
            // 
            AmountOfWeakQuestionsDataLabel.AutoSize = true;
            AmountOfWeakQuestionsDataLabel.Font = new Font("Verdana", 15.75F);
            AmountOfWeakQuestionsDataLabel.ForeColor = SystemColors.Control;
            AmountOfWeakQuestionsDataLabel.Location = new Point(699, 349);
            AmountOfWeakQuestionsDataLabel.Name = "AmountOfWeakQuestionsDataLabel";
            AmountOfWeakQuestionsDataLabel.Size = new Size(38, 25);
            AmountOfWeakQuestionsDataLabel.TabIndex = 9;
            AmountOfWeakQuestionsDataLabel.Text = "20";
            // 
            // TestSummeryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 59, 76);
            ClientSize = new Size(1179, 563);
            Controls.Add(AmountOfWeakQuestionsDataLabel);
            Controls.Add(AmountOfWeakQuestionsLabel);
            Controls.Add(CorrectPercentageDataLabel);
            Controls.Add(IncorrectQuestionsDataLabel);
            Controls.Add(QuestionsCorrectDataLabel);
            Controls.Add(PrecentageCorrectLabel);
            Controls.Add(IncorrectQuestionLabel);
            Controls.Add(TestnameLabel);
            Controls.Add(QuestionsCorrectLabel);
            Controls.Add(BackToMainButton);
            Name = "TestSummeryForm";
            Text = "TestSummeryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackToMainButton;
        private Label QuestionsCorrectLabel;
        private Label TestnameLabel;
        private Label IncorrectQuestionLabel;
        private Label PrecentageCorrectLabel;
        private Label QuestionsCorrectDataLabel;
        private Label IncorrectQuestionsDataLabel;
        private Label CorrectPercentageDataLabel;
        private Label AmountOfWeakQuestionsLabel;
        private Label AmountOfWeakQuestionsDataLabel;
    }
}
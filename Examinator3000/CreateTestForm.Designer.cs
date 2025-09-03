namespace Examinator3000
{
    partial class CreateTestForm
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
            QuestionsListBox = new ListBox();
            panel1 = new Panel();
            AddQuestionButton = new Button();
            AnswersListBox = new ListBox();
            PicturePreviewPictureBox = new PictureBox();
            panel2 = new Panel();
            ImagePathTextBox = new TextBox();
            ImagePathLabel = new Label();
            TextAboveImageLabel = new Label();
            TextAboveImageRichTextBox = new RichTextBox();
            panel4 = new Panel();
            IsPictureQuestionCheckBox = new CheckBox();
            panel3 = new Panel();
            AnswerImagePathTextBox = new TextBox();
            AnswerImagePathLabel = new Label();
            AddAnswerButton = new Button();
            HasImageAnswerCheckBox = new CheckBox();
            IsCorrectAnswerCheckBox = new CheckBox();
            AnswerTextRichTextBox = new RichTextBox();
            AnswerTextLabel = new Label();
            QuestionLabel = new Label();
            AnswerLabel = new Label();
            ImagePreviewLabel = new Label();
            QuestionsLabel = new Label();
            AnswersLabel = new Label();
            ImagePreviewAnswerLabel = new Label();
            AnswerPictureBox = new PictureBox();
            DeleteQuestionButton = new Button();
            DeleteAnswerButton = new Button();
            FinishTestButton = new Button();
            EditAnswerButton = new Button();
            EditQuestionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PicturePreviewPictureBox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnswerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // QuestionsListBox
            // 
            QuestionsListBox.FormattingEnabled = true;
            QuestionsListBox.ItemHeight = 15;
            QuestionsListBox.Location = new Point(1471, 60);
            QuestionsListBox.Name = "QuestionsListBox";
            QuestionsListBox.Size = new Size(228, 814);
            QuestionsListBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 137, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(1418, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 982);
            panel1.TabIndex = 1;
            // 
            // AddQuestionButton
            // 
            AddQuestionButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddQuestionButton.Location = new Point(1471, 880);
            AddQuestionButton.Name = "AddQuestionButton";
            AddQuestionButton.Size = new Size(228, 71);
            AddQuestionButton.TabIndex = 2;
            AddQuestionButton.Text = "Add Question";
            AddQuestionButton.UseVisualStyleBackColor = true;
            AddQuestionButton.Click += AddQuestionButton_Click;
            // 
            // AnswersListBox
            // 
            AnswersListBox.FormattingEnabled = true;
            AnswersListBox.ItemHeight = 15;
            AnswersListBox.Location = new Point(854, 665);
            AnswersListBox.Name = "AnswersListBox";
            AnswersListBox.Size = new Size(530, 319);
            AnswersListBox.TabIndex = 3;
            // 
            // PicturePreviewPictureBox
            // 
            PicturePreviewPictureBox.Location = new Point(854, 57);
            PicturePreviewPictureBox.Name = "PicturePreviewPictureBox";
            PicturePreviewPictureBox.Size = new Size(530, 242);
            PicturePreviewPictureBox.TabIndex = 4;
            PicturePreviewPictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 90);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(ImagePathTextBox);
            panel2.Controls.Add(ImagePathLabel);
            panel2.Controls.Add(TextAboveImageLabel);
            panel2.Controls.Add(TextAboveImageRichTextBox);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(IsPictureQuestionCheckBox);
            panel2.Location = new Point(25, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 553);
            panel2.TabIndex = 5;
            // 
            // ImagePathTextBox
            // 
            ImagePathTextBox.Location = new Point(143, 342);
            ImagePathTextBox.Name = "ImagePathTextBox";
            ImagePathTextBox.Size = new Size(638, 23);
            ImagePathTextBox.TabIndex = 5;
            ImagePathTextBox.TextChanged += ImagePathTextBox_TextChanged;
            // 
            // ImagePathLabel
            // 
            ImagePathLabel.AutoSize = true;
            ImagePathLabel.Font = new Font("Verdana", 9.75F);
            ImagePathLabel.ForeColor = SystemColors.Control;
            ImagePathLabel.Location = new Point(11, 344);
            ImagePathLabel.Name = "ImagePathLabel";
            ImagePathLabel.Size = new Size(94, 16);
            ImagePathLabel.TabIndex = 4;
            ImagePathLabel.Text = "Image Name:";
            // 
            // TextAboveImageLabel
            // 
            TextAboveImageLabel.AutoSize = true;
            TextAboveImageLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextAboveImageLabel.ForeColor = SystemColors.Control;
            TextAboveImageLabel.Location = new Point(11, 89);
            TextAboveImageLabel.Name = "TextAboveImageLabel";
            TextAboveImageLabel.Size = new Size(133, 16);
            TextAboveImageLabel.TabIndex = 3;
            TextAboveImageLabel.Text = "Text Above Image:";
            // 
            // TextAboveImageRichTextBox
            // 
            TextAboveImageRichTextBox.Location = new Point(143, 89);
            TextAboveImageRichTextBox.Name = "TextAboveImageRichTextBox";
            TextAboveImageRichTextBox.Size = new Size(638, 247);
            TextAboveImageRichTextBox.TabIndex = 2;
            TextAboveImageRichTextBox.Text = "";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(225, 137, 59);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(17, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(764, 12);
            panel4.TabIndex = 1;
            // 
            // IsPictureQuestionCheckBox
            // 
            IsPictureQuestionCheckBox.AutoSize = true;
            IsPictureQuestionCheckBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsPictureQuestionCheckBox.ForeColor = SystemColors.Control;
            IsPictureQuestionCheckBox.Location = new Point(17, 20);
            IsPictureQuestionCheckBox.Name = "IsPictureQuestionCheckBox";
            IsPictureQuestionCheckBox.Size = new Size(185, 22);
            IsPictureQuestionCheckBox.TabIndex = 0;
            IsPictureQuestionCheckBox.Text = "Is Picture Question";
            IsPictureQuestionCheckBox.UseVisualStyleBackColor = true;
            IsPictureQuestionCheckBox.CheckedChanged += IsPictureQuestionCheckBox_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 137, 59);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(AnswerImagePathTextBox);
            panel3.Controls.Add(AnswerImagePathLabel);
            panel3.Controls.Add(AddAnswerButton);
            panel3.Controls.Add(HasImageAnswerCheckBox);
            panel3.Controls.Add(IsCorrectAnswerCheckBox);
            panel3.Controls.Add(AnswerTextRichTextBox);
            panel3.Controls.Add(AnswerTextLabel);
            panel3.Location = new Point(25, 665);
            panel3.Name = "panel3";
            panel3.Size = new Size(808, 319);
            panel3.TabIndex = 6;
            // 
            // AnswerImagePathTextBox
            // 
            AnswerImagePathTextBox.Location = new Point(143, 204);
            AnswerImagePathTextBox.Name = "AnswerImagePathTextBox";
            AnswerImagePathTextBox.Size = new Size(638, 23);
            AnswerImagePathTextBox.TabIndex = 6;
            AnswerImagePathTextBox.TextChanged += AnswerImagePathTextBox_TextChanged;
            // 
            // AnswerImagePathLabel
            // 
            AnswerImagePathLabel.AutoSize = true;
            AnswerImagePathLabel.Font = new Font("Verdana", 9.75F);
            AnswerImagePathLabel.Location = new Point(11, 211);
            AnswerImagePathLabel.Name = "AnswerImagePathLabel";
            AnswerImagePathLabel.Size = new Size(94, 16);
            AnswerImagePathLabel.TabIndex = 5;
            AnswerImagePathLabel.Text = "Image Name:";
            // 
            // AddAnswerButton
            // 
            AddAnswerButton.Font = new Font("Verdana", 14.25F);
            AddAnswerButton.Location = new Point(556, 244);
            AddAnswerButton.Name = "AddAnswerButton";
            AddAnswerButton.Size = new Size(225, 55);
            AddAnswerButton.TabIndex = 4;
            AddAnswerButton.Text = "Add Answer";
            AddAnswerButton.UseVisualStyleBackColor = true;
            AddAnswerButton.Click += AddAnswerButton_Click;
            // 
            // HasImageAnswerCheckBox
            // 
            HasImageAnswerCheckBox.AutoSize = true;
            HasImageAnswerCheckBox.Font = new Font("Verdana", 9.75F);
            HasImageAnswerCheckBox.Location = new Point(11, 254);
            HasImageAnswerCheckBox.Name = "HasImageAnswerCheckBox";
            HasImageAnswerCheckBox.Size = new Size(148, 20);
            HasImageAnswerCheckBox.TabIndex = 3;
            HasImageAnswerCheckBox.Text = "Has Image Answer";
            HasImageAnswerCheckBox.UseVisualStyleBackColor = true;
            HasImageAnswerCheckBox.CheckedChanged += HasImageAnswerCheckBox_CheckedChanged;
            // 
            // IsCorrectAnswerCheckBox
            // 
            IsCorrectAnswerCheckBox.AutoSize = true;
            IsCorrectAnswerCheckBox.Font = new Font("Verdana", 9.75F);
            IsCorrectAnswerCheckBox.Location = new Point(11, 279);
            IsCorrectAnswerCheckBox.Name = "IsCorrectAnswerCheckBox";
            IsCorrectAnswerCheckBox.Size = new Size(145, 20);
            IsCorrectAnswerCheckBox.TabIndex = 2;
            IsCorrectAnswerCheckBox.Text = "Is Correct Answer";
            IsCorrectAnswerCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnswerTextRichTextBox
            // 
            AnswerTextRichTextBox.Location = new Point(143, 17);
            AnswerTextRichTextBox.Name = "AnswerTextRichTextBox";
            AnswerTextRichTextBox.Size = new Size(638, 177);
            AnswerTextRichTextBox.TabIndex = 1;
            AnswerTextRichTextBox.Text = "";
            // 
            // AnswerTextLabel
            // 
            AnswerTextLabel.AutoSize = true;
            AnswerTextLabel.Font = new Font("Verdana", 9.75F);
            AnswerTextLabel.Location = new Point(11, 19);
            AnswerTextLabel.Name = "AnswerTextLabel";
            AnswerTextLabel.Size = new Size(95, 16);
            AnswerTextLabel.TabIndex = 0;
            AnswerTextLabel.Text = "Answer Text:";
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionLabel.ForeColor = SystemColors.Control;
            QuestionLabel.Location = new Point(25, 19);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(117, 25);
            QuestionLabel.TabIndex = 7;
            QuestionLabel.Text = "Question";
            // 
            // AnswerLabel
            // 
            AnswerLabel.AutoSize = true;
            AnswerLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnswerLabel.ForeColor = SystemColors.Control;
            AnswerLabel.Location = new Point(25, 620);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.Size = new Size(100, 25);
            AnswerLabel.TabIndex = 8;
            AnswerLabel.Text = "Answer";
            // 
            // ImagePreviewLabel
            // 
            ImagePreviewLabel.AutoSize = true;
            ImagePreviewLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ImagePreviewLabel.ForeColor = SystemColors.Control;
            ImagePreviewLabel.Location = new Point(854, 19);
            ImagePreviewLabel.Name = "ImagePreviewLabel";
            ImagePreviewLabel.Size = new Size(319, 25);
            ImagePreviewLabel.TabIndex = 9;
            ImagePreviewLabel.Text = "Image Preview - Question";
            // 
            // QuestionsLabel
            // 
            QuestionsLabel.AutoSize = true;
            QuestionsLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionsLabel.ForeColor = SystemColors.Control;
            QuestionsLabel.Location = new Point(1471, 19);
            QuestionsLabel.Name = "QuestionsLabel";
            QuestionsLabel.Size = new Size(129, 25);
            QuestionsLabel.TabIndex = 10;
            QuestionsLabel.Text = "Questions";
            // 
            // AnswersLabel
            // 
            AnswersLabel.AutoSize = true;
            AnswersLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            AnswersLabel.ForeColor = SystemColors.Control;
            AnswersLabel.Location = new Point(854, 620);
            AnswersLabel.Name = "AnswersLabel";
            AnswersLabel.Size = new Size(112, 25);
            AnswersLabel.TabIndex = 11;
            AnswersLabel.Text = "Answers";
            // 
            // ImagePreviewAnswerLabel
            // 
            ImagePreviewAnswerLabel.AutoSize = true;
            ImagePreviewAnswerLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            ImagePreviewAnswerLabel.ForeColor = SystemColors.Control;
            ImagePreviewAnswerLabel.Location = new Point(854, 322);
            ImagePreviewAnswerLabel.Name = "ImagePreviewAnswerLabel";
            ImagePreviewAnswerLabel.Size = new Size(302, 25);
            ImagePreviewAnswerLabel.TabIndex = 12;
            ImagePreviewAnswerLabel.Text = "Image Preview - Answer";
            // 
            // AnswerPictureBox
            // 
            AnswerPictureBox.Location = new Point(854, 369);
            AnswerPictureBox.Name = "AnswerPictureBox";
            AnswerPictureBox.Size = new Size(530, 241);
            AnswerPictureBox.TabIndex = 13;
            AnswerPictureBox.TabStop = false;
            // 
            // DeleteQuestionButton
            // 
            DeleteQuestionButton.BackColor = Color.White;
            DeleteQuestionButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteQuestionButton.ForeColor = Color.Red;
            DeleteQuestionButton.Location = new Point(1655, 16);
            DeleteQuestionButton.Margin = new Padding(0);
            DeleteQuestionButton.Name = "DeleteQuestionButton";
            DeleteQuestionButton.Size = new Size(44, 38);
            DeleteQuestionButton.TabIndex = 14;
            DeleteQuestionButton.Text = "❌";
            DeleteQuestionButton.UseVisualStyleBackColor = false;
            DeleteQuestionButton.Click += DeleteQuestionButton_Click;
            // 
            // DeleteAnswerButton
            // 
            DeleteAnswerButton.BackColor = Color.White;
            DeleteAnswerButton.FlatStyle = FlatStyle.Flat;
            DeleteAnswerButton.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteAnswerButton.ForeColor = Color.Red;
            DeleteAnswerButton.Location = new Point(1349, 957);
            DeleteAnswerButton.Margin = new Padding(0);
            DeleteAnswerButton.Name = "DeleteAnswerButton";
            DeleteAnswerButton.Size = new Size(35, 27);
            DeleteAnswerButton.TabIndex = 7;
            DeleteAnswerButton.Text = "❌";
            DeleteAnswerButton.UseVisualStyleBackColor = false;
            DeleteAnswerButton.Click += DeleteAnswerButton_Click;
            // 
            // FinishTestButton
            // 
            FinishTestButton.Font = new Font("Verdana", 14.25F);
            FinishTestButton.Location = new Point(1471, 957);
            FinishTestButton.Name = "FinishTestButton";
            FinishTestButton.Size = new Size(228, 37);
            FinishTestButton.TabIndex = 15;
            FinishTestButton.Text = "Finish Test";
            FinishTestButton.UseVisualStyleBackColor = true;
            FinishTestButton.Click += FinishTestButton_Click;
            // 
            // EditAnswerButton
            // 
            EditAnswerButton.BackColor = Color.White;
            EditAnswerButton.FlatStyle = FlatStyle.Flat;
            EditAnswerButton.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditAnswerButton.ForeColor = Color.Red;
            EditAnswerButton.Location = new Point(1314, 957);
            EditAnswerButton.Margin = new Padding(0);
            EditAnswerButton.Name = "EditAnswerButton";
            EditAnswerButton.Size = new Size(35, 27);
            EditAnswerButton.TabIndex = 16;
            EditAnswerButton.Text = "✏️";
            EditAnswerButton.UseVisualStyleBackColor = false;
            EditAnswerButton.Click += EditAnswerButton_Click;
            // 
            // EditQuestionButton
            // 
            EditQuestionButton.BackColor = Color.White;
            EditQuestionButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditQuestionButton.ForeColor = Color.Red;
            EditQuestionButton.Location = new Point(1611, 16);
            EditQuestionButton.Margin = new Padding(0);
            EditQuestionButton.Name = "EditQuestionButton";
            EditQuestionButton.Size = new Size(44, 38);
            EditQuestionButton.TabIndex = 17;
            EditQuestionButton.Text = "✏️";
            EditQuestionButton.UseVisualStyleBackColor = false;
            EditQuestionButton.Click += EditQuestionButton_Click;
            // 
            // CreateTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 59, 76);
            ClientSize = new Size(1711, 1006);
            Controls.Add(EditQuestionButton);
            Controls.Add(EditAnswerButton);
            Controls.Add(FinishTestButton);
            Controls.Add(DeleteAnswerButton);
            Controls.Add(DeleteQuestionButton);
            Controls.Add(AnswerPictureBox);
            Controls.Add(ImagePreviewAnswerLabel);
            Controls.Add(AnswersLabel);
            Controls.Add(QuestionsLabel);
            Controls.Add(ImagePreviewLabel);
            Controls.Add(AnswerLabel);
            Controls.Add(QuestionLabel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(PicturePreviewPictureBox);
            Controls.Add(AnswersListBox);
            Controls.Add(AddQuestionButton);
            Controls.Add(panel1);
            Controls.Add(QuestionsListBox);
            Name = "CreateTestForm";
            Text = "CreateQuizForm";
            ((System.ComponentModel.ISupportInitialize)PicturePreviewPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnswerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox QuestionsListBox;
        private Panel panel1;
        private Button AddQuestionButton;
        private ListBox AnswersListBox;
        private PictureBox PicturePreviewPictureBox;
        private Panel panel2;
        private Panel panel3;
        private Label QuestionLabel;
        private Label AnswerLabel;
        private Label ImagePreviewLabel;
        private CheckBox IsPictureQuestionCheckBox;
        private Label QuestionsLabel;
        private Panel panel4;
        private TextBox ImagePathTextBox;
        private Label ImagePathLabel;
        private Label TextAboveImageLabel;
        private RichTextBox TextAboveImageRichTextBox;
        private Label AnswersLabel;
        private CheckBox HasImageAnswerCheckBox;
        private CheckBox IsCorrectAnswerCheckBox;
        private RichTextBox AnswerTextRichTextBox;
        private Label AnswerTextLabel;
        private Button AddAnswerButton;
        private TextBox AnswerImagePathTextBox;
        private Label AnswerImagePathLabel;
        private Label ImagePreviewAnswerLabel;
        private PictureBox AnswerPictureBox;
        private Button DeleteQuestionButton;
        private Button DeleteAnswerButton;
        private Button FinishTestButton;
        private Button EditAnswerButton;
        private Button EditQuestionButton;
    }
}
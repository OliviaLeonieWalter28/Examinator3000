namespace Examinator3000
{
    partial class CreateQuizForm
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
            TextBelowImageRichTextBox = new RichTextBox();
            TextBelowImageLabel = new Label();
            ImagePathTextBox = new TextBox();
            ImagePathLabel = new Label();
            TextAboveImageLabel = new Label();
            TextAboveImageRichTextBox = new RichTextBox();
            panel4 = new Panel();
            IsPictureQuestionCheckBox = new CheckBox();
            panel3 = new Panel();
            QuestionLabel = new Label();
            AnswerLabel = new Label();
            PicturePreviewLabel = new Label();
            QuestionsLabel = new Label();
            AnswersLabel = new Label();
            AnswerTextLabel = new Label();
            AnswerTextRichTextBox = new RichTextBox();
            IsCorrectAnswerCheckBox = new CheckBox();
            HasOnlyOneAnswerCheckBox = new CheckBox();
            AddAnswerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PicturePreviewPictureBox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // QuestionsListBox
            // 
            QuestionsListBox.FormattingEnabled = true;
            QuestionsListBox.ItemHeight = 15;
            QuestionsListBox.Location = new Point(1471, 60);
            QuestionsListBox.Name = "QuestionsListBox";
            QuestionsListBox.Size = new Size(228, 859);
            QuestionsListBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(1418, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 982);
            panel1.TabIndex = 1;
            // 
            // AddQuestionButton
            // 
            AddQuestionButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddQuestionButton.Location = new Point(1471, 936);
            AddQuestionButton.Name = "AddQuestionButton";
            AddQuestionButton.Size = new Size(228, 58);
            AddQuestionButton.TabIndex = 2;
            AddQuestionButton.Text = "Add Question";
            AddQuestionButton.UseVisualStyleBackColor = true;
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
            panel2.BackColor = Color.PeachPuff;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(TextBelowImageRichTextBox);
            panel2.Controls.Add(TextBelowImageLabel);
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
            // TextBelowImageRichTextBox
            // 
            TextBelowImageRichTextBox.Location = new Point(143, 373);
            TextBelowImageRichTextBox.Name = "TextBelowImageRichTextBox";
            TextBelowImageRichTextBox.Size = new Size(638, 153);
            TextBelowImageRichTextBox.TabIndex = 7;
            TextBelowImageRichTextBox.Text = "";
            // 
            // TextBelowImageLabel
            // 
            TextBelowImageLabel.AutoSize = true;
            TextBelowImageLabel.Font = new Font("Verdana", 9.75F);
            TextBelowImageLabel.Location = new Point(11, 373);
            TextBelowImageLabel.Name = "TextBelowImageLabel";
            TextBelowImageLabel.Size = new Size(130, 16);
            TextBelowImageLabel.TabIndex = 6;
            TextBelowImageLabel.Text = "Text Below Image:";
            // 
            // ImagePathTextBox
            // 
            ImagePathTextBox.Location = new Point(143, 342);
            ImagePathTextBox.Name = "ImagePathTextBox";
            ImagePathTextBox.Size = new Size(638, 23);
            ImagePathTextBox.TabIndex = 5;
            // 
            // ImagePathLabel
            // 
            ImagePathLabel.AutoSize = true;
            ImagePathLabel.Font = new Font("Verdana", 9.75F);
            ImagePathLabel.Location = new Point(11, 344);
            ImagePathLabel.Name = "ImagePathLabel";
            ImagePathLabel.Size = new Size(88, 16);
            ImagePathLabel.TabIndex = 4;
            ImagePathLabel.Text = "Image Path:";
            // 
            // TextAboveImageLabel
            // 
            TextAboveImageLabel.AutoSize = true;
            TextAboveImageLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            panel4.BackColor = Color.Tan;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(17, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(764, 12);
            panel4.TabIndex = 1;
            // 
            // IsPictureQuestionCheckBox
            // 
            IsPictureQuestionCheckBox.AutoSize = true;
            IsPictureQuestionCheckBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsPictureQuestionCheckBox.Location = new Point(17, 20);
            IsPictureQuestionCheckBox.Name = "IsPictureQuestionCheckBox";
            IsPictureQuestionCheckBox.Size = new Size(185, 22);
            IsPictureQuestionCheckBox.TabIndex = 0;
            IsPictureQuestionCheckBox.Text = "Is Picture Question";
            IsPictureQuestionCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(AddAnswerButton);
            panel3.Controls.Add(HasOnlyOneAnswerCheckBox);
            panel3.Controls.Add(IsCorrectAnswerCheckBox);
            panel3.Controls.Add(AnswerTextRichTextBox);
            panel3.Controls.Add(AnswerTextLabel);
            panel3.Location = new Point(25, 665);
            panel3.Name = "panel3";
            panel3.Size = new Size(808, 319);
            panel3.TabIndex = 6;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            AnswerLabel.Location = new Point(25, 620);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.Size = new Size(100, 25);
            AnswerLabel.TabIndex = 8;
            AnswerLabel.Text = "Answer";
            // 
            // PicturePreviewLabel
            // 
            PicturePreviewLabel.AutoSize = true;
            PicturePreviewLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PicturePreviewLabel.Location = new Point(854, 19);
            PicturePreviewLabel.Name = "PicturePreviewLabel";
            PicturePreviewLabel.Size = new Size(197, 25);
            PicturePreviewLabel.TabIndex = 9;
            PicturePreviewLabel.Text = "Picture Preview";
            // 
            // QuestionsLabel
            // 
            QuestionsLabel.AutoSize = true;
            QuestionsLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            AnswersLabel.Location = new Point(854, 620);
            AnswersLabel.Name = "AnswersLabel";
            AnswersLabel.Size = new Size(112, 25);
            AnswersLabel.TabIndex = 11;
            AnswersLabel.Text = "Answers";
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
            // AnswerTextRichTextBox
            // 
            AnswerTextRichTextBox.Location = new Point(143, 17);
            AnswerTextRichTextBox.Name = "AnswerTextRichTextBox";
            AnswerTextRichTextBox.Size = new Size(638, 209);
            AnswerTextRichTextBox.TabIndex = 1;
            AnswerTextRichTextBox.Text = "";
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
            // HasOnlyOneAnswerCheckBox
            // 
            HasOnlyOneAnswerCheckBox.AutoSize = true;
            HasOnlyOneAnswerCheckBox.Font = new Font("Verdana", 9.75F);
            HasOnlyOneAnswerCheckBox.Location = new Point(11, 254);
            HasOnlyOneAnswerCheckBox.Name = "HasOnlyOneAnswerCheckBox";
            HasOnlyOneAnswerCheckBox.Size = new Size(168, 20);
            HasOnlyOneAnswerCheckBox.TabIndex = 3;
            HasOnlyOneAnswerCheckBox.Text = "Has Only One Answer";
            HasOnlyOneAnswerCheckBox.UseVisualStyleBackColor = true;
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
            // 
            // CreateQuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 1006);
            Controls.Add(AnswersLabel);
            Controls.Add(QuestionsLabel);
            Controls.Add(PicturePreviewLabel);
            Controls.Add(AnswerLabel);
            Controls.Add(QuestionLabel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(PicturePreviewPictureBox);
            Controls.Add(AnswersListBox);
            Controls.Add(AddQuestionButton);
            Controls.Add(panel1);
            Controls.Add(QuestionsListBox);
            Name = "CreateQuizForm";
            Text = "CreateQuizForm";
            ((System.ComponentModel.ISupportInitialize)PicturePreviewPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Label PicturePreviewLabel;
        private CheckBox IsPictureQuestionCheckBox;
        private Label QuestionsLabel;
        private Panel panel4;
        private TextBox ImagePathTextBox;
        private Label ImagePathLabel;
        private Label TextAboveImageLabel;
        private RichTextBox TextAboveImageRichTextBox;
        private Label AnswersLabel;
        private Label TextBelowImageLabel;
        private RichTextBox TextBelowImageRichTextBox;
        private CheckBox HasOnlyOneAnswerCheckBox;
        private CheckBox IsCorrectAnswerCheckBox;
        private RichTextBox AnswerTextRichTextBox;
        private Label AnswerTextLabel;
        private Button AddAnswerButton;
    }
}
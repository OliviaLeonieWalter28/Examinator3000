namespace Examinator3000
{
    partial class EditAnswerForm
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
            panel3 = new Panel();
            AnswerImagePathTextBox = new TextBox();
            AnswerImagePathLabel = new Label();
            UpdateAnswerButton = new Button();
            HasImageAnswerCheckBox = new CheckBox();
            IsCorrectAnswerCheckBox = new CheckBox();
            AnswerTextRichTextBox = new RichTextBox();
            AnswerTextLabel = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 137, 59);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(AnswerImagePathTextBox);
            panel3.Controls.Add(AnswerImagePathLabel);
            panel3.Controls.Add(UpdateAnswerButton);
            panel3.Controls.Add(HasImageAnswerCheckBox);
            panel3.Controls.Add(IsCorrectAnswerCheckBox);
            panel3.Controls.Add(AnswerTextRichTextBox);
            panel3.Controls.Add(AnswerTextLabel);
            panel3.Location = new Point(19, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(808, 319);
            panel3.TabIndex = 7;
            // 
            // AnswerImagePathTextBox
            // 
            AnswerImagePathTextBox.Location = new Point(143, 204);
            AnswerImagePathTextBox.Name = "AnswerImagePathTextBox";
            AnswerImagePathTextBox.Size = new Size(638, 23);
            AnswerImagePathTextBox.TabIndex = 6;
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
            // UpdateAnswerButton
            // 
            UpdateAnswerButton.Font = new Font("Verdana", 14.25F);
            UpdateAnswerButton.Location = new Point(556, 244);
            UpdateAnswerButton.Name = "UpdateAnswerButton";
            UpdateAnswerButton.Size = new Size(225, 55);
            UpdateAnswerButton.TabIndex = 4;
            UpdateAnswerButton.Text = "Update Answer";
            UpdateAnswerButton.UseVisualStyleBackColor = true;
            UpdateAnswerButton.Click += UpdateAnswerButton_Click;
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
            // EditQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 59, 76);
            ClientSize = new Size(850, 363);
            Controls.Add(panel3);
            Name = "EditQuestionForm";
            Text = "EditQuestionForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox AnswerImagePathTextBox;
        private Label AnswerImagePathLabel;
        private Button UpdateAnswerButton;
        private CheckBox HasImageAnswerCheckBox;
        private CheckBox IsCorrectAnswerCheckBox;
        private RichTextBox AnswerTextRichTextBox;
        private Label AnswerTextLabel;
    }
}
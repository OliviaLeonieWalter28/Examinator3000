namespace Examinator3000
{
    partial class AnswerForm
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
            AnswerPictureBox = new PictureBox();
            CorrectAnswerButton = new Button();
            IncorrectAnswerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AnswerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // AnswerPictureBox
            // 
            AnswerPictureBox.Location = new Point(24, 41);
            AnswerPictureBox.Name = "AnswerPictureBox";
            AnswerPictureBox.Size = new Size(1506, 765);
            AnswerPictureBox.TabIndex = 1;
            AnswerPictureBox.TabStop = false;
            // 
            // CorrectAnswerButton
            // 
            CorrectAnswerButton.BackColor = Color.Lime;
            CorrectAnswerButton.FlatStyle = FlatStyle.Flat;
            CorrectAnswerButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CorrectAnswerButton.Location = new Point(526, 847);
            CorrectAnswerButton.Name = "CorrectAnswerButton";
            CorrectAnswerButton.Size = new Size(179, 57);
            CorrectAnswerButton.TabIndex = 2;
            CorrectAnswerButton.Text = "Answer Was Correct";
            CorrectAnswerButton.UseVisualStyleBackColor = false;
            CorrectAnswerButton.Click += CorrectAnswerButton_Click;
            // 
            // IncorrectAnswerButton
            // 
            IncorrectAnswerButton.BackColor = Color.FromArgb(192, 0, 0);
            IncorrectAnswerButton.FlatStyle = FlatStyle.Flat;
            IncorrectAnswerButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncorrectAnswerButton.Location = new Point(820, 847);
            IncorrectAnswerButton.Name = "IncorrectAnswerButton";
            IncorrectAnswerButton.Size = new Size(179, 57);
            IncorrectAnswerButton.TabIndex = 3;
            IncorrectAnswerButton.Text = "Answer Was Incorrect";
            IncorrectAnswerButton.UseVisualStyleBackColor = false;
            IncorrectAnswerButton.Click += IncorrectAnswerButton_Click;
            // 
            // AnswerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 59, 76);
            ClientSize = new Size(1561, 938);
            Controls.Add(IncorrectAnswerButton);
            Controls.Add(CorrectAnswerButton);
            Controls.Add(AnswerPictureBox);
            Name = "AnswerForm";
            Text = "AnswerForm";
            ((System.ComponentModel.ISupportInitialize)AnswerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox AnswerPictureBox;
        private Button CorrectAnswerButton;
        private Button IncorrectAnswerButton;
    }
}
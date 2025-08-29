namespace Examinator3000
{
    partial class CreateTestMainForm
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
            AddQuestionsToTestButton = new Button();
            TestNameLabel = new Label();
            TestNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // AddQuestionsToTestButton
            // 
            AddQuestionsToTestButton.BackColor = Color.FromArgb(225, 137, 59);
            AddQuestionsToTestButton.FlatStyle = FlatStyle.Popup;
            AddQuestionsToTestButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddQuestionsToTestButton.Location = new Point(445, 155);
            AddQuestionsToTestButton.Name = "AddQuestionsToTestButton";
            AddQuestionsToTestButton.Size = new Size(136, 56);
            AddQuestionsToTestButton.TabIndex = 0;
            AddQuestionsToTestButton.Text = "Add Questions";
            AddQuestionsToTestButton.UseVisualStyleBackColor = false;
            AddQuestionsToTestButton.Click += AddQuestionsToTestButton_Click;
            // 
            // TestNameLabel
            // 
            TestNameLabel.AutoSize = true;
            TestNameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TestNameLabel.ForeColor = SystemColors.Control;
            TestNameLabel.Location = new Point(234, 58);
            TestNameLabel.Name = "TestNameLabel";
            TestNameLabel.Size = new Size(141, 25);
            TestNameLabel.TabIndex = 1;
            TestNameLabel.Text = "Test Name: ";
            // 
            // TestNameTextBox
            // 
            TestNameTextBox.Location = new Point(92, 99);
            TestNameTextBox.Name = "TestNameTextBox";
            TestNameTextBox.Size = new Size(418, 23);
            TestNameTextBox.TabIndex = 2;
            // 
            // CreateTestMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 59, 76);
            ClientSize = new Size(593, 223);
            Controls.Add(TestNameTextBox);
            Controls.Add(TestNameLabel);
            Controls.Add(AddQuestionsToTestButton);
            Name = "CreateTestMainForm";
            Text = "CreateTestMainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddQuestionsToTestButton;
        private Label TestNameLabel;
        private TextBox TestNameTextBox;
    }
}
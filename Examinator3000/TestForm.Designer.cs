namespace Examinator3000
{
    partial class TestForm
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
            pageSetupDialog1 = new PageSetupDialog();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AboveImageTextQuestionLabel = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            BelowImageTextQuestionLabel = new Label();
            NextButton = new Button();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Location = new Point(38, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(1700, 717);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(225, 137, 59);
            flowLayoutPanel1.Location = new Point(40, 788);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1698, 199);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // AboveImageTextQuestionLabel
            // 
            AboveImageTextQuestionLabel.AutoSize = true;
            AboveImageTextQuestionLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboveImageTextQuestionLabel.ForeColor = SystemColors.Control;
            AboveImageTextQuestionLabel.Location = new Point(3, 0);
            AboveImageTextQuestionLabel.Name = "AboveImageTextQuestionLabel";
            AboveImageTextQuestionLabel.Size = new Size(58, 18);
            AboveImageTextQuestionLabel.TabIndex = 0;
            AboveImageTextQuestionLabel.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(0, 64, 90);
            flowLayoutPanel2.Controls.Add(AboveImageTextQuestionLabel);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(BelowImageTextQuestionLabel);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(13, 14);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1668, 690);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BelowImageTextQuestionLabel
            // 
            BelowImageTextQuestionLabel.AutoSize = true;
            BelowImageTextQuestionLabel.Font = new Font("Verdana", 12F);
            BelowImageTextQuestionLabel.ForeColor = SystemColors.Control;
            BelowImageTextQuestionLabel.Location = new Point(3, 74);
            BelowImageTextQuestionLabel.Name = "BelowImageTextQuestionLabel";
            BelowImageTextQuestionLabel.Size = new Size(58, 18);
            BelowImageTextQuestionLabel.TabIndex = 2;
            BelowImageTextQuestionLabel.Text = "label1";
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.FromArgb(0, 64, 90);
            NextButton.FlatStyle = FlatStyle.Popup;
            NextButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextButton.ForeColor = SystemColors.Control;
            NextButton.Location = new Point(1597, 1012);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(174, 65);
            NextButton.TabIndex = 3;
            NextButton.Text = "Next Question";
            NextButton.UseVisualStyleBackColor = false;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 59, 76);
            ClientSize = new Size(1778, 1089);
            Controls.Add(NextButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "TestForm";
            Text = "TestForm";
            panel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PageSetupDialog pageSetupDialog1;
        private Panel panel2;
        private Label AboveImageTextQuestionLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private Label BelowImageTextQuestionLabel;
        private Button NextButton;
    }
}
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
            TestListBox = new ListBox();
            CreateNewButton = new Button();
            button1 = new Button();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TestListBox
            // 
            TestListBox.FormattingEnabled = true;
            TestListBox.ItemHeight = 15;
            TestListBox.Location = new Point(42, 39);
            TestListBox.Name = "TestListBox";
            TestListBox.Size = new Size(499, 784);
            TestListBox.TabIndex = 0;
            // 
            // CreateNewButton
            // 
            CreateNewButton.BackColor = Color.ForestGreen;
            CreateNewButton.FlatStyle = FlatStyle.Flat;
            CreateNewButton.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateNewButton.Location = new Point(42, 863);
            CreateNewButton.Name = "CreateNewButton";
            CreateNewButton.Size = new Size(499, 73);
            CreateNewButton.TabIndex = 1;
            CreateNewButton.Text = "Create New Test";
            CreateNewButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(690, 705);
            button1.Name = "button1";
            button1.Size = new Size(236, 118);
            button1.TabIndex = 2;
            button1.Text = "Start All Questions";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 3;
            label1.Text = "Testname:";
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(950, 705);
            button2.Name = "button2";
            button2.Size = new Size(236, 118);
            button2.TabIndex = 4;
            button2.Text = "Start Archived Questions";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1211, 705);
            button3.Name = "button3";
            button3.Size = new Size(236, 118);
            button3.TabIndex = 5;
            button3.Text = "Start Weak Questions";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(1473, 705);
            button4.Name = "button4";
            button4.Size = new Size(236, 118);
            button4.TabIndex = 6;
            button4.Text = "Start Mixed Questions";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F);
            label2.Location = new Point(31, 88);
            label2.Name = "label2";
            label2.Size = new Size(242, 25);
            label2.TabIndex = 7;
            label2.Text = "Amount of Questions:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F);
            label3.Location = new Point(31, 143);
            label3.Name = "label3";
            label3.Size = new Size(225, 25);
            label3.TabIndex = 8;
            label3.Text = "Correct Percentage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15.75F);
            label4.Location = new Point(31, 205);
            label4.Name = "label4";
            label4.Size = new Size(255, 25);
            label4.TabIndex = 9;
            label4.Text = "Amount of Repetitions:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 15.75F);
            label5.Location = new Point(31, 273);
            label5.Name = "label5";
            label5.Size = new Size(340, 25);
            label5.TabIndex = 10;
            label5.Text = "Amount of Archived Questions:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(690, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 427);
            panel1.TabIndex = 1;
            // 
            // Examinator3000Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1822, 971);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CreateNewButton);
            Controls.Add(TestListBox);
            Name = "Examinator3000Main";
            Text = "Examinator3000Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox TestListBox;
        private Button CreateNewButton;
        private Button button1;
        private ColorDialog colorDialog1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}

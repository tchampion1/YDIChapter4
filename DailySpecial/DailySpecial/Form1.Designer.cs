namespace DailySpecial
{
    partial class Form1
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
            dayBox = new TextBox();
            specialButton = new Button();
            outputLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // dayBox
            // 
            dayBox.Location = new Point(354, 193);
            dayBox.Name = "dayBox";
            dayBox.Size = new Size(67, 27);
            dayBox.TabIndex = 0;
            // 
            // specialButton
            // 
            specialButton.Location = new Point(337, 259);
            specialButton.Name = "specialButton";
            specialButton.Size = new Size(111, 29);
            specialButton.TabIndex = 1;
            specialButton.Text = "Get special";
            specialButton.UseVisualStyleBackColor = true;
            specialButton.Click += SpecialButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(365, 327);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 20);
            outputLabel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 79);
            label1.Name = "label1";
            label1.Size = new Size(258, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter a day number to see our special";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 129);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 4;
            label2.Text = "For example, Sunday = 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outputLabel);
            Controls.Add(specialButton);
            Controls.Add(dayBox);
            Name = "Form1";
            Text = "Chatterbox Diner Specials";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dayBox;
        private Button specialButton;
        private Label outputLabel;
        private Label label1;
        private Label label2;
    }
}
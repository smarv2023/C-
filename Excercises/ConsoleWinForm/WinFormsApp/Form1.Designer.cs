namespace WinFormsApp
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
            label1 = new Label();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            label2 = new Label();
            combineName = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 73);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(234, 67);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(243, 47);
            firstNameText.TabIndex = 1;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(234, 157);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(243, 47);
            lastNameText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 163);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // combineName
            // 
            combineName.AutoSize = true;
            combineName.Location = new Point(142, 246);
            combineName.Name = "combineName";
            combineName.Size = new Size(236, 51);
            combineName.TabIndex = 4;
            combineName.Text = "Combine Name";
            combineName.UseVisualStyleBackColor = true;
            combineName.Click += combineName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 432);
            Controls.Add(combineName);
            Controls.Add(lastNameText);
            Controls.Add(label2);
            Controls.Add(firstNameText);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private Label label2;
        private Button combineName;
    }
}

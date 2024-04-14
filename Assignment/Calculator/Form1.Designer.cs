namespace Calculator
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
            groupBox1 = new GroupBox();
            lblOperator = new Label();
            operand2 = new TextBox();
            operand1 = new TextBox();
            panel1 = new Panel();
            btnCancel = new Button();
            btnDel = new Button();
            btnBack = new Button();
            btnNext = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button0 = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            lblTotal = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblOperator);
            groupBox1.Controls.Add(operand2);
            groupBox1.Controls.Add(operand1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 86);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Click or Type a number:";
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperator.Location = new Point(212, 25);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(32, 32);
            lblOperator.TabIndex = 3;
            lblOperator.Text = "O";
            lblOperator.TextAlign = ContentAlignment.TopCenter;
            // 
            // operand2
            // 
            operand2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            operand2.ImeMode = ImeMode.NoControl;
            operand2.Location = new Point(260, 22);
            operand2.Name = "operand2";
            operand2.RightToLeft = RightToLeft.No;
            operand2.Size = new Size(190, 39);
            operand2.TabIndex = 2;
            operand2.TextAlign = HorizontalAlignment.Right;
            operand2.Click += operand2_TextChanged;
            operand2.TextChanged += operand2_TextChanged;
            operand2.KeyPress += operand_KeyPress;
            // 
            // operand1
            // 
            operand1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            operand1.Location = new Point(6, 22);
            operand1.Name = "operand1";
            operand1.Size = new Size(190, 39);
            operand1.TabIndex = 1;
            operand1.TextAlign = HorizontalAlignment.Right;
            operand1.Click += operand1_TextChanged;
            operand1.TextChanged += operand1_TextChanged;
            operand1.KeyPress += operand_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button0);
            panel1.Controls.Add(btnDot);
            panel1.Controls.Add(btnEqual);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSub);
            panel1.Controls.Add(btnMul);
            panel1.Controls.Add(btnDiv);
            panel1.Location = new Point(136, 181);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(210, 313);
            panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(6, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(5);
            btnCancel.Size = new Size(45, 55);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "C";
            btnCancel.UseCompatibleTextRendering = true;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(57, 8);
            btnDel.Name = "btnDel";
            btnDel.Padding = new Padding(5);
            btnDel.Size = new Size(45, 55);
            btnDel.TabIndex = 20;
            btnDel.Text = "Del";
            btnDel.UseCompatibleTextRendering = true;
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(108, 8);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(5);
            btnBack.Size = new Size(45, 55);
            btnBack.TabIndex = 19;
            btnBack.Text = "←";
            btnBack.UseCompatibleTextRendering = true;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(159, 8);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(5);
            btnNext.Size = new Size(45, 55);
            btnNext.TabIndex = 18;
            btnNext.Text = "→";
            btnNext.UseCompatibleTextRendering = true;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(108, 69);
            button9.Name = "button9";
            button9.Padding = new Padding(5);
            button9.Size = new Size(45, 55);
            button9.TabIndex = 17;
            button9.Text = "9";
            button9.UseCompatibleTextRendering = true;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(57, 69);
            button8.Name = "button8";
            button8.Padding = new Padding(5);
            button8.Size = new Size(45, 55);
            button8.TabIndex = 16;
            button8.Text = "8";
            button8.UseCompatibleTextRendering = true;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(6, 69);
            button7.Name = "button7";
            button7.Padding = new Padding(5);
            button7.Size = new Size(45, 55);
            button7.TabIndex = 15;
            button7.Text = "7";
            button7.UseCompatibleTextRendering = true;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(108, 130);
            button6.Name = "button6";
            button6.Padding = new Padding(5);
            button6.Size = new Size(45, 55);
            button6.TabIndex = 14;
            button6.Text = "6";
            button6.UseCompatibleTextRendering = true;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(57, 130);
            button5.Name = "button5";
            button5.Padding = new Padding(5);
            button5.Size = new Size(45, 55);
            button5.TabIndex = 13;
            button5.Text = "5";
            button5.UseCompatibleTextRendering = true;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(6, 130);
            button4.Name = "button4";
            button4.Padding = new Padding(5);
            button4.Size = new Size(45, 55);
            button4.TabIndex = 12;
            button4.Text = "4";
            button4.UseCompatibleTextRendering = true;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(108, 191);
            button3.Name = "button3";
            button3.Padding = new Padding(5);
            button3.Size = new Size(45, 55);
            button3.TabIndex = 11;
            button3.Text = "3";
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(57, 191);
            button2.Name = "button2";
            button2.Padding = new Padding(5);
            button2.Size = new Size(45, 55);
            button2.TabIndex = 10;
            button2.Text = "2";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(6, 191);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(45, 55);
            button1.TabIndex = 9;
            button1.Text = "1";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button0
            // 
            button0.AutoSize = true;
            button0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(6, 252);
            button0.Name = "button0";
            button0.Padding = new Padding(5);
            button0.Size = new Size(45, 55);
            button0.TabIndex = 8;
            button0.Text = "0";
            button0.UseCompatibleTextRendering = true;
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // btnDot
            // 
            btnDot.AutoSize = true;
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(57, 252);
            btnDot.Name = "btnDot";
            btnDot.Padding = new Padding(5);
            btnDot.Size = new Size(45, 55);
            btnDot.TabIndex = 7;
            btnDot.Text = ".";
            btnDot.UseCompatibleTextRendering = true;
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnEqual
            // 
            btnEqual.AutoSize = true;
            btnEqual.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(108, 252);
            btnEqual.Name = "btnEqual";
            btnEqual.Padding = new Padding(5);
            btnEqual.Size = new Size(45, 55);
            btnEqual.TabIndex = 6;
            btnEqual.Text = "=";
            btnEqual.UseCompatibleTextRendering = true;
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(159, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(5);
            btnAdd.Size = new Size(45, 55);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "+";
            btnAdd.UseCompatibleTextRendering = true;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.AutoSize = true;
            btnSub.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(159, 191);
            btnSub.Name = "btnSub";
            btnSub.Padding = new Padding(5);
            btnSub.Size = new Size(45, 55);
            btnSub.TabIndex = 4;
            btnSub.Text = "-";
            btnSub.UseCompatibleTextRendering = true;
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.AutoSize = true;
            btnMul.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMul.Location = new Point(159, 130);
            btnMul.Name = "btnMul";
            btnMul.Padding = new Padding(5);
            btnMul.Size = new Size(45, 55);
            btnMul.TabIndex = 3;
            btnMul.Text = "x";
            btnMul.UseCompatibleTextRendering = true;
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.AutoSize = true;
            btnDiv.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(159, 69);
            btnDiv.Name = "btnDiv";
            btnDiv.Padding = new Padding(5);
            btnDiv.Size = new Size(45, 55);
            btnDiv.TabIndex = 2;
            btnDiv.Text = "÷";
            btnDiv.UseCompatibleTextRendering = true;
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.ButtonFace;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(136, 120);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(210, 37);
            lblTotal.TabIndex = 2;
            lblTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(480, 506);
            Controls.Add(lblTotal);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator by Marvin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox operand1;
        private TextBox operand2;
        private Label lblOperator;
        private Panel panel1;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Button btnAdd;
        private Button btnEqual;
        private Button button0;
        private Button btnDot;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button9;
        private Button btnNext;
        private Button btnDel;
        private Button btnBack;
        private Button btnCancel;
        private Label lblTotal;
    }
}

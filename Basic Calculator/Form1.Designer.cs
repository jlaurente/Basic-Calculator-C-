namespace Basic_Calculator
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
            lblResult = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnAdd = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnDivide = new Button();
            SuspendLayout();

            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(375, 38);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(106, 20);
            lblResult.TabIndex = 0;
            lblResult.Text = "<< RESULT >>";
            this.Controls.Add(lblResult);

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 110);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Num 1";
            this.Controls.Add(label2);

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 173);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Num 2";
            this.Controls.Add(label3);

            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(301, 110);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(222, 27);
            txtNum1.TabIndex = 3;
            this.Controls.Add(txtNum1);

            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(301, 173);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(222, 27);
            txtNum2.TabIndex = 4;
            this.Controls.Add(txtNum2);

            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(264, 254);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(266, 316);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(94, 29);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += BtnMultiply_Click;
            this.Controls.Add(btnMultiply);

            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(440, 254);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(94, 29);
            btnSubtract.TabIndex = 7;
            btnSubtract.Text = "Substract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += BtnSubtract_Click;
            this.Controls.Add(btnSubtract);

            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(440, 316);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(94, 29);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += BtnDivide_Click;
            this.Controls.Add(btnDivide);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDivide);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnAdd);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basic Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Calculate((a,b) =>
            {
                if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");

                return a / b;
            });
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            Calculate((a,b) => a - b);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            Calculate((a,b) => a * b);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Calculate((a,b) => a + b);
        }

        private void Calculate(Func<double, double, double> operation)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                try
                {
                    double result = operation(num1, num2);
                    lblResult.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private Label lblResult;
        private Label label2;
        private Label label3;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnAdd;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnDivide;
    }
}
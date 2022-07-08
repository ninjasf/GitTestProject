namespace CalculatorApplication
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
            this.txtBoxInput1 = new System.Windows.Forms.TextBox();
            this.txtBoxInput2 = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxInput1
            // 
            this.txtBoxInput1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxInput1.Location = new System.Drawing.Point(144, 23);
            this.txtBoxInput1.Name = "txtBoxInput1";
            this.txtBoxInput1.Size = new System.Drawing.Size(128, 26);
            this.txtBoxInput1.TabIndex = 0;
            // 
            // txtBoxInput2
            // 
            this.txtBoxInput2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxInput2.Location = new System.Drawing.Point(143, 109);
            this.txtBoxInput2.Name = "txtBoxInput2";
            this.txtBoxInput2.Size = new System.Drawing.Size(128, 26);
            this.txtBoxInput2.TabIndex = 1;
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(174, 69);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(63, 23);
            this.cbOperator.TabIndex = 2;
            this.cbOperator.SelectedIndexChanged += new System.EventHandler(this.cbOperator_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer:";
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(64, 201);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(80, 32);
            this.btnEqual.TabIndex = 6;
            this.btnEqual.Text = "Calculate";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click_1);
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayTotal.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblDisplayTotal.Location = new System.Drawing.Point(192, 151);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(12, 25);
            this.lblDisplayTotal.TabIndex = 7;
            this.lblDisplayTotal.Text = "\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 255);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.txtBoxInput2);
            this.Controls.Add(this.txtBoxInput1);
            this.Name = "Form1";
            this.Text = "FrmCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEqual;
        private Label lblDisplayTotal;
    }
}
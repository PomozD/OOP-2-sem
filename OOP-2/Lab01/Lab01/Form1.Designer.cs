namespace Lab01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonRemainderOfDiv = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMRC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(11, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.Location = new System.Drawing.Point(11, 111);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(65, 30);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonRemainderOfDiv
            // 
            this.buttonRemainderOfDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemainderOfDiv.Location = new System.Drawing.Point(82, 111);
            this.buttonRemainderOfDiv.Name = "buttonRemainderOfDiv";
            this.buttonRemainderOfDiv.Size = new System.Drawing.Size(65, 30);
            this.buttonRemainderOfDiv.TabIndex = 2;
            this.buttonRemainderOfDiv.Text = "%";
            this.buttonRemainderOfDiv.UseVisualStyleBackColor = true;
            this.buttonRemainderOfDiv.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusMinus.Location = new System.Drawing.Point(153, 111);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(65, 30);
            this.buttonPlusMinus.TabIndex = 3;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.buttonPlusMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(224, 111);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(65, 30);
            this.buttonPlus.TabIndex = 4;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(224, 147);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(65, 30);
            this.buttonMinus.TabIndex = 8;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(153, 147);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 30);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(82, 147);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 30);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(11, 147);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 30);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiv.Location = new System.Drawing.Point(224, 219);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(65, 30);
            this.buttonDiv.TabIndex = 16;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.operator_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(153, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(82, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // buttonMul
            // 
            this.buttonMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMul.Location = new System.Drawing.Point(224, 183);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(65, 30);
            this.buttonMul.TabIndex = 12;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.operator_click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(153, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 30);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(82, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 30);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(11, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqual.Location = new System.Drawing.Point(153, 255);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(136, 30);
            this.buttonEqual.TabIndex = 20;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDot.Location = new System.Drawing.Point(82, 255);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(65, 30);
            this.buttonDot.TabIndex = 19;
            this.buttonDot.Text = ",";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.button_click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(11, 255);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(65, 30);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCurrentOperation.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 20);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMMinus.Location = new System.Drawing.Point(153, 75);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(65, 30);
            this.buttonMMinus.TabIndex = 24;
            this.buttonMMinus.Text = "M-";
            this.buttonMMinus.UseVisualStyleBackColor = true;
            this.buttonMMinus.Click += new System.EventHandler(this.buttonMMinus_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMPlus.Location = new System.Drawing.Point(82, 75);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(65, 30);
            this.buttonMPlus.TabIndex = 23;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMPlus_Click);
            // 
            // buttonMRC
            // 
            this.buttonMRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMRC.Location = new System.Drawing.Point(11, 75);
            this.buttonMRC.Name = "buttonMRC";
            this.buttonMRC.Size = new System.Drawing.Size(65, 30);
            this.buttonMRC.TabIndex = 22;
            this.buttonMRC.Text = "MRC";
            this.buttonMRC.UseVisualStyleBackColor = true;
            this.buttonMRC.Click += new System.EventHandler(this.buttonMRC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 305);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMRC);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.buttonRemainderOfDiv);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonRemainderOfDiv;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMRC;
    }
}


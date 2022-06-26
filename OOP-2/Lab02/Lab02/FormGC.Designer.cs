namespace Lab02
{
    partial class FormGC
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
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.labelMemory = new System.Windows.Forms.Label();
            this.groupBoxDiretX11 = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelSeries = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.trackBarMemory = new System.Windows.Forms.TrackBar();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            this.groupBoxDiretX11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarFreq.LargeChange = 100;
            this.trackBarFreq.Location = new System.Drawing.Point(23, 186);
            this.trackBarFreq.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarFreq.Maximum = 1000;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(139, 56);
            this.trackBarFreq.SmallChange = 50;
            this.trackBarFreq.TabIndex = 32;
            this.trackBarFreq.TickFrequency = 100;
            this.trackBarFreq.Value = 500;
            this.trackBarFreq.Scroll += new System.EventHandler(this.trackBarFreq_Scroll);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(23, 101);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModel.MaxLength = 100;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(132, 22);
            this.textBoxModel.TabIndex = 31;
            this.textBoxModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModel_KeyPress);
            this.textBoxModel.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(239, 32);
            this.textBoxSeries.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSeries.MaxLength = 100;
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(132, 22);
            this.textBoxSeries.TabIndex = 30;
            this.textBoxSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSeries_KeyPress);
            this.textBoxSeries.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(23, 32);
            this.textBoxProducer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProducer.MaxLength = 50;
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(132, 22);
            this.textBoxProducer.TabIndex = 29;
            this.textBoxProducer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProducer_KeyPress);
            this.textBoxProducer.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Location = new System.Drawing.Point(235, 150);
            this.labelMemory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(109, 17);
            this.labelMemory.TabIndex = 28;
            this.labelMemory.Text = "Объем памяти:";
            // 
            // groupBoxDiretX11
            // 
            this.groupBoxDiretX11.Controls.Add(this.radioButtonNo);
            this.groupBoxDiretX11.Controls.Add(this.radioButtonYes);
            this.groupBoxDiretX11.Location = new System.Drawing.Point(235, 80);
            this.groupBoxDiretX11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDiretX11.Name = "groupBoxDiretX11";
            this.groupBoxDiretX11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDiretX11.Size = new System.Drawing.Size(191, 46);
            this.groupBoxDiretX11.TabIndex = 27;
            this.groupBoxDiretX11.TabStop = false;
            this.groupBoxDiretX11.Text = "Поддержка DiretX11:";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(91, 22);
            this.radioButtonNo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(52, 21);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "нет";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Checked = true;
            this.radioButtonYes.Location = new System.Drawing.Point(8, 22);
            this.radioButtonYes.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(45, 21);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "да";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(23, 150);
            this.labelFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(67, 17);
            this.labelFrequency.TabIndex = 25;
            this.labelFrequency.Text = "Частота:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(23, 80);
            this.labelModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(62, 17);
            this.labelModel.TabIndex = 23;
            this.labelModel.Text = "Модель:";
            // 
            // labelSeries
            // 
            this.labelSeries.AutoSize = true;
            this.labelSeries.Location = new System.Drawing.Point(235, 11);
            this.labelSeries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeries.Name = "labelSeries";
            this.labelSeries.Size = new System.Drawing.Size(53, 17);
            this.labelSeries.TabIndex = 22;
            this.labelSeries.Text = "Серия:";
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(19, 11);
            this.labelProducer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(114, 17);
            this.labelProducer.TabIndex = 21;
            this.labelProducer.Text = "Производитель:";
            // 
            // trackBarMemory
            // 
            this.trackBarMemory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarMemory.LargeChange = 2;
            this.trackBarMemory.Location = new System.Drawing.Point(235, 186);
            this.trackBarMemory.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarMemory.Maximum = 6;
            this.trackBarMemory.Name = "trackBarMemory";
            this.trackBarMemory.Size = new System.Drawing.Size(139, 56);
            this.trackBarMemory.TabIndex = 33;
            this.trackBarMemory.Value = 3;
            this.trackBarMemory.Scroll += new System.EventHandler(this.trackBarMemory_Scroll);
            // 
            // buttonOK
            // 
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.Location = new System.Drawing.Point(325, 271);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 34;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormGC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 314);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.trackBarMemory);
            this.Controls.Add(this.trackBarFreq);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxSeries);
            this.Controls.Add(this.textBoxProducer);
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.groupBoxDiretX11);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelSeries);
            this.Controls.Add(this.labelProducer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormGC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видеокарта";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            this.groupBoxDiretX11.ResumeLayout(false);
            this.groupBoxDiretX11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxSeries;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.GroupBox groupBoxDiretX11;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelSeries;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.TrackBar trackBarMemory;
        private System.Windows.Forms.Button buttonOK;
    }
}
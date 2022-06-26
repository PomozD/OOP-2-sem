namespace Lab02
{
    partial class FormProcessor
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
            this.labelProducer = new System.Windows.Forms.Label();
            this.labelSeries = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelNumOfCores = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelMaxFrequency = new System.Windows.Forms.Label();
            this.groupBoxBitArchitecture = new System.Windows.Forms.GroupBox();
            this.radioButton64bit = new System.Windows.Forms.RadioButton();
            this.radioButton32bit = new System.Windows.Forms.RadioButton();
            this.labelCacheSize = new System.Windows.Forms.Label();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.trackBarMaxFreq = new System.Windows.Forms.TrackBar();
            this.numericUpDownL1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownL2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownL3 = new System.Windows.Forms.NumericUpDown();
            this.labelL1 = new System.Windows.Forms.Label();
            this.labelL2 = new System.Windows.Forms.Label();
            this.labelL3 = new System.Windows.Forms.Label();
            this.numericUpDownCores = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxBitArchitecture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCores)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(29, 16);
            this.labelProducer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(114, 17);
            this.labelProducer.TabIndex = 0;
            this.labelProducer.Text = "Производитель:";
            // 
            // labelSeries
            // 
            this.labelSeries.AutoSize = true;
            this.labelSeries.Location = new System.Drawing.Point(235, 16);
            this.labelSeries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeries.Name = "labelSeries";
            this.labelSeries.Size = new System.Drawing.Size(53, 17);
            this.labelSeries.TabIndex = 1;
            this.labelSeries.Text = "Серия:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(29, 79);
            this.labelModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(62, 17);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Модель:";
            // 
            // labelNumOfCores
            // 
            this.labelNumOfCores.AutoSize = true;
            this.labelNumOfCores.Location = new System.Drawing.Point(235, 81);
            this.labelNumOfCores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumOfCores.Name = "labelNumOfCores";
            this.labelNumOfCores.Size = new System.Drawing.Size(126, 17);
            this.labelNumOfCores.TabIndex = 3;
            this.labelNumOfCores.Text = "Количество ядер:";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(29, 148);
            this.labelFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(67, 17);
            this.labelFrequency.TabIndex = 4;
            this.labelFrequency.Text = "Частота:";
            // 
            // labelMaxFrequency
            // 
            this.labelMaxFrequency.AutoSize = true;
            this.labelMaxFrequency.Location = new System.Drawing.Point(235, 148);
            this.labelMaxFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxFrequency.Name = "labelMaxFrequency";
            this.labelMaxFrequency.Size = new System.Drawing.Size(166, 17);
            this.labelMaxFrequency.TabIndex = 5;
            this.labelMaxFrequency.Text = "Максимальная частота:";
            // 
            // groupBoxBitArchitecture
            // 
            this.groupBoxBitArchitecture.Controls.Add(this.radioButton64bit);
            this.groupBoxBitArchitecture.Controls.Add(this.radioButton32bit);
            this.groupBoxBitArchitecture.Location = new System.Drawing.Point(21, 241);
            this.groupBoxBitArchitecture.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBitArchitecture.Name = "groupBoxBitArchitecture";
            this.groupBoxBitArchitecture.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBitArchitecture.Size = new System.Drawing.Size(268, 52);
            this.groupBoxBitArchitecture.TabIndex = 6;
            this.groupBoxBitArchitecture.TabStop = false;
            this.groupBoxBitArchitecture.Text = "Разрядность архитектуры:";
            // 
            // radioButton64bit
            // 
            this.radioButton64bit.AutoSize = true;
            this.radioButton64bit.Location = new System.Drawing.Point(119, 23);
            this.radioButton64bit.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton64bit.Name = "radioButton64bit";
            this.radioButton64bit.Size = new System.Drawing.Size(45, 21);
            this.radioButton64bit.TabIndex = 1;
            this.radioButton64bit.Text = "64";
            this.radioButton64bit.UseVisualStyleBackColor = true;
            // 
            // radioButton32bit
            // 
            this.radioButton32bit.AutoSize = true;
            this.radioButton32bit.Checked = true;
            this.radioButton32bit.Location = new System.Drawing.Point(12, 23);
            this.radioButton32bit.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton32bit.Name = "radioButton32bit";
            this.radioButton32bit.Size = new System.Drawing.Size(45, 21);
            this.radioButton32bit.TabIndex = 0;
            this.radioButton32bit.TabStop = true;
            this.radioButton32bit.Text = "32";
            this.radioButton32bit.UseVisualStyleBackColor = true;
            // 
            // labelCacheSize
            // 
            this.labelCacheSize.AutoSize = true;
            this.labelCacheSize.Location = new System.Drawing.Point(29, 314);
            this.labelCacheSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCacheSize.Name = "labelCacheSize";
            this.labelCacheSize.Size = new System.Drawing.Size(98, 17);
            this.labelCacheSize.TabIndex = 7;
            this.labelCacheSize.Text = "Размер кэша:";
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(29, 37);
            this.textBoxProducer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProducer.MaxLength = 50;
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(132, 22);
            this.textBoxProducer.TabIndex = 8;
            this.textBoxProducer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProducer_KeyPress);
            this.textBoxProducer.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(239, 36);
            this.textBoxSeries.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSeries.MaxLength = 100;
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(132, 22);
            this.textBoxSeries.TabIndex = 9;
            this.textBoxSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSeries_KeyPress);
            this.textBoxSeries.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(29, 100);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModel.MaxLength = 100;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(132, 22);
            this.textBoxModel.TabIndex = 10;
            this.textBoxModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModel_KeyPress);
            this.textBoxModel.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarFreq.LargeChange = 1;
            this.trackBarFreq.Location = new System.Drawing.Point(29, 178);
            this.trackBarFreq.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarFreq.Maximum = 5;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(139, 56);
            this.trackBarFreq.TabIndex = 12;
            this.trackBarFreq.Value = 3;
            this.trackBarFreq.Scroll += new System.EventHandler(this.trackBarFreq_Scroll);
            // 
            // trackBarMaxFreq
            // 
            this.trackBarMaxFreq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarMaxFreq.LargeChange = 2;
            this.trackBarMaxFreq.Location = new System.Drawing.Point(239, 178);
            this.trackBarMaxFreq.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarMaxFreq.Name = "trackBarMaxFreq";
            this.trackBarMaxFreq.Size = new System.Drawing.Size(139, 56);
            this.trackBarMaxFreq.TabIndex = 13;
            this.trackBarMaxFreq.Value = 4;
            this.trackBarMaxFreq.Scroll += new System.EventHandler(this.trackBarMaxFreq_Scroll);
            // 
            // numericUpDownL1
            // 
            this.numericUpDownL1.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownL1.Location = new System.Drawing.Point(87, 345);
            this.numericUpDownL1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownL1.Name = "numericUpDownL1";
            this.numericUpDownL1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownL1.TabIndex = 14;
            // 
            // numericUpDownL2
            // 
            this.numericUpDownL2.Location = new System.Drawing.Point(225, 343);
            this.numericUpDownL2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownL2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownL2.Name = "numericUpDownL2";
            this.numericUpDownL2.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownL2.TabIndex = 15;
            // 
            // numericUpDownL3
            // 
            this.numericUpDownL3.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownL3.Location = new System.Drawing.Point(363, 343);
            this.numericUpDownL3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownL3.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownL3.Name = "numericUpDownL3";
            this.numericUpDownL3.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownL3.TabIndex = 16;
            // 
            // labelL1
            // 
            this.labelL1.AutoSize = true;
            this.labelL1.Location = new System.Drawing.Point(29, 347);
            this.labelL1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelL1.Name = "labelL1";
            this.labelL1.Size = new System.Drawing.Size(55, 17);
            this.labelL1.TabIndex = 17;
            this.labelL1.Text = "L1 (Кб)";
            // 
            // labelL2
            // 
            this.labelL2.AutoSize = true;
            this.labelL2.Location = new System.Drawing.Point(164, 347);
            this.labelL2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelL2.Name = "labelL2";
            this.labelL2.Size = new System.Drawing.Size(57, 17);
            this.labelL2.TabIndex = 18;
            this.labelL2.Text = "L2 (Мб)";
            // 
            // labelL3
            // 
            this.labelL3.AutoSize = true;
            this.labelL3.Location = new System.Drawing.Point(305, 347);
            this.labelL3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelL3.Name = "labelL3";
            this.labelL3.Size = new System.Drawing.Size(57, 17);
            this.labelL3.TabIndex = 19;
            this.labelL3.Text = "L3 (Мб)";
            // 
            // numericUpDownCores
            // 
            this.numericUpDownCores.Location = new System.Drawing.Point(239, 101);
            this.numericUpDownCores.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownCores.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownCores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCores.Name = "numericUpDownCores";
            this.numericUpDownCores.Size = new System.Drawing.Size(133, 22);
            this.numericUpDownCores.TabIndex = 20;
            this.numericUpDownCores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.Location = new System.Drawing.Point(349, 416);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // FormProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 462);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownCores);
            this.Controls.Add(this.labelL3);
            this.Controls.Add(this.labelL2);
            this.Controls.Add(this.labelL1);
            this.Controls.Add(this.numericUpDownL3);
            this.Controls.Add(this.numericUpDownL2);
            this.Controls.Add(this.numericUpDownL1);
            this.Controls.Add(this.trackBarMaxFreq);
            this.Controls.Add(this.trackBarFreq);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxSeries);
            this.Controls.Add(this.textBoxProducer);
            this.Controls.Add(this.labelCacheSize);
            this.Controls.Add(this.groupBoxBitArchitecture);
            this.Controls.Add(this.labelMaxFrequency);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelNumOfCores);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelSeries);
            this.Controls.Add(this.labelProducer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormProcessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Процессор";
            this.groupBoxBitArchitecture.ResumeLayout(false);
            this.groupBoxBitArchitecture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.Label labelSeries;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelNumOfCores;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelMaxFrequency;
        private System.Windows.Forms.GroupBox groupBoxBitArchitecture;
        private System.Windows.Forms.RadioButton radioButton64bit;
        private System.Windows.Forms.RadioButton radioButton32bit;
        private System.Windows.Forms.Label labelCacheSize;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.TextBox textBoxSeries;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.TrackBar trackBarMaxFreq;
        private System.Windows.Forms.NumericUpDown numericUpDownL1;
        private System.Windows.Forms.NumericUpDown numericUpDownL2;
        private System.Windows.Forms.NumericUpDown numericUpDownL3;
        private System.Windows.Forms.Label labelL1;
        private System.Windows.Forms.Label labelL2;
        private System.Windows.Forms.Label labelL3;
        private System.Windows.Forms.NumericUpDown numericUpDownCores;
        private System.Windows.Forms.Button buttonOK;
    }
}
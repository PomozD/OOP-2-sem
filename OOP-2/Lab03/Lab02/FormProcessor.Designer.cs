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
            this.components = new System.ComponentModel.Container();
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
            this.epProd = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSeries = new System.Windows.Forms.ErrorProvider(this.components);
            this.epModel = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxBitArchitecture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModel)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(22, 13);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(89, 13);
            this.labelProducer.TabIndex = 0;
            this.labelProducer.Text = "Производитель:";
            // 
            // labelSeries
            // 
            this.labelSeries.AutoSize = true;
            this.labelSeries.Location = new System.Drawing.Point(176, 13);
            this.labelSeries.Name = "labelSeries";
            this.labelSeries.Size = new System.Drawing.Size(41, 13);
            this.labelSeries.TabIndex = 1;
            this.labelSeries.Text = "Серия:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(22, 64);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(49, 13);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Модель:";
            // 
            // labelNumOfCores
            // 
            this.labelNumOfCores.AutoSize = true;
            this.labelNumOfCores.Location = new System.Drawing.Point(176, 66);
            this.labelNumOfCores.Name = "labelNumOfCores";
            this.labelNumOfCores.Size = new System.Drawing.Size(96, 13);
            this.labelNumOfCores.TabIndex = 3;
            this.labelNumOfCores.Text = "Количество ядер:";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(22, 120);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(52, 13);
            this.labelFrequency.TabIndex = 4;
            this.labelFrequency.Text = "Частота:";
            // 
            // labelMaxFrequency
            // 
            this.labelMaxFrequency.AutoSize = true;
            this.labelMaxFrequency.Location = new System.Drawing.Point(176, 120);
            this.labelMaxFrequency.Name = "labelMaxFrequency";
            this.labelMaxFrequency.Size = new System.Drawing.Size(129, 13);
            this.labelMaxFrequency.TabIndex = 5;
            this.labelMaxFrequency.Text = "Максимальная частота:";
            // 
            // groupBoxBitArchitecture
            // 
            this.groupBoxBitArchitecture.Controls.Add(this.radioButton64bit);
            this.groupBoxBitArchitecture.Controls.Add(this.radioButton32bit);
            this.groupBoxBitArchitecture.Location = new System.Drawing.Point(16, 196);
            this.groupBoxBitArchitecture.Name = "groupBoxBitArchitecture";
            this.groupBoxBitArchitecture.Size = new System.Drawing.Size(201, 42);
            this.groupBoxBitArchitecture.TabIndex = 6;
            this.groupBoxBitArchitecture.TabStop = false;
            this.groupBoxBitArchitecture.Text = "Разрядность архитектуры:";
            // 
            // radioButton64bit
            // 
            this.radioButton64bit.AutoSize = true;
            this.radioButton64bit.Location = new System.Drawing.Point(89, 19);
            this.radioButton64bit.Name = "radioButton64bit";
            this.radioButton64bit.Size = new System.Drawing.Size(37, 17);
            this.radioButton64bit.TabIndex = 1;
            this.radioButton64bit.Text = "64";
            this.radioButton64bit.UseVisualStyleBackColor = true;
            // 
            // radioButton32bit
            // 
            this.radioButton32bit.AutoSize = true;
            this.radioButton32bit.Checked = true;
            this.radioButton32bit.Location = new System.Drawing.Point(9, 19);
            this.radioButton32bit.Name = "radioButton32bit";
            this.radioButton32bit.Size = new System.Drawing.Size(37, 17);
            this.radioButton32bit.TabIndex = 0;
            this.radioButton32bit.TabStop = true;
            this.radioButton32bit.Text = "32";
            this.radioButton32bit.UseVisualStyleBackColor = true;
            // 
            // labelCacheSize
            // 
            this.labelCacheSize.AutoSize = true;
            this.labelCacheSize.Location = new System.Drawing.Point(22, 255);
            this.labelCacheSize.Name = "labelCacheSize";
            this.labelCacheSize.Size = new System.Drawing.Size(78, 13);
            this.labelCacheSize.TabIndex = 7;
            this.labelCacheSize.Text = "Размер кэша:";
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(22, 30);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(100, 20);
            this.textBoxProducer.TabIndex = 8;
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(179, 29);
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeries.TabIndex = 9;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(22, 81);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 10;
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarFreq.LargeChange = 1;
            this.trackBarFreq.Location = new System.Drawing.Point(22, 145);
            this.trackBarFreq.Maximum = 5;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(104, 45);
            this.trackBarFreq.TabIndex = 12;
            this.trackBarFreq.Value = 3;
            this.trackBarFreq.Scroll += new System.EventHandler(this.trackBarFreq_Scroll);
            // 
            // trackBarMaxFreq
            // 
            this.trackBarMaxFreq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarMaxFreq.LargeChange = 2;
            this.trackBarMaxFreq.Location = new System.Drawing.Point(179, 145);
            this.trackBarMaxFreq.Name = "trackBarMaxFreq";
            this.trackBarMaxFreq.Size = new System.Drawing.Size(104, 45);
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
            this.numericUpDownL1.Location = new System.Drawing.Point(65, 280);
            this.numericUpDownL1.Name = "numericUpDownL1";
            this.numericUpDownL1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownL1.TabIndex = 14;
            // 
            // numericUpDownL2
            // 
            this.numericUpDownL2.Location = new System.Drawing.Point(169, 279);
            this.numericUpDownL2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownL2.Name = "numericUpDownL2";
            this.numericUpDownL2.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownL2.TabIndex = 15;
            // 
            // numericUpDownL3
            // 
            this.numericUpDownL3.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownL3.Location = new System.Drawing.Point(272, 279);
            this.numericUpDownL3.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownL3.Name = "numericUpDownL3";
            this.numericUpDownL3.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownL3.TabIndex = 16;
            // 
            // labelL1
            // 
            this.labelL1.AutoSize = true;
            this.labelL1.Location = new System.Drawing.Point(22, 282);
            this.labelL1.Name = "labelL1";
            this.labelL1.Size = new System.Drawing.Size(41, 13);
            this.labelL1.TabIndex = 17;
            this.labelL1.Text = "L1 (Кб)";
            // 
            // labelL2
            // 
            this.labelL2.AutoSize = true;
            this.labelL2.Location = new System.Drawing.Point(123, 282);
            this.labelL2.Name = "labelL2";
            this.labelL2.Size = new System.Drawing.Size(43, 13);
            this.labelL2.TabIndex = 18;
            this.labelL2.Text = "L2 (Мб)";
            // 
            // labelL3
            // 
            this.labelL3.AutoSize = true;
            this.labelL3.Location = new System.Drawing.Point(229, 282);
            this.labelL3.Name = "labelL3";
            this.labelL3.Size = new System.Drawing.Size(43, 13);
            this.labelL3.TabIndex = 19;
            this.labelL3.Text = "L3 (Мб)";
            // 
            // numericUpDownCores
            // 
            this.numericUpDownCores.Location = new System.Drawing.Point(179, 82);
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
            this.numericUpDownCores.Size = new System.Drawing.Size(100, 20);
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
            this.buttonOK.Location = new System.Drawing.Point(262, 338);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // epProd
            // 
            this.epProd.ContainerControl = this;
            // 
            // epSeries
            // 
            this.epSeries.ContainerControl = this;
            // 
            // epModel
            // 
            this.epModel.ContainerControl = this;
            // 
            // FormProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 375);
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
            ((System.ComponentModel.ISupportInitialize)(this.epProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModel)).EndInit();
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
        private System.Windows.Forms.ErrorProvider epProd;
        private System.Windows.Forms.ErrorProvider epSeries;
        private System.Windows.Forms.ErrorProvider epModel;
    }
}
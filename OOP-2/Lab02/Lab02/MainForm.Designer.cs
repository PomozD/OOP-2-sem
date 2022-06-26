namespace Lab02
{
    partial class MainForm
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
            this.groupBoxTypeOfComputer = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelProcessor = new System.Windows.Forms.Label();
            this.buttonInfoProcessor = new System.Windows.Forms.Button();
            this.buttonInfoGraphicsCard = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelGraphicsCard = new System.Windows.Forms.Label();
            this.labelPurchaseDate = new System.Windows.Forms.Label();
            this.trackBarSizeRAM = new System.Windows.Forms.TrackBar();
            this.trackBarSizeHardDrive = new System.Windows.Forms.TrackBar();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.comboBoxHardDrive = new System.Windows.Forms.ComboBox();
            this.comboBoxRAM = new System.Windows.Forms.ComboBox();
            this.labelSizeRAM = new System.Windows.Forms.Label();
            this.labelTypeOfRAM = new System.Windows.Forms.Label();
            this.labelSizeHardDrive = new System.Windows.Forms.Label();
            this.labelTypeOfHardDrive = new System.Windows.Forms.Label();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.buttonShowXML = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxTypeOfComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeHardDrive)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTypeOfComputer
            // 
            this.groupBoxTypeOfComputer.Controls.Add(this.radioButton4);
            this.groupBoxTypeOfComputer.Controls.Add(this.radioButton3);
            this.groupBoxTypeOfComputer.Controls.Add(this.radioButton2);
            this.groupBoxTypeOfComputer.Controls.Add(this.radioButton1);
            this.groupBoxTypeOfComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTypeOfComputer.Location = new System.Drawing.Point(24, 12);
            this.groupBoxTypeOfComputer.Name = "groupBoxTypeOfComputer";
            this.groupBoxTypeOfComputer.Size = new System.Drawing.Size(136, 117);
            this.groupBoxTypeOfComputer.TabIndex = 0;
            this.groupBoxTypeOfComputer.TabStop = false;
            this.groupBoxTypeOfComputer.Text = "Тип компьютера:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(7, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "планшет";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButtonTypeOfComputer_Changed);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "ноутбук";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtonTypeOfComputer_Changed);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "рабочая станция";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtonTypeOfComputer_Changed);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "сервер";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonTypeOfComputer_Changed);
            // 
            // labelProcessor
            // 
            this.labelProcessor.AutoSize = true;
            this.labelProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessor.Location = new System.Drawing.Point(32, 141);
            this.labelProcessor.Name = "labelProcessor";
            this.labelProcessor.Size = new System.Drawing.Size(70, 15);
            this.labelProcessor.TabIndex = 1;
            this.labelProcessor.Text = "Процессор";
            // 
            // buttonInfoProcessor
            // 
            this.buttonInfoProcessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfoProcessor.Location = new System.Drawing.Point(24, 159);
            this.buttonInfoProcessor.Name = "buttonInfoProcessor";
            this.buttonInfoProcessor.Size = new System.Drawing.Size(136, 36);
            this.buttonInfoProcessor.TabIndex = 2;
            this.buttonInfoProcessor.Text = "Добавить информацию";
            this.buttonInfoProcessor.UseVisualStyleBackColor = true;
            this.buttonInfoProcessor.Click += new System.EventHandler(this.buttonInfoProcessor_Click);
            // 
            // buttonInfoGraphicsCard
            // 
            this.buttonInfoGraphicsCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfoGraphicsCard.Location = new System.Drawing.Point(24, 235);
            this.buttonInfoGraphicsCard.Name = "buttonInfoGraphicsCard";
            this.buttonInfoGraphicsCard.Size = new System.Drawing.Size(136, 35);
            this.buttonInfoGraphicsCard.TabIndex = 3;
            this.buttonInfoGraphicsCard.Text = "Добавить информацию";
            this.buttonInfoGraphicsCard.UseVisualStyleBackColor = true;
            this.buttonInfoGraphicsCard.Click += new System.EventHandler(this.buttonInfoGraphicsCard_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(216, 433);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2022, 3, 22, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelGraphicsCard
            // 
            this.labelGraphicsCard.AutoSize = true;
            this.labelGraphicsCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraphicsCard.Location = new System.Drawing.Point(32, 217);
            this.labelGraphicsCard.Name = "labelGraphicsCard";
            this.labelGraphicsCard.Size = new System.Drawing.Size(77, 15);
            this.labelGraphicsCard.TabIndex = 5;
            this.labelGraphicsCard.Text = "Видеокарта";
            // 
            // labelPurchaseDate
            // 
            this.labelPurchaseDate.AutoSize = true;
            this.labelPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPurchaseDate.Location = new System.Drawing.Point(216, 410);
            this.labelPurchaseDate.Name = "labelPurchaseDate";
            this.labelPurchaseDate.Size = new System.Drawing.Size(127, 15);
            this.labelPurchaseDate.TabIndex = 6;
            this.labelPurchaseDate.Text = "Дата приобретения:";
            // 
            // trackBarSizeRAM
            // 
            this.trackBarSizeRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSizeRAM.LargeChange = 4;
            this.trackBarSizeRAM.Location = new System.Drawing.Point(6, 38);
            this.trackBarSizeRAM.Maximum = 32;
            this.trackBarSizeRAM.Name = "trackBarSizeRAM";
            this.trackBarSizeRAM.Size = new System.Drawing.Size(121, 45);
            this.trackBarSizeRAM.SmallChange = 2;
            this.trackBarSizeRAM.TabIndex = 9;
            this.trackBarSizeRAM.TickFrequency = 4;
            this.trackBarSizeRAM.Value = 16;
            this.trackBarSizeRAM.Scroll += new System.EventHandler(this.trackBarSizeRAM_Scroll);
            // 
            // trackBarSizeHardDrive
            // 
            this.trackBarSizeHardDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSizeHardDrive.LargeChange = 1;
            this.trackBarSizeHardDrive.Location = new System.Drawing.Point(6, 38);
            this.trackBarSizeHardDrive.Maximum = 6;
            this.trackBarSizeHardDrive.Name = "trackBarSizeHardDrive";
            this.trackBarSizeHardDrive.Size = new System.Drawing.Size(122, 45);
            this.trackBarSizeHardDrive.TabIndex = 10;
            this.trackBarSizeHardDrive.Value = 3;
            this.trackBarSizeHardDrive.Scroll += new System.EventHandler(this.trackBarSizeHardDrive_Scroll);
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.Location = new System.Drawing.Point(219, 32);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.ReadOnly = true;
            this.textBoxInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInformation.Size = new System.Drawing.Size(254, 367);
            this.textBoxInformation.TabIndex = 11;
            // 
            // comboBoxHardDrive
            // 
            this.comboBoxHardDrive.FormattingEnabled = true;
            this.comboBoxHardDrive.Location = new System.Drawing.Point(6, 103);
            this.comboBoxHardDrive.Name = "comboBoxHardDrive";
            this.comboBoxHardDrive.Size = new System.Drawing.Size(121, 23);
            this.comboBoxHardDrive.TabIndex = 12;
            this.comboBoxHardDrive.SelectedIndexChanged += new System.EventHandler(this.comboBoxHardDrive_SelectedIndexChanged);
            // 
            // comboBoxRAM
            // 
            this.comboBoxRAM.FormattingEnabled = true;
            this.comboBoxRAM.Location = new System.Drawing.Point(6, 103);
            this.comboBoxRAM.Name = "comboBoxRAM";
            this.comboBoxRAM.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRAM.TabIndex = 13;
            this.comboBoxRAM.SelectedIndexChanged += new System.EventHandler(this.comboBoxRAM_SelectedIndexChanged);
            // 
            // labelSizeRAM
            // 
            this.labelSizeRAM.AutoSize = true;
            this.labelSizeRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSizeRAM.Location = new System.Drawing.Point(7, 19);
            this.labelSizeRAM.Name = "labelSizeRAM";
            this.labelSizeRAM.Size = new System.Drawing.Size(49, 13);
            this.labelSizeRAM.TabIndex = 14;
            this.labelSizeRAM.Text = "Размер:";
            // 
            // labelTypeOfRAM
            // 
            this.labelTypeOfRAM.AutoSize = true;
            this.labelTypeOfRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeOfRAM.Location = new System.Drawing.Point(7, 86);
            this.labelTypeOfRAM.Name = "labelTypeOfRAM";
            this.labelTypeOfRAM.Size = new System.Drawing.Size(29, 13);
            this.labelTypeOfRAM.TabIndex = 15;
            this.labelTypeOfRAM.Text = "Тип:";
            // 
            // labelSizeHardDrive
            // 
            this.labelSizeHardDrive.AutoSize = true;
            this.labelSizeHardDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSizeHardDrive.Location = new System.Drawing.Point(8, 19);
            this.labelSizeHardDrive.Name = "labelSizeHardDrive";
            this.labelSizeHardDrive.Size = new System.Drawing.Size(49, 13);
            this.labelSizeHardDrive.TabIndex = 16;
            this.labelSizeHardDrive.Text = "Размер:";
            // 
            // labelTypeOfHardDrive
            // 
            this.labelTypeOfHardDrive.AutoSize = true;
            this.labelTypeOfHardDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeOfHardDrive.Location = new System.Drawing.Point(8, 86);
            this.labelTypeOfHardDrive.Name = "labelTypeOfHardDrive";
            this.labelTypeOfHardDrive.Size = new System.Drawing.Size(26, 13);
            this.labelTypeOfHardDrive.TabIndex = 17;
            this.labelTypeOfHardDrive.Text = "Тип";
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveXML.Location = new System.Drawing.Point(363, 503);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(125, 36);
            this.buttonSaveXML.TabIndex = 18;
            this.buttonSaveXML.Text = "Сохранить информацию в XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.buttonSaveXML_Click);
            // 
            // buttonShowXML
            // 
            this.buttonShowXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowXML.Location = new System.Drawing.Point(363, 545);
            this.buttonShowXML.Name = "buttonShowXML";
            this.buttonShowXML.Size = new System.Drawing.Size(125, 36);
            this.buttonShowXML.TabIndex = 19;
            this.buttonShowXML.Text = "Вывести информацию из XML";
            this.buttonShowXML.UseVisualStyleBackColor = true;
            this.buttonShowXML.Click += new System.EventHandler(this.buttonShowXML_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation.Location = new System.Drawing.Point(219, 13);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(88, 15);
            this.labelInformation.TabIndex = 20;
            this.labelInformation.Text = "Информация:";
            // 
            // buttonShow
            // 
            this.buttonShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShow.Location = new System.Drawing.Point(363, 419);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(125, 36);
            this.buttonShow.TabIndex = 21;
            this.buttonShow.Text = "Вывод";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Location = new System.Drawing.Point(363, 461);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 36);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxHardDrive);
            this.groupBox1.Controls.Add(this.trackBarSizeHardDrive);
            this.groupBox1.Controls.Add(this.labelSizeHardDrive);
            this.groupBox1.Controls.Add(this.labelTypeOfHardDrive);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(24, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 139);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Жесткий диск";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSizeRAM);
            this.groupBox2.Controls.Add(this.trackBarSizeRAM);
            this.groupBox2.Controls.Add(this.comboBoxRAM);
            this.groupBox2.Controls.Add(this.labelTypeOfRAM);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(24, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 139);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ОЗУ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.buttonShowXML);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.labelPurchaseDate);
            this.Controls.Add(this.labelGraphicsCard);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonInfoGraphicsCard);
            this.Controls.Add(this.buttonInfoProcessor);
            this.Controls.Add(this.labelProcessor);
            this.Controls.Add(this.groupBoxTypeOfComputer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компьютер";
            this.groupBoxTypeOfComputer.ResumeLayout(false);
            this.groupBoxTypeOfComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeHardDrive)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTypeOfComputer;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label labelProcessor;
        private System.Windows.Forms.Button buttonInfoProcessor;
        private System.Windows.Forms.Button buttonInfoGraphicsCard;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelGraphicsCard;
        private System.Windows.Forms.Label labelPurchaseDate;
        private System.Windows.Forms.TrackBar trackBarSizeRAM;
        private System.Windows.Forms.TrackBar trackBarSizeHardDrive;
        private System.Windows.Forms.TextBox textBoxInformation;
        private System.Windows.Forms.ComboBox comboBoxHardDrive;
        private System.Windows.Forms.ComboBox comboBoxRAM;
        private System.Windows.Forms.Label labelSizeRAM;
        private System.Windows.Forms.Label labelTypeOfRAM;
        private System.Windows.Forms.Label labelSizeHardDrive;
        private System.Windows.Forms.Label labelTypeOfHardDrive;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.Button buttonShowXML;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


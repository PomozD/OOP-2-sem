namespace Lab02
{
    partial class FormSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxProd = new System.Windows.Forms.TextBox();
            this.checkBoxModel = new System.Windows.Forms.CheckBox();
            this.checkBoxProd = new System.Windows.Forms.CheckBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proccessor_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proccessor_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processor_freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GC_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxModel);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxProd);
            this.groupBox1.Controls.Add(this.checkBoxModel);
            this.groupBox1.Controls.Add(this.checkBoxProd);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(684, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(260, 66);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxModel.Multiline = true;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(205, 21);
            this.textBoxModel.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(489, 37);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 52);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxProd
            // 
            this.textBoxProd.Location = new System.Drawing.Point(260, 37);
            this.textBoxProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProd.Multiline = true;
            this.textBoxProd.Name = "textBoxProd";
            this.textBoxProd.Size = new System.Drawing.Size(205, 21);
            this.textBoxProd.TabIndex = 2;
            this.textBoxProd.TextChanged += new System.EventHandler(this.textBoxProd_TextChanged);
            // 
            // checkBoxModel
            // 
            this.checkBoxModel.AutoSize = true;
            this.checkBoxModel.Location = new System.Drawing.Point(8, 66);
            this.checkBoxModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxModel.Name = "checkBoxModel";
            this.checkBoxModel.Size = new System.Drawing.Size(181, 21);
            this.checkBoxModel.TabIndex = 1;
            this.checkBoxModel.Text = "по модели процессора";
            this.checkBoxModel.UseVisualStyleBackColor = true;
            // 
            // checkBoxProd
            // 
            this.checkBoxProd.AutoSize = true;
            this.checkBoxProd.Location = new System.Drawing.Point(8, 37);
            this.checkBoxProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxProd.Name = "checkBoxProd";
            this.checkBoxProd.Size = new System.Drawing.Size(235, 21);
            this.checkBoxProd.TabIndex = 0;
            this.checkBoxProd.Text = "по производителю процессора";
            this.checkBoxProd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Proccessor_prod,
            this.Proccessor_model,
            this.Processor_freq,
            this.GC_prod,
            this.Cost});
            this.dataGridViewSearch.Location = new System.Drawing.Point(17, 140);
            this.dataGridViewSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.Size = new System.Drawing.Size(684, 234);
            this.dataGridViewSearch.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.FillWeight = 90F;
            this.Type.HeaderText = "Тип компьютера";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 75;
            // 
            // Proccessor_prod
            // 
            this.Proccessor_prod.FillWeight = 90F;
            this.Proccessor_prod.HeaderText = "Производитель процессора";
            this.Proccessor_prod.MinimumWidth = 6;
            this.Proccessor_prod.Name = "Proccessor_prod";
            this.Proccessor_prod.ReadOnly = true;
            this.Proccessor_prod.Width = 90;
            // 
            // Proccessor_model
            // 
            this.Proccessor_model.FillWeight = 90F;
            this.Proccessor_model.HeaderText = "Модель процессора";
            this.Proccessor_model.MinimumWidth = 6;
            this.Proccessor_model.Name = "Proccessor_model";
            this.Proccessor_model.ReadOnly = true;
            this.Proccessor_model.Width = 75;
            // 
            // Processor_freq
            // 
            this.Processor_freq.FillWeight = 90F;
            this.Processor_freq.HeaderText = "Частота процессора";
            this.Processor_freq.MinimumWidth = 6;
            this.Processor_freq.Name = "Processor_freq";
            this.Processor_freq.ReadOnly = true;
            this.Processor_freq.Width = 70;
            // 
            // GC_prod
            // 
            this.GC_prod.FillWeight = 90F;
            this.GC_prod.HeaderText = "Видеокарта";
            this.GC_prod.MinimumWidth = 6;
            this.GC_prod.Name = "GC_prod";
            this.GC_prod.ReadOnly = true;
            this.GC_prod.Width = 90;
            // 
            // Cost
            // 
            this.Cost.FillWeight = 90F;
            this.Cost.HeaderText = "Стоимость";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 70;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(600, 390);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 433);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxProd;
        private System.Windows.Forms.CheckBox checkBoxModel;
        private System.Windows.Forms.CheckBox checkBoxProd;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proccessor_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proccessor_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processor_freq;
        private System.Windows.Forms.DataGridViewTextBoxColumn GC_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Button buttonOK;
    }
}
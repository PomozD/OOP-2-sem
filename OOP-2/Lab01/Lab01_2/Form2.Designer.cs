namespace Lab01_2
{
    partial class Form2
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
            this.buttonSortAscending = new System.Windows.Forms.Button();
            this.buttonGenerateCollection = new System.Windows.Forms.Button();
            this.buttonSortDescending = new System.Windows.Forms.Button();
            this.buttonQuery1 = new System.Windows.Forms.Button();
            this.buttonQuery2 = new System.Windows.Forms.Button();
            this.buttonQuery3 = new System.Windows.Forms.Button();
            this.textBoxSizeOfCollection = new System.Windows.Forms.TextBox();
            this.labelSizeOfCollection = new System.Windows.Forms.Label();
            this.listViewOne = new System.Windows.Forms.ListView();
            this.listViewTwo = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonSortAscending
            // 
            this.buttonSortAscending.Location = new System.Drawing.Point(274, 75);
            this.buttonSortAscending.Name = "buttonSortAscending";
            this.buttonSortAscending.Size = new System.Drawing.Size(99, 63);
            this.buttonSortAscending.TabIndex = 0;
            this.buttonSortAscending.Text = "Сортировать по возрастанию";
            this.buttonSortAscending.UseVisualStyleBackColor = true;
            this.buttonSortAscending.Click += new System.EventHandler(this.buttonSortAscending_Click);
            // 
            // buttonGenerateCollection
            // 
            this.buttonGenerateCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerateCollection.Location = new System.Drawing.Point(62, 66);
            this.buttonGenerateCollection.Name = "buttonGenerateCollection";
            this.buttonGenerateCollection.Size = new System.Drawing.Size(148, 84);
            this.buttonGenerateCollection.TabIndex = 1;
            this.buttonGenerateCollection.Text = "Сгенерировать коллекцию";
            this.buttonGenerateCollection.UseVisualStyleBackColor = true;
            this.buttonGenerateCollection.Click += new System.EventHandler(this.buttonGenerateCollection_Click);
            // 
            // buttonSortDescending
            // 
            this.buttonSortDescending.Location = new System.Drawing.Point(410, 75);
            this.buttonSortDescending.Name = "buttonSortDescending";
            this.buttonSortDescending.Size = new System.Drawing.Size(99, 63);
            this.buttonSortDescending.TabIndex = 2;
            this.buttonSortDescending.Text = "Сортировать по убыванию";
            this.buttonSortDescending.UseVisualStyleBackColor = true;
            this.buttonSortDescending.Click += new System.EventHandler(this.buttonSortDescending_Click);
            // 
            // buttonQuery1
            // 
            this.buttonQuery1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuery1.Location = new System.Drawing.Point(100, 181);
            this.buttonQuery1.Name = "buttonQuery1";
            this.buttonQuery1.Size = new System.Drawing.Size(98, 62);
            this.buttonQuery1.TabIndex = 3;
            this.buttonQuery1.Text = "Запрос №1";
            this.buttonQuery1.UseVisualStyleBackColor = true;
            this.buttonQuery1.Click += new System.EventHandler(this.buttonQuery1_Click);
            // 
            // buttonQuery2
            // 
            this.buttonQuery2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuery2.Location = new System.Drawing.Point(233, 181);
            this.buttonQuery2.Name = "buttonQuery2";
            this.buttonQuery2.Size = new System.Drawing.Size(89, 62);
            this.buttonQuery2.TabIndex = 4;
            this.buttonQuery2.Text = "Запрос №2";
            this.buttonQuery2.UseVisualStyleBackColor = true;
            this.buttonQuery2.Click += new System.EventHandler(this.buttonQuery2_Click);
            // 
            // buttonQuery3
            // 
            this.buttonQuery3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuery3.Location = new System.Drawing.Point(365, 181);
            this.buttonQuery3.Name = "buttonQuery3";
            this.buttonQuery3.Size = new System.Drawing.Size(89, 61);
            this.buttonQuery3.TabIndex = 5;
            this.buttonQuery3.Text = "Запрос №3";
            this.buttonQuery3.UseVisualStyleBackColor = true;
            this.buttonQuery3.Click += new System.EventHandler(this.buttonQuery3_Click);
            // 
            // textBoxSizeOfCollection
            // 
            this.textBoxSizeOfCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSizeOfCollection.Location = new System.Drawing.Point(168, 18);
            this.textBoxSizeOfCollection.Name = "textBoxSizeOfCollection";
            this.textBoxSizeOfCollection.Size = new System.Drawing.Size(77, 26);
            this.textBoxSizeOfCollection.TabIndex = 6;
            // 
            // labelSizeOfCollection
            // 
            this.labelSizeOfCollection.AutoSize = true;
            this.labelSizeOfCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSizeOfCollection.Location = new System.Drawing.Point(12, 21);
            this.labelSizeOfCollection.Name = "labelSizeOfCollection";
            this.labelSizeOfCollection.Size = new System.Drawing.Size(154, 20);
            this.labelSizeOfCollection.TabIndex = 9;
            this.labelSizeOfCollection.Text = "Размер коллекции:";
            // 
            // listViewOne
            // 
            this.listViewOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewOne.Location = new System.Drawing.Point(48, 276);
            this.listViewOne.Name = "listViewOne";
            this.listViewOne.Size = new System.Drawing.Size(205, 173);
            this.listViewOne.TabIndex = 11;
            this.listViewOne.UseCompatibleStateImageBehavior = false;
            this.listViewOne.View = System.Windows.Forms.View.List;
            // 
            // listViewTwo
            // 
            this.listViewTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewTwo.Location = new System.Drawing.Point(293, 276);
            this.listViewTwo.Name = "listViewTwo";
            this.listViewTwo.Size = new System.Drawing.Size(205, 173);
            this.listViewTwo.TabIndex = 12;
            this.listViewTwo.UseCompatibleStateImageBehavior = false;
            this.listViewTwo.View = System.Windows.Forms.View.List;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 469);
            this.Controls.Add(this.listViewTwo);
            this.Controls.Add(this.listViewOne);
            this.Controls.Add(this.labelSizeOfCollection);
            this.Controls.Add(this.textBoxSizeOfCollection);
            this.Controls.Add(this.buttonQuery3);
            this.Controls.Add(this.buttonQuery2);
            this.Controls.Add(this.buttonQuery1);
            this.Controls.Add(this.buttonSortDescending);
            this.Controls.Add(this.buttonGenerateCollection);
            this.Controls.Add(this.buttonSortAscending);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSortAscending;
        private System.Windows.Forms.Button buttonGenerateCollection;
        private System.Windows.Forms.Button buttonSortDescending;
        private System.Windows.Forms.Button buttonQuery1;
        private System.Windows.Forms.Button buttonQuery2;
        private System.Windows.Forms.Button buttonQuery3;
        private System.Windows.Forms.TextBox textBoxSizeOfCollection;
        private System.Windows.Forms.Label labelSizeOfCollection;
        private System.Windows.Forms.ListView listViewOne;
        private System.Windows.Forms.ListView listViewTwo;
    }
}


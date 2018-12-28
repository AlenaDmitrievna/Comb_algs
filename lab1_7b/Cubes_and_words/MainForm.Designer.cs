namespace Cubes_and_words
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
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dataGridView_Cubes = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.listBox_dictionary = new System.Windows.Forms.ListBox();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.textBox_Word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_count_words = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            this.btn_DeleteWord = new System.Windows.Forms.Button();
            this.btn_DeleteRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cubes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_About
            // 
            this.btn_About.Location = new System.Drawing.Point(725, 397);
            this.btn_About.Margin = new System.Windows.Forms.Padding(4);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(227, 28);
            this.btn_About.TabIndex = 0;
            this.btn_About.Text = "Задание";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(724, 433);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(228, 28);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dataGridView_Cubes
            // 
            this.dataGridView_Cubes.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView_Cubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cubes.Location = new System.Drawing.Point(257, 42);
            this.dataGridView_Cubes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Cubes.Name = "dataGridView_Cubes";
            this.dataGridView_Cubes.Size = new System.Drawing.Size(225, 419);
            this.dataGridView_Cubes.TabIndex = 2;
            this.dataGridView_Cubes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Cubes_CellEnter);
            this.dataGridView_Cubes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_Cubes_EditingControlShowing);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(725, 304);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(228, 28);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Очистить всё";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.Location = new System.Drawing.Point(721, 38);
            this.btn_LoadFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(232, 28);
            this.btn_LoadFromFile.TabIndex = 6;
            this.btn_LoadFromFile.Text = "Загрузить словарь из файла";
            this.btn_LoadFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadFromFile.Click += new System.EventHandler(this.btn_LoadFromFile_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(864, 86);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(89, 28);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Добавить слово";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // listBox_dictionary
            // 
            this.listBox_dictionary.FormattingEnabled = true;
            this.listBox_dictionary.ItemHeight = 16;
            this.listBox_dictionary.Location = new System.Drawing.Point(16, 42);
            this.listBox_dictionary.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_dictionary.Name = "listBox_dictionary";
            this.listBox_dictionary.Size = new System.Drawing.Size(233, 420);
            this.listBox_dictionary.TabIndex = 8;
            this.listBox_dictionary.Enter += new System.EventHandler(this.listBox_dictionary_Enter);
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(725, 158);
            this.numUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(93, 22);
            this.numUpDown.TabIndex = 9;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Enter += new System.EventHandler(this.numUpDown_Enter);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(826, 154);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(127, 28);
            this.btn_Generate.TabIndex = 10;
            this.btn_Generate.Text = "Сгенерировать кубики";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // textBox_Word
            // 
            this.textBox_Word.Location = new System.Drawing.Point(724, 89);
            this.textBox_Word.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Word.Name = "textBox_Word";
            this.textBox_Word.Size = new System.Drawing.Size(132, 22);
            this.textBox_Word.TabIndex = 3;
            this.textBox_Word.Enter += new System.EventHandler(this.textBox_Word_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "К-во кубиков";
            // 
            // lbl_count_words
            // 
            this.lbl_count_words.AutoSize = true;
            this.lbl_count_words.Location = new System.Drawing.Point(488, 21);
            this.lbl_count_words.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_count_words.Name = "lbl_count_words";
            this.lbl_count_words.Size = new System.Drawing.Size(84, 17);
            this.lbl_count_words.TabIndex = 13;
            this.lbl_count_words.Text = "Результат: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Словарь: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(254, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Кубики: ";
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(724, 242);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(227, 28);
            this.btn_Run.TabIndex = 16;
            this.btn_Run.Text = "Выполнить";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // listBox_Result
            // 
            this.listBox_Result.FormattingEnabled = true;
            this.listBox_Result.ItemHeight = 16;
            this.listBox_Result.Location = new System.Drawing.Point(490, 41);
            this.listBox_Result.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Result.Name = "listBox_Result";
            this.listBox_Result.Size = new System.Drawing.Size(221, 420);
            this.listBox_Result.TabIndex = 17;
            // 
            // btn_DeleteWord
            // 
            this.btn_DeleteWord.Location = new System.Drawing.Point(122, 12);
            this.btn_DeleteWord.Name = "btn_DeleteWord";
            this.btn_DeleteWord.Size = new System.Drawing.Size(127, 23);
            this.btn_DeleteWord.TabIndex = 20;
            this.btn_DeleteWord.Text = "Удалить слово";
            this.btn_DeleteWord.UseVisualStyleBackColor = true;
            this.btn_DeleteWord.Click += new System.EventHandler(this.btn_DeleteWord_Click);
            // 
            // btn_DeleteRow
            // 
            this.btn_DeleteRow.Location = new System.Drawing.Point(356, 12);
            this.btn_DeleteRow.Name = "btn_DeleteRow";
            this.btn_DeleteRow.Size = new System.Drawing.Size(125, 23);
            this.btn_DeleteRow.TabIndex = 21;
            this.btn_DeleteRow.Text = "Удалить строку";
            this.btn_DeleteRow.UseVisualStyleBackColor = true;
            this.btn_DeleteRow.Click += new System.EventHandler(this.btn_DeleteRow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 482);
            this.Controls.Add(this.btn_DeleteRow);
            this.Controls.Add(this.btn_DeleteWord);
            this.Controls.Add(this.listBox_Result);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_count_words);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.listBox_dictionary);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_LoadFromFile);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.textBox_Word);
            this.Controls.Add(this.dataGridView_Cubes);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_About);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cubes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView dataGridView_Cubes;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_LoadFromFile;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox listBox_dictionary;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox textBox_Word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_count_words;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.ListBox listBox_Result;
        private System.Windows.Forms.Button btn_DeleteWord;
        private System.Windows.Forms.Button btn_DeleteRow;
    }
}


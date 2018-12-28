namespace _3._3b.GeneticAlg
{
    partial class FormFiles
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
            this.btnTask = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.UseBackTrac = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.CapacityBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nudItems = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudElem = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGenSolve = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nudParentChrom = new System.Windows.Forms.NumericUpDown();
            this.nudMutCnt = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudChrom = new System.Windows.Forms.NumericUpDown();
            this.nudMutation = new System.Windows.Forms.NumericUpDown();
            this.nudSteps = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTimeGen = new System.Windows.Forms.TextBox();
            this.tbTimeEx = new System.Windows.Forms.TextBox();
            this.tbGen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExact = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParentChrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(22, 481);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(36, 36);
            this.btnTask.TabIndex = 72;
            this.btnTask.Text = "?";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(906, 129);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 21);
            this.radioButton2.TabIndex = 71;
            this.radioButton2.Text = "Полный перебор";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // UseBackTrac
            // 
            this.UseBackTrac.AutoSize = true;
            this.UseBackTrac.Checked = true;
            this.UseBackTrac.Location = new System.Drawing.Point(905, 97);
            this.UseBackTrac.Name = "UseBackTrac";
            this.UseBackTrac.Size = new System.Drawing.Size(103, 21);
            this.UseBackTrac.TabIndex = 70;
            this.UseBackTrac.TabStop = true;
            this.UseBackTrac.Text = "Бэктрекинг";
            this.UseBackTrac.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 17);
            this.label15.TabIndex = 69;
            this.label15.Text = "Размер носителя:";
            // 
            // CapacityBox
            // 
            this.CapacityBox.Location = new System.Drawing.Point(170, 36);
            this.CapacityBox.Name = "CapacityBox";
            this.CapacityBox.Size = new System.Drawing.Size(163, 22);
            this.CapacityBox.TabIndex = 68;
            this.CapacityBox.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.nudItems);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Location = new System.Drawing.Point(170, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 167);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "N";
            // 
            // nudItems
            // 
            this.nudItems.Location = new System.Drawing.Point(44, 12);
            this.nudItems.Margin = new System.Windows.Forms.Padding(4);
            this.nudItems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItems.Name = "nudItems";
            this.nudItems.Size = new System.Drawing.Size(104, 22);
            this.nudItems.TabIndex = 32;
            this.nudItems.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 42);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(136, 57);
            this.btnGenerate.TabIndex = 31;
            this.btnGenerate.Text = "Сгенерировать N размеров дискет";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 107);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 44);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudElem);
            this.groupBox1.Location = new System.Drawing.Point(170, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 155);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 104);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(136, 37);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 60);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Элемент:";
            // 
            // nudElem
            // 
            this.nudElem.Location = new System.Drawing.Point(12, 30);
            this.nudElem.Margin = new System.Windows.Forms.Padding(4);
            this.nudElem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudElem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudElem.Name = "nudElem";
            this.nudElem.Size = new System.Drawing.Size(136, 22);
            this.nudElem.TabIndex = 0;
            this.nudElem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(733, 248);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "Время в секундах:";
            // 
            // btnGenSolve
            // 
            this.btnGenSolve.Location = new System.Drawing.Point(735, 306);
            this.btnGenSolve.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenSolve.Name = "btnGenSolve";
            this.btnGenSolve.Size = new System.Drawing.Size(131, 82);
            this.btnGenSolve.TabIndex = 64;
            this.btnGenSolve.Text = "Решить генетическим алгоритмом";
            this.btnGenSolve.UseVisualStyleBackColor = true;
            this.btnGenSolve.Click += new System.EventHandler(this.btnGenSolve_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(903, 437);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 17);
            this.label12.TabIndex = 63;
            this.label12.Text = "Количество хромосом:";
            // 
            // nudParentChrom
            // 
            this.nudParentChrom.Location = new System.Drawing.Point(906, 538);
            this.nudParentChrom.Margin = new System.Windows.Forms.Padding(4);
            this.nudParentChrom.Name = "nudParentChrom";
            this.nudParentChrom.Size = new System.Drawing.Size(160, 22);
            this.nudParentChrom.TabIndex = 62;
            this.nudParentChrom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudMutCnt
            // 
            this.nudMutCnt.Location = new System.Drawing.Point(906, 392);
            this.nudMutCnt.Margin = new System.Windows.Forms.Padding(4);
            this.nudMutCnt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMutCnt.Name = "nudMutCnt";
            this.nudMutCnt.Size = new System.Drawing.Size(160, 22);
            this.nudMutCnt.TabIndex = 61;
            this.nudMutCnt.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(903, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 17);
            this.label11.TabIndex = 60;
            this.label11.Text = "Количество мутирующих хромосом:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(903, 517);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "в каждом поколении:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(903, 500);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Кол-во отобранных хромосом";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(902, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Вероятность мутации:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(903, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Максимальное количество шагов:";
            // 
            // nudChrom
            // 
            this.nudChrom.Location = new System.Drawing.Point(906, 458);
            this.nudChrom.Margin = new System.Windows.Forms.Padding(4);
            this.nudChrom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudChrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChrom.Name = "nudChrom";
            this.nudChrom.Size = new System.Drawing.Size(160, 22);
            this.nudChrom.TabIndex = 55;
            this.nudChrom.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudMutation
            // 
            this.nudMutation.Location = new System.Drawing.Point(906, 327);
            this.nudMutation.Margin = new System.Windows.Forms.Padding(4);
            this.nudMutation.Name = "nudMutation";
            this.nudMutation.Size = new System.Drawing.Size(160, 22);
            this.nudMutation.TabIndex = 54;
            this.nudMutation.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudSteps
            // 
            this.nudSteps.Location = new System.Drawing.Point(906, 268);
            this.nudSteps.Margin = new System.Windows.Forms.Padding(4);
            this.nudSteps.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudSteps.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSteps.Name = "nudSteps";
            this.nudSteps.Size = new System.Drawing.Size(156, 22);
            this.nudSteps.TabIndex = 53;
            this.nudSteps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Время в секундах:";
            // 
            // tbTimeGen
            // 
            this.tbTimeGen.Location = new System.Drawing.Point(735, 276);
            this.tbTimeGen.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimeGen.Name = "tbTimeGen";
            this.tbTimeGen.ReadOnly = true;
            this.tbTimeGen.Size = new System.Drawing.Size(132, 22);
            this.tbTimeGen.TabIndex = 51;
            // 
            // tbTimeEx
            // 
            this.tbTimeEx.Location = new System.Drawing.Point(735, 67);
            this.tbTimeEx.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimeEx.Name = "tbTimeEx";
            this.tbTimeEx.ReadOnly = true;
            this.tbTimeEx.Size = new System.Drawing.Size(132, 22);
            this.tbTimeEx.TabIndex = 50;
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(373, 277);
            this.tbGen.Margin = new System.Windows.Forms.Padding(4);
            this.tbGen.Multiline = true;
            this.tbGen.Name = "tbGen";
            this.tbGen.ReadOnly = true;
            this.tbGen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGen.Size = new System.Drawing.Size(344, 159);
            this.tbGen.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Решение генетического алгоритма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Решение точного алгоритма:";
            // 
            // tbExact
            // 
            this.tbExact.Location = new System.Drawing.Point(373, 67);
            this.tbExact.Margin = new System.Windows.Forms.Padding(4);
            this.tbExact.Multiline = true;
            this.tbExact.Name = "tbExact";
            this.tbExact.ReadOnly = true;
            this.tbExact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbExact.Size = new System.Drawing.Size(343, 157);
            this.tbExact.TabIndex = 46;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(22, 538);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 39);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(736, 97);
            this.btnDo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(131, 82);
            this.btnDo.TabIndex = 44;
            this.btnDo.Text = "Решить точным алгоритмом";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 16;
            this.lbFiles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lbFiles.Location = new System.Drawing.Point(22, 91);
            this.lbFiles.Margin = new System.Windows.Forms.Padding(4);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(124, 340);
            this.lbFiles.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Размеры файлов:";
            // 
            // FormFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 613);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.UseBackTrac);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CapacityBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnGenSolve);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudParentChrom);
            this.Controls.Add(this.nudMutCnt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudChrom);
            this.Controls.Add(this.nudMutation);
            this.Controls.Add(this.nudSteps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTimeGen);
            this.Controls.Add(this.tbTimeEx);
            this.Controls.Add(this.tbGen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbExact);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormFiles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача укладки по дискетам. Генетический алгоритм";
            ((System.ComponentModel.ISupportInitialize)(this.CapacityBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParentChrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton UseBackTrac;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown CapacityBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudItems;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudElem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGenSolve;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudParentChrom;
        private System.Windows.Forms.NumericUpDown nudMutCnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudChrom;
        private System.Windows.Forms.NumericUpDown nudMutation;
        private System.Windows.Forms.NumericUpDown nudSteps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTimeGen;
        private System.Windows.Forms.TextBox tbTimeEx;
        private System.Windows.Forms.TextBox tbGen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExact;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Label label2;
    }
}


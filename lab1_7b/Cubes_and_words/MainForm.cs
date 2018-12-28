using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cubes_and_words
{
    public partial class MainForm : Form
    {
        //Объект модуля с вспомогательными методами
        CubesHandler Handler ;
        //Список слов в словаре
        List<string> words = new List<string>();
        //Количество кубиков
        int cubes_amount;
        //матрица для кубиков
        string[,] cubes;
        const string chars = "abcdefghijklmnopqrstuvwxyz";
        List<string> result_words = new List<string>(); //список слов, которые можно выложить кубиками

        public MainForm()
        {
            InitializeComponent();
            btn_Run.Enabled = false;
            btn_DeleteWord.Enabled = false;
            btn_DeleteRow.Enabled = false;
        }

        //Условие задачи
        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "7. На детских кубиках с шести сторон изображены буквы. \n" +
                "Дан список слов, образующий словарь.\n" +
                "Необходимо подсчитать сколько слов из словаря можно выложить кубиками.\n" + 
                "b) Необходимо использовать все кубики.", "Кубики и слово.");
        }

        //Выход
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Очистить поля
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listBox_Result.Items.Clear();
            listBox_dictionary.Items.Clear();
            dataGridView_Cubes.Rows.Clear();
            words.Clear();
            result_words.Clear();
            textBox_Word.Clear();
            btn_Run.Enabled = false;
            lbl_count_words.Text= "Результат: ";
        }

        //Загрузить словарь из текстового файла
        private void btn_LoadFromFile_Click(object sender, EventArgs e)
        {
            listBox_dictionary.Items.Clear();
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Текстовый файл|*.txt";
                openFile.Title = "Выберите текстовый файл со словарем";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFile.FileName;
                    var fileStream = openFile.OpenFile();
                }
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox_dictionary.Items.Add(line);
                        words.Add(line.ToLower());
                    }
                }
            }
        }

        //Добавить слово в словарь
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string word = textBox_Word.Text;
            if (word == "")
            {
                MessageBox.Show(this, "Поле ввода не может быть пустым", "Ошибка ввода!");
                textBox_Word.Focus();
            }
            else
            {
                bool success = true;
                for (int i = 0; i < word.Length && success; i++)
                {
                    //Если у нас символы не буквы
                    if (!Char.IsLetter(word[i]))
                    {
                        success = false;
                        MessageBox.Show(this, "Слово не может состоять из цифр или иных служебных символов!", "Ошибка ввода!");
                        textBox_Word.Clear();
                        textBox_Word.Focus();
                    }
                }
                if (success)
                {
                    listBox_dictionary.Items.Add(word);
                    words.Add(word.ToLower());
                    textBox_Word.Clear();
                    textBox_Word.Focus();
                    btn_Generate.Enabled = true;
                }
            }
        }

        //генерация кубиков
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cubes_amount; i++)
            {
                dataGridView_Cubes.Rows.Clear();
            }
            btn_Run.Enabled = true;
            words.Clear();
            result_words.Clear();
            lbl_count_words.Text = "Результат: ";
            listBox_Result.Items.Clear();
            cubes_amount = (int)(numUpDown.Value);

            Random rnd = new Random();
            for (int i = 0; i < cubes_amount; i++)
            {
                dataGridView_Cubes.Rows.Add();
                for (int j = 0; j < 6; j++)
                {
                    char c = chars[rnd.Next(chars.Length)];
                    dataGridView_Cubes.Rows[i].Cells[j].Value = c;
                }                
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView_Cubes.RowCount = 1;
            dataGridView_Cubes.ColumnCount = 6;
            dataGridView_Cubes.AutoResizeColumns();
        }

        //проверка, что в таблице нет пустых ячеек
        private bool CellsNotIsEmpty()
        {
            for (int j = 0; j < dataGridView_Cubes.Rows.Count-1; j++)
            {
                for (int i = 0; i < dataGridView_Cubes.Rows[j].Cells.Count; i++)
                {
                    if (dataGridView_Cubes.Rows[j].Cells[i].Value == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //запуск
        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (CellsNotIsEmpty())
            { 
                if (listBox_dictionary.Items.Count != 0)
                {
                    for (int i = 0; i < listBox_dictionary.Items.Count; i++)
                    {
                        words.Add(listBox_dictionary.Items[i].ToString());
                    }
                    cubes = new string[dataGridView_Cubes.RowCount, 6];
                    for (int i = 0; i < dataGridView_Cubes.RowCount-1; i++)
                    {
                        for (int j = 0; j < dataGridView_Cubes.ColumnCount; j++)
                        {
                            cubes[i, j] = dataGridView_Cubes.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    listBox_Result.Items.Clear();
                    result_words.Clear();
                    Handler = new CubesHandler(words, cubes, cubes_amount);
                    lbl_count_words.Text = "Результат: " + Handler.Run(ref result_words).ToString();
                    if (result_words.Count > 0)
                    {
                        foreach (string wrd in result_words)
                            listBox_Result.Items.Add(wrd);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Словарь не может быть пустым!", "Некорректные данные!");
                }
            }
            else
            {
                MessageBox.Show(this,"Ячейки таблицы не могут быть пустыми!", "Некорректные данные!");
            }
        }

        private void textBox_Word_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = this.btn_Add;
        }

        private void numUpDown_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = this.btn_Generate;
        }

        //удалить выделенное слово из словаря
        private void btn_DeleteWord_Click(object sender, EventArgs e)
        {
            var selWord = listBox_dictionary.SelectedIndex;
            if (selWord!=-1)
                listBox_dictionary.Items.RemoveAt(selWord);
            btn_DeleteWord.Enabled = false;
        }

        //удалить выделенную строку таблицы
        private void btn_DeleteRow_Click(object sender, EventArgs e)
        {
            var selRow = dataGridView_Cubes.SelectedCells[0].RowIndex;
            if (dataGridView_Cubes.Rows.Count-1 != selRow )
                dataGridView_Cubes.Rows.RemoveAt(selRow);
            btn_DeleteRow.Enabled = false;
        }

        //ограничение на ввод строки большей одного символа
        private void dataGridView_Cubes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell Cell = (DataGridViewTextBoxCell)dataGridView_Cubes.CurrentCell;
            Cell.MaxInputLength = 1;
            btn_DeleteRow.Enabled = true;

        }

        //ограничение на ввод некорректных для задачи символов
        private void dataGridView_Cubes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Cell_KeyPress);
        }

        private void Cell_KeyPress(object Sender, KeyPressEventArgs pressE)
        {
            if (!chars.Contains(pressE.KeyChar) && pressE.KeyChar != 8)
            {
                pressE.KeyChar = Convert.ToChar("\0");
                MessageBox.Show("Ячейки таблицы не должны содержать никаких символов, кроме латиницы!");
            }
        }

        private void listBox_dictionary_Enter(object sender, EventArgs e)
        {
            btn_DeleteWord.Enabled = true;
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _3._3b.GeneticAlg
{
    public partial class FormFiles : Form
    {
        int[] items;
        public FormFiles()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Add(nudElem.Value);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Remove(lbFiles.SelectedItem);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            tbExact.Clear();
            tbTimeEx.Clear();
            PrepareItems();
            int capacity = (int)CapacityBox.Value;
            long WorkTime = 0;
            if (items.Any(x => x > capacity))
            {
                Output(tbExact, tbTimeEx, null, WorkTime, capacity);
            }
            else if (UseBackTrac.Checked)
            {
                int[] resEx = BackTrackAlgorithm.FindRes(items, capacity, out WorkTime);
                Output(tbExact, tbTimeEx, resEx, WorkTime, capacity);
            }
            else
            {
                int[] resEx = CorrectAlgorithm.Run(items, capacity, out WorkTime);
                Output(tbExact, tbTimeEx, resEx, WorkTime, capacity);
            }
        }

        private void PrepareItems()
        {
            int cnt = lbFiles.Items.Count;
            items = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                items[i] = Convert.ToInt32(lbFiles.Items[i]);
            }
        }

        private void btnGenSolve_Click(object sender, EventArgs e)
        {
            PrepareItems();
            tbTimeGen.Clear();
            tbGen.Clear();
            int munCnt = (int)nudMutCnt.Value;
            if (munCnt > items.Length - 1) munCnt = 1;
            int cntParChoms = (int)nudParentChrom.Value;
            int cntChoms = (int)nudChrom.Value;
            int capacity = (int)CapacityBox.Value;
            if (cntParChoms >= cntChoms) cntParChoms = cntChoms / 2;
            if (items.Any(x => x > capacity))
            {
                Output(tbGen, tbTimeGen, null, 0, capacity);
            }
            else
            {
                GeneticAlgorithm geneticAlg = new GeneticAlgorithm(cntChoms, items, capacity, (int)nudMutation.Value, munCnt, cntParChoms);
                int[] resGen = geneticAlg.Run((int)nudSteps.Value);
                Output(tbGen, tbTimeGen, resGen, geneticAlg.CurTimeGen, capacity);
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            lbFiles.Items.Clear();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            lbFiles.Items.Clear();
            int capacity = (int)CapacityBox.Value;
            for (int i = 0; i < nudItems.Value; i++)
            {
                lbFiles.Items.Add(r.Next(1, capacity));
            }
        }

        private void ClearAll()
        {
            tbExact.Clear();
            tbTimeEx.Clear();
            tbTimeGen.Clear();
            tbGen.Clear();
        }

        private void Output(TextBox tb, TextBox tbTime, int[] res, long time, int Capacity)
        {
            if (res != null)
            {
                int NumDisk = 1;
                int CurrentCapacity = Capacity;
                tb.AppendText("Носитель " + NumDisk + ": ");
                for (int i = 0; i < res.Length; i++)
                {
                    if (CurrentCapacity >= res[i])
                    {
                        tb.AppendText(res[i] + " ");
                        CurrentCapacity -= res[i];
                    }
                    else
                    {
                        tb.AppendText(Environment.NewLine);
                        NumDisk++;
                        CurrentCapacity = Capacity;
                        tb.AppendText("Носитель " + NumDisk + ": ");
                        tb.AppendText(res[i] + " ");
                        CurrentCapacity -= res[i];
                    }

                }
                tbTime.Text = String.Format("{0,12:F6}", ((double)time / Stopwatch.Frequency));
            }
            else
            {
                tb.AppendText("Решения не существует! Размер какого-либо файла(ов) превышает размер носителя.");
            }
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задача укладки по дискетам (ящикам): Генетический алгоритм.", "Условие задания");
        }
    }
}

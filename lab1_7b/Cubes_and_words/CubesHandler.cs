using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubes_and_words
{
    class CubesHandler
    {
        //количество граней на кубике
        const int size = 6;
        //Список слов в словаре
        List<string> words = new List<string>();
        //матрица для кубиков
        string[,] cubes;
        //Количество кубиков
        int count_cubes;
        //количество перестановок с повторениями из size по nCub
        int countCubPerm;
        //хранилище перестановок с повторениями из size по nCub 
        int[,] rep;

        
        public CubesHandler(List<string> _words, string[,] _cubes, int _cubes_amount)
        {
            words = _words;
            cubes = _cubes;
            count_cubes = _cubes_amount;
        }


        //Поскольку нам подойдут только N-буквенные слова, где N - число кубков, то можем удалить (N+M)-буквенные слова (M != 0) 
        private List<string> Delete_words(List<string> list)
        {
            List<string> new_list = new List<string>();
            foreach (string word in list)
            {
                if (word.Length == count_cubes)
                {
                    new_list.Add(word);
                }
            }
            return new_list;
        }

        //получаем слово с перестановки кубиков из массива А, а из 
        //rep берем с повторениями под номером line
        private string GetWord(int[] a, int line)
        {
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < count_cubes; j++)
            {
                sb.Append(cubes[a[j] - 1, rep[line, j]]);
            }
            return sb.ToString();
        }

        //запустить программу
        public int Run(ref List<string> res)
        {
            int result = 0;//количество слов, которые можно составить из кубиков
            words = Delete_words(words);//удаляем слова, которые точно не сможем составить
            GetRepeated();// записываем в матрицу размещения с повторениями
            int[] a = new int[count_cubes];
            for (int i = 0; i < count_cubes; i++)
            {
                a[i] = i + 1;
            }
            //идем и генерируем размещения кубиков в массив а
            //по размещениям набираем все взможные буквы
            do
            {
                for (int i = 0; i < countCubPerm; i++)
                {
                    string word = GetWord(a, i);
                    if (words.Contains(word) && !res.Contains(word))
                    {
                        res.Add(word);
                        ++result;
                    }
                }

            }
            while (GetNextPerm(ref a, count_cubes, count_cubes));
            return result;
        }

        //количество размещений с повторениями
        private int CountRep(int n)//size в n степени
        {
            int res = 1;
            for (int i = 0; i < n; i++)
            {
                res *= size;
            }
            return res;
        }

        //генерация размещений с повторениями,
        private static bool Next(ref int[,] a, int line, int m, int n)
        {
            int i = n - 1;
            //убираем 5ки с концов
            while ((i >= 0) && (a[line - 1, i] == m - 1))
            {
                a[line, i] = 0;
                i--;
            }

            if (i >= 0)
            {
                a[line, i] = a[line - 1, i] + 1;
                i--;
                //дописываем в новую строку оставшиеся элементы из предыдущей строки
                while (i >= 0)
                {
                    a[line, i] = a[line - 1, i];
                    i--;
                }
                return true;
            }
            return false;
        }

        //в массив rep заранее считаем все размещения с повторениями, который часто будем использовать
        private void GetRepeated()
        {
            countCubPerm = CountRep(count_cubes);//количество размещений с повторениями
            rep = new int[countCubPerm, count_cubes];
            int line = 1;
            while (line < countCubPerm)
            {
                Next(ref rep, line, size, count_cubes);
                line++;
            }

        }

        //генерация размещений
        private static int GetFirstFree(ref bool[] free, int t)  
        {
            while (t < free.Length && !free[t])
            {
                t++;
            }
            if (t == free.Length)
                return 0;
            return t;
        }

        //генерация следующей перестановки кубиков
        private static bool GetNextPerm(ref int[] a, int n, int m)
        {
            bool[] free = new bool[n];
            int i = 0;
            for (i = 0; i < n; i++)
            {
                free[i] = true;
            }
            for (i = 0; i < m; i++)
            {   
                free[a[i] - 1] = false;
            }
            i = m;
            while (i > 0 && (GetFirstFree(ref free, a[i - 1] - 1) == 0))
            {
                free[a[i - 1] - 1] = true;
                i--;
            }
            if (i == 0) return false;
            free[a[i - 1] - 1] = true;

            int q = GetFirstFree(ref free, a[i - 1]);
            free[q] = false;
            a[i - 1] = q + 1;
            int k = 1;
            for (int j = i + 1; j <= m; j++)
            {

                while (k <= n && !free[k - 1])
                {
                    k++;
                }
                a[j - 1] = k;
                free[k - 1] = false;
            }
            return true;
        }
    }
}

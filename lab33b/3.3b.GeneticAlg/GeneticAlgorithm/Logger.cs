using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3b.GeneticAlg
{
    class Logger
    {
        FileInfo fileInf;
        StreamWriter sr;
        public Logger(string _path)
        {
            fileInf = new FileInfo(_path);
            sr = new StreamWriter(_path);
        }
        public void Log(string message)
        {
            sr.Write ( message);
            sr.WriteLine();
        }

        public void Close()
        {
            sr.Close();
        }
    }
}

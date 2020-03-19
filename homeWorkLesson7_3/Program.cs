using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = FileSearcher.FindFile(@"C:\Test", "test.txt");
            FileSearcher.ShowFileInConsole(fileName);
            FileSearcher.ShowFileInNotepad(fileName);
            FileSearcher.CompressFile(fileName, @"C:\testArchive.zip");
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 50; i++)
            {
                Directory.CreateDirectory($@"C:\Test\Folder_{i}");
            }

            DirectoryInfo directory = new DirectoryInfo($@"C:\Test");

            var directoriesInfo = directory.GetDirectories();                              

            foreach (var directorie in directoriesInfo)
            {
                Console.WriteLine(directorie.Name);
            }

            Console.WriteLine("Нажмите на любую клавишу что б удалить все дериктории:");

            Console.ReadKey();

            for (int i = 0; i <= 50; i++)
            {
                Directory.Delete($@"C:\Test\Folder_{i}");
            }

            Console.WriteLine("Дериктории удалены");

            Console.ReadKey();
        }
    }
}

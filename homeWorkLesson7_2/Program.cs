using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            FileStream fileStream = new FileStream("Text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
            {
                writer.WriteLine("Какой-то текст1!");
                writer.WriteLine(13251);
                writer.WriteLine("Какой-то текст2!");
            }

            Console.WriteLine("Файл Text.txt создан и в него записан текст!");

            Console.ReadKey();

            using (var reader = File.OpenText("Text.txt"))
            {
                string value;

                while ((value = reader.ReadLine()) != null)
                {
                    Console.WriteLine(value);
                }
            }

            Console.ReadKey();
        }
    }
}

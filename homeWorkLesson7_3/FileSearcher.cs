using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace homeWorkLesson7_3
{
    class FileSearcher
    {
        public static string[] FindFiles(string startDirectory, string pattern)
        {
            return Directory.GetFiles(startDirectory, pattern, SearchOption.AllDirectories);
        }

        public static string FindFile(string startDirectory, string pattern) => FindFiles( startDirectory, pattern).FirstOrDefault();

        public static void ShowFileInConsole(string path)
        {
            using (var streamReader = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }
        }

        public static void ShowFileInNotepad(string path)
        {
            System.Diagnostics.Process.Start(path);
        }

        public static void CompressFile(string path, string compressZipArchive)
        {
            using (var fileStream = new FileStream(compressZipArchive, FileMode.Create))
            {
                using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(path, Path.GetFileName(path));
                }
            }
        }

    }
}

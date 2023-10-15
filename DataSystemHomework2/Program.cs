using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSystemHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FolderSize(new DirectoryInfo("C:\\Users\\Stanislav\\Desktop\\Size")));
            Console.ReadKey();
        }

        static long FolderSize(DirectoryInfo Path)
        {
            try
            {
                long size = 0;
                DirectoryInfo[] directoryInfo = Path.GetDirectories();
                FileInfo[] fileInfo = Path.GetFiles();
                foreach (FileInfo file in fileInfo)
                {
                    size += file.Length;
                }
                foreach (DirectoryInfo directoryInfo1 in directoryInfo)
                {
                    size += FolderSize(directoryInfo1);
                }
                return size;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return 0;
            }
        }
    }
}

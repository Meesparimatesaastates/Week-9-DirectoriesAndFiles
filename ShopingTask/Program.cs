using System;
using System.IO;

namespace ShopingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\source\repos\Week 9";
            Console.WriteLine("Enter directory name");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();




            if (Directory.Exists($"{ rootDirectory}\\{ newDirectory}") && File.Exists($"{ rootDirectory}\\{ newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"directory and file exist");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{ newDirectory}");
                File.Create($"{ rootDirectory}\\{ newDirectory}\\{fileName}");
            }
        }
       
    }
}

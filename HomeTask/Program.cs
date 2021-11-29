using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\User\source\repos\Week 8\Samples";
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

            string fileLocation = @"C:\Users\User\source\repos\Week 8\Samples\";
           
            string[] arrayFromFile = File.ReadAllLines($"{ rootDirectory}\\{ newDirectory}\\{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to att a wish Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string wish in myWishList)
            {
                Console.WriteLine($"Your wish: {wish}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
            //{ Console.WriteLine(wish); }

        }
    }
}

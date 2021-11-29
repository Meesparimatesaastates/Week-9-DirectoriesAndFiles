using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShopingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\source\repos\Week 9\ShopingTask";
            string fileName = @"\\myShopingList.txt";
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myItemList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to att a item to the shoping list Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item");
                    string userItem = Console.ReadLine();
                    myItemList.Add(userItem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string item in myItemList)
            {
                Console.WriteLine($"Yours items: {item}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myItemList);
            }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishListFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\source\repos\Week 8\Samples\ShopingWish";
            string fileName = @"\\myShopingList.txt";
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
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
                {loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();    
            
            foreach(string wish in myWishList)
            {
                Console.WriteLine($"Your wish: {wish}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
            //{ Console.WriteLine(wish); }
            

        }
    }
}

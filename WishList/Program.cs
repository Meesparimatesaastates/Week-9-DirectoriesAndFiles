using System;
using System.Collections.Generic;

namespace WishList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();
            Console.WriteLine(myWishList.Count);
            myWishList.Add("Coffemachine");
            myWishList.Add("new pair of socks");
            myWishList.Add("new car");

            Console.WriteLine(myWishList.Count);

            foreach(string wish in myWishList)
            {
 Console.WriteLine(wish);
            }        
        }
    }
}

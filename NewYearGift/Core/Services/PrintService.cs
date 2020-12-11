﻿using NewYearGift.App.Models.Sweets;
using NewYearGift.Core.Services.Interfaces;
using NewYearGift.Models.Gifts;
using System;
using System.Collections.Generic;

namespace NewYearGift.Core.Services
{
    public class PrintService : IPrintService
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("\nActions:\n 1. Show current gift \n 2. Make new gift from sweets\n 3. Calculate weight of gift \n 4. Sort sweets in gift by parameter \n 5. Find sweets in gift by parameter \n 0. Close");
            Console.Write("Input: ");
        }

        public void PrintSweetParametersMenu()
        {
            Console.WriteLine("\n\nSweet parameters:\n\n 1. Name \n 2. Weight\n 3. Calorie \n 4. Filling \n 5. Shape\n");
            Console.Write("Input: ");
        }

        public void PrintSweetRangeParametersMenu()
        {
            Console.WriteLine("\n\nSweet parameters:\n\n 1. Weight \n 2. Calorie \n 3. Sugar weight \n 4. Alcohol degree\n");
            Console.Write("Input: ");
        }

        public void PrintStartRangeText()
        {
            Console.Write("\nInput range start value:");
        }

        public void PrintEndRangeText()
        {
            Console.Write("\nInput range end value:");
        }

        public void PrintInputText()
        {
            Console.Write("\nInput numbers separated by a space: ");
        }

        public void PrintChoosePresenteeMenu()
        {
            Console.WriteLine("\nChoose who the gift is for:");
            Console.WriteLine("\n\nPresentee:\n\n 1. Children \n 2. Adult\n");
            Console.Write("Input: ");
        }

        public void PrintSortingMenu()
        {
            Console.WriteLine("\nChoose sorting order:");
            Console.WriteLine("\n\n 1. Ascending \n 2. Descending\n");
            Console.Write("Input: ");
        }

        public void PrintSweetsMenu()
        {
            Console.WriteLine("\nChoose sweets for gift:\n");
        }
        public void PrintGiftWeight(int weight)
        {
            Console.WriteLine("\n\nGift weight: {0} gramms", weight);
        }

        public void PrintGift(Gift gift)
        {
            gift.PrintData();

            foreach (Sweet sweet in gift.Sweets)
            {
                sweet.PrintData();
                Console.WriteLine("\n");
            }
        }

        public void PrintSweets(ICollection<Sweet> sweets)
        {
            Console.WriteLine("\n");

            foreach(Sweet sweet in sweets)
            {
                sweet.PrintData();

                Console.WriteLine("\n");
            }

            if (sweets.Count == 0)
            {
                Console.WriteLine("Nothing to print");
            }
        }
    }
}

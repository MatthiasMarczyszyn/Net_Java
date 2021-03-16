using System;
using System.Collections.Generic;
using GeneratorCS;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = 0;
            var ammount = 0;
            Console.WriteLine("Add ammount of items:");
            ammount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add capacity of backpack:");
            capacity = Int32.Parse(Console.ReadLine());
            RandomNumberGenerator rng = new RandomNumberGenerator(19);
            List<int> itemList = new List<int>();
            List<int> valueList = new List<int>();
            List<int> weightList = new List<int>();
            for (var i = 0; i < ammount; i++) itemList.Add(i);
            foreach (var item in itemList)
            {
                valueList.Add(rng.nextInt(1, 29));
                weightList.Add(rng.nextInt(1, 29));
            }

            Console.WriteLine(KnapsackProblemNaive(capacity, itemList, valueList, weightList));
        }

        public static int KnapsackProblemNaive(int capacity, List<int> itemList, List<int> valueList, List<int> weightList)
        {
            var backpackWeight = 0;
            var backpackValue = 0;
            foreach (var item in itemList)
            {
                if (backpackWeight + weightList[item] <= capacity)
                {
                    backpackWeight += weightList[item];
                    backpackValue += valueList[item];
                }
                if (backpackWeight == capacity) break;
            }

            return backpackValue;
        }
    }
}

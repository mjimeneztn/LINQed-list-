﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linqLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            List<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L")).ToList();



            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> fourSixMultiples = numbers.Where(number => number % 6 == 0 && number % 4 == 0).ToList();

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> orderedNamess = names.OrderByDescending(names => names).ToList();

            // // Build a collection of these numbers sorted in ascending order
            List<int> numberss = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> orderedNumbers = numberss.OrderBy(n => n).ToList();

            // Output how many numbers are in this list
            Console.WriteLine(numberss.Count);

            // // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            Console.WriteLine(purchases.Sum());


            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                };
            Console.WriteLine(prices.Max());

            //     Store each number in the following List until a perfect square is detected.
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            List<int> untilPerfectSquare = wheresSquaredo.TakeWhile(n => Convert.ToInt32(Math.Sqrt(n)) % 1 == 0).ToList();;

            // // Build a collection of customers who are millionaires
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            List<Bank> banks = new List<Bank>() {
                new Bank(){ Symbol="FTB", Name = "First Tennessee Bank"},
                new Bank(){ Symbol="WF", Name="Wells Fargo"},
                new Bank(){ Symbol="BOA", Name="Bank of America"},
                new Bank(){ Symbol="CITI", Name="Citibank"}
            };


            //     Given the same customer set, display how many millionaires per bank.
            List<Customer> millionaires = customers.Where(c => c.Balance > 1000000).ToList();


            var bigmoney = millionaires.GroupBy(millionaires => millionaires.Bank);

            foreach (var m in bigmoney)
            {
                var numOfMillionare = new List<string>();
                foreach (var customer in m)
                {
                    numOfMillionare.Add(customer.Name);
                }

                Console.WriteLine($"{m.Key} {numOfMillionare.Count}");
            }
        }
    }
}

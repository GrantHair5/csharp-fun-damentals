using System;
using FizzBuzzGame;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz");


            var game = new TheGame(); 
            game.PrintNumbers(100); 
        }
    }
}

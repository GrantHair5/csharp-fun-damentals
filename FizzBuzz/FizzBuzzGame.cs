using System;

namespace FizzBuzzGame
{
    public class TheGame
    {
        private int Fizz = 3; 
        private int Buzz = 5;
        private int FizzBuzz;

        public TheGame()
        {
            FizzBuzz = Fizz * Buzz;
        }

        public void PrintNumbers(int maxNumber)
        {
            for(int i = 1; i <= maxNumber; i++ )
            {
                Console.WriteLine(i);
            } 
        } 
    }
}
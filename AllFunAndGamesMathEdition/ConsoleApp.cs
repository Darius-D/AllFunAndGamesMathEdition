using System;
using System.Runtime.InteropServices;

namespace AllFunAndGamesMathEdition
{
    public static class ConsoleApp
    {
        public static void StartUp()
        {
            MainScreen();
        }
        private static void MainScreen()
        {
            Console.WriteLine("\nWelcome to All Fun and Games: Math Edition!\n");
            Console.WriteLine("Please choose one of the selections below.\n");
            Console.WriteLine("1. Play with Addition");
            Console.WriteLine("2. Play with Subtraction");
            Console.WriteLine("3. Play with Multiplication");
            Console.WriteLine("4. Play with Division");
            Console.WriteLine("5. Exit the Game.");
            Console.WriteLine("------------------------------------------------------ ");
            Console.Write("What game would you like to play?: ");
            try
            {
                var selection = int.Parse(Console.ReadLine() ?? "0");

                switch (selection)
                {
                    case 1:
                        AdditionGame();
                        break;
                    case 2:
                        SubtractionGame();
                        break;
                    case 3:
                        MultiplicationGame();
                        break;
                    case 4:
                        DivisionGame();
                        break;
                    case 5:
                        Console.WriteLine("This game was created by Darius Dubose, I hope you enjoyed playing. See you next time!");
                        Environment.Exit(0);
                        break;
                }

                MainScreen();
            }
            catch (Exception)
            {
                Console.WriteLine("\nBe sure to use the menu numbers to make a selection.\n");

                MainScreen();
            }
        }

        private static void AdditionGame()
        {
            Console.WriteLine("You have selected to Play with Addition!");
            Console.Write("Please choose the number of questions you would like to do: ");
            var questionCount =  int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Great, {questionCount} questions! Let the games begin!\n");
            var rdm = new Random();
            var count = 1;
            while (questionCount > 0)
            {
                var valueOne = rdm.Next(0, 101);
                var valueTwo = rdm.Next(0, 101);
                int userAnswer;
                Console.Write($"\nQuestion {count}! If you had {valueOne} baby yoda dolls, but you won {valueTwo} more. \nHow many baby Yoda dolls do you now have? ");
                try
                {
                     userAnswer = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nplease enter a valid Integer value: \n");
                    userAnswer = int.Parse(Console.ReadLine());
                }
                
                var correctAnswer = valueOne + valueTwo;

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine($"\nCorrect, the answer was {correctAnswer}! Way to Go!");
                }
                else
                {
                    Console.WriteLine($"\nSorry, the correct answer was {correctAnswer}. You've got this!");
                }

                questionCount--;
                count++;

            }
        }
        private static void SubtractionGame()
        {
            Console.WriteLine("You have selected to Play with Addition!");
            Console.Write("Please choose the number of questions you would like to do: ");
            var questionCount = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Great, {questionCount} questions! Let the games begin!\n");
            var rdm = new Random();
            var count = 1;
            while (questionCount > 0)
            {
                var valueOne = rdm.Next(0, 101);
                var valueTwo = rdm.Next(0, 101);
                int userAnswer;

                if (valueOne < valueTwo)
                {
                    var temp = valueOne;
                    valueOne = valueTwo;
                    valueTwo = temp;
                }

                Console.Write($"\nQuestion {count}! If you had {valueOne} baby Obi Wan Kenobi dolls, but you gave away {valueTwo} to friends and family. \nHow many baby Obi Wan Kenobi dolls do you have left? ");
                try
                {
                    userAnswer = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nplease enter a valid Integer value: \n");
                    userAnswer = int.Parse(Console.ReadLine() ?? "0");
                }

                var correctAnswer = valueOne - valueTwo;

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine($"\nCorrect, the answer was {correctAnswer}! Way to Go!");
                }
                else
                {
                    Console.WriteLine($"\nSorry, the correct answer was {correctAnswer}. You've got this!");
                }

                questionCount--;
                count++;

            }
        }
        private static void DivisionGame()
        {
            Console.WriteLine("You have selected to Play with Division, This will be fun!");
            Console.Write("Please choose the number of questions you would like to do: ");
            var questionCount = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Great, {questionCount} questions! Let the games begin!\n");
            var rdm = new Random();
            var count = 1;
            while (questionCount > 0)
            {
                var valueOne = rdm.Next(0, 101);
                var valueTwo = rdm.Next(0, 101);
                double userAnswer;

                if (valueOne < valueTwo)
                {
                    var temp = valueOne;
                    valueOne = valueTwo;
                    valueTwo = temp;
                }

                Console.Write($"\nQuestion {count}! If you had {valueOne} bags of skittles, but you have {valueTwo} friends to share with. \nHow many bags of skittles can each friend have rounded to the nearest hundredth? ");
                try
                {
                    userAnswer = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nplease enter a valid Integer value: \n");
                    userAnswer = double.Parse(Console.ReadLine() ?? "0");
                }

                var correctAnswer = Math.Round((double)valueOne / valueTwo, 2);

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine($"\nCorrect, the answer was {correctAnswer}! Way to Go!");
                }
                else
                {
                    Console.WriteLine($"\nSorry, the correct answer was {correctAnswer}. You've will get the next!");
                }

                questionCount--;
                count++;

            }
        }
        private static void MultiplicationGame()
        {
            Console.WriteLine("You have selected to Play with Multiplication!");
            Console.Write("Please choose the number of questions you would like to do: ");
            var questionCount = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Great, {questionCount} questions! Let the games begin!\n");
            var rdm = new Random();
            var count = 1;
            while (questionCount > 0)
            {
                var valueOne = rdm.Next(0, 101);
                var valueTwo = rdm.Next(0, 101);
                int userAnswer;
                Console.Write($"\nQuestion {count}! If you had {valueOne} bags of silver and gold, but you a genie gave you {valueTwo} times more! \nHow many bags do you now have? ");
                try
                {
                    userAnswer = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nplease enter a valid Integer value: \n");
                    userAnswer = int.Parse(Console.ReadLine() ?? "0");
                }

                var correctAnswer = valueOne * valueTwo;

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine($"\nCorrect, the answer was {correctAnswer}! Way to Go!");
                }
                else
                {
                    Console.WriteLine($"\nSorry, the correct answer was {correctAnswer}. You've got this!");
                }

                questionCount--;
                count++;

            }
        }
    }
}
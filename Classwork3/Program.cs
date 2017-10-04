using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classworks
{
    class Program
    {
        static void Main(string[] args)
        {
            //NoRemainderNumbers();

            //PrintEachSecondSymbol();

            //NamePriceOfBeverage();

            //AverageOfPositiveNumbers();

            //AverageOfPositiveNumbersShortV();

            //IsLeapYear();

            //SumOfIntegerDigits();

            OnlyOddNumbers();

        }
        ///summary
        ///1. Ввести a  та b – два цілих числа. Порахувати скільки цілих чисел з діапазону[a..b]
        ///діляться на 3 без остачі.
        ///summary
        public static void NoRemainderNumbers()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = a; i < b; i++)
            {
                if (i % 3 == 0)
                {
                    num += 1;
                }
            }
            Console.WriteLine($"{num} numbers from range [a...b] are divided by 3 without remainder ");
        }


        ///summary
        ///2. Ввести рядок символів. Видрукувати кожен другий символ.
        ///summary
        public static void PrintEachSecondSymbol()
        {
            Console.WriteLine("Enter list of characters");
            string str = Console.ReadLine();
            char[] list = str.ToCharArray();
            for (int i = 1; i < list.Length; i += 2)
            {

                Console.WriteLine(list[i]);
            }
        }


        ///summary
        ///3. Ввести назву напою (кава, чай, сік, вода). Вивести назву напитку і його ціну.
        ///summary
        public static void NamePriceOfBeverage()
        {
            Console.WriteLine("Enter name of the beverage: 1) Coffee; 2) Tea; 3) Juice; 4) Water; 5) 0 - exit");

            switch (Console.ReadLine().ToLower())
            {
                case "coffee":
                    Console.WriteLine("Coffee - 3$");
                    break;
                case "tea":
                    Console.WriteLine("Tea - 2$");
                    break;
                case "juice":
                    Console.WriteLine("Juice - 3$");
                    break;
                case "water":
                    Console.WriteLine("Juice - 1$");
                    break;
                case "0":
                    Environment.Exit(exitCode: 0);
                    break;
                default:
                    // Main();
                    Console.WriteLine("Your choice is wrong");
                    break;
            }
            Console.ReadKey();
        }

        ///summary
        ///4. Введіть послідовність додатніх цілих чисел (до першого від’ємного). 
        ///Обчисліть середнє арифметичне значення введених чисел.
        ///summary
        public static void AverageOfPositiveNumbers()
        {
            Console.WriteLine("Enter list of numbers");
            string str = Console.ReadLine();
            string[] mas = str.Split(' ');
            int[] numbersArrary = Array.ConvertAll(mas, int.Parse);

            int sum = 0;
            int numQuantity = 0;

            for (int i = 0; i < numbersArrary.Length; i++)
            {
                if (numbersArrary[i] > 0)
                {
                    sum += numbersArrary[i];
                    numQuantity += 1;
                    Console.WriteLine(numbersArrary[i]);
                }
                else break;
            }
            int average = sum / numQuantity;
            Console.WriteLine($"Average is {average}");
        }

        /// <summary>
        /// 2nd variant of 4
        /// </summary>
        public static void AverageOfPositiveNumbersShortV()
        {
            Console.WriteLine("Enter list of numbers");
            string str = Console.ReadLine();
            string[] mas = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            int numQuantity = 0;
            foreach (string m in mas)
            {
                if (int.Parse(m) > 0)
                {
                    sum += int.Parse(m);
                    numQuantity += 1;
                }
                else break;
            }
            int average = sum / numQuantity;
            Console.WriteLine(average);
        }


        /// <summary>
        /// 5) Перевірити чи введений рік є високосним.
        /// </summary>
        public static void IsLeapYear()
        {
            Console.WriteLine("Enter a year");
            int.TryParse(Console.ReadLine(), out int year);

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Entered year is a Leap year");
            }
            else
            {
                Console.WriteLine("Entered year is not a Leap Year");
            }
        }

        /// <summary>
        /// 6) Знайти суму цифр введеного цілого числа
        /// </summary>
        public static void SumOfIntegerDigits()
        {
            Console.WriteLine("Enter a number");
            int sum = 0;
            char[] a = Console.ReadLine().ToCharArray();

            foreach (char ch in a)
            {
                sum += Convert.ToInt32(ch.ToString());

            }
            Console.WriteLine($"Sum of digits of entered number is {sum}");
        }

        /// <summary>
        /// Перевірити чи введене натуральне число містить лише непарні цифри
        /// </summary>
        public static void OnlyOddNumbers()
        {
            Console.WriteLine("Enter a number");
            char[] numbers = Console.ReadLine().ToCharArray();

            bool areAllOdd = true;
            foreach (char ch in numbers)
            {
                if (int.Parse(ch.ToString()) % 2 == 0)
                {
                    areAllOdd = false;
                    
                    break;
                }
                
            }

            string not = "not";

            Console.WriteLine($"All digits of entered number are {(areAllOdd ? string.Empty : not) } odd ");
        }
    }


    }



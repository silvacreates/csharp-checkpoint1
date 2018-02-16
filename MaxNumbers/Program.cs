using System;
using System.Linq;
using System.Text;


namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";


            Console.WriteLine("Enter a series of numbers separated by comma");
            input = Console.ReadLine();

            char delimiter = ',';
            string[] array = input.Split(delimiter);
            //int[] numbersArray = Array.ConvertAll(array, int.Parse);

            //Below is another solution without using the array

            int number = 0;
            int maxNumber = 0;

            foreach (string item in array)
            {
                //Console.WriteLine(item);

                int.TryParse(item, out number); // will store value in `number` variable if it can

                // 2, 5, apple, 6

				//Console.WriteLine(number);

                if (number != 0)
                {
                    if (maxNumber == 0)
                    {
                        maxNumber = number;
                    }
                    else
                    {
                        maxNumber = (number > maxNumber) ? number : maxNumber;
                    }
                }
            }


            //Console.WriteLine("The highest number you enter is: " + numbersArray.Max());
			Console.WriteLine("The highest number you enter is: " + maxNumber);


            Console.ReadLine();
        }
    }
}

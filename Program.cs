using System;

namespace Exercise15
{
    class Program
    {
        /*Create a console-based program whose Main() method prompts the user for an integer 
            value and, in turn, passes the value to a method that squares the number and to a method 
            that cubes the number. The Cube() method should call the Square() method. The Main() 
            method displays the results returned from each of the other methods.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Input a integer: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int answer = square(input);
            int answer2 = cube(input);

            Console.WriteLine("Squared is {0}", answer);
            Console.WriteLine("cubed is {0}", answer2);

        }

        public static int square(int input)
        {
            int answer = input * input;
            return answer;
        }

        public static int cube(int input)
        {

            int answer2 = input * input * input;
            return answer2;
        }




    }
}

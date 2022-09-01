using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** Welcome to Lab 2 ***");
        Console.WriteLine();

        Console.WriteLine("===#1 Print the output of adding two numbers from user input. ===");
        Console.WriteLine();

        //Variables
        int num1, num2, sum, num3, max, product;

        Console.WriteLine("Enter the first addend: ");
            num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second addend: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
              
        Console.WriteLine("The sum of the numbers entered is: "+ sum);

        Console.WriteLine();
        Console.WriteLine("*** Hit ENTER to move to next step ***");
 
        Console.ReadKey();

        Console.WriteLine("===#2 Take user’s input number and output its multiplication table. " +
                            "The user can choose how high to multiply by.\r\n ===");
        Console.WriteLine();

        Console.WriteLine("Type a number to output its multiplication table: ");
            num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How High would you like to multiply by?: ");
            max = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nMultiplication Table For {0}: ", num3);
        for (int i = 1; i <= max; i++)
        {
            product = num3 * i;
            Console.WriteLine("{0} x {1} = {2}", num3, i, product);
        }



    }
}
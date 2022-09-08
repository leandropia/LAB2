using System;
using ConsoleTables;
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


        Console.WriteLine();
        Console.WriteLine("*** Hit ENTER to move to next step ***");

        Console.ReadKey();

        Console.WriteLine("===#3 Output the number of bytes in memory that each of the following " +
                         "number types uses and the minimum and maximum values they can have: " +
                         "sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal. ");
        Console.WriteLine();

        ConsoleTable table = new ConsoleTable("Type", "Size", "Min", "Max");
        table.AddRow("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        table.AddRow("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        table.AddRow("short", sizeof(short), short.MinValue, short.MaxValue);
        table.AddRow("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        table.AddRow("int", sizeof(int), int.MinValue, int.MaxValue);
        table.AddRow("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        table.AddRow("long", sizeof(long), long.MinValue, long.MaxValue);
        table.AddRow("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        table.AddRow("float", sizeof(float), float.MinValue, float.MaxValue);
        table.AddRow("double", sizeof(double), double.MinValue, double.MaxValue);
        table.AddRow("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
       

        Console.WriteLine(table);

        Console.WriteLine();
         Console.WriteLine("*** Hit ENTER to move to next step ***");
        
        Console.ReadKey();

        Console.WriteLine("===#4 Create a 5 function (+, -, *, /, and modulus) calculator. This calculator should loop " +
                            "until ‘esc’ is typed. For example, I should be asked for num 1, then some operation (+, -, *, /, and modulus) " +
                            "to another num 2. Provide the results, and then provide a way to esc the program or do " +
                            "another operation (+, -, *, /, and modulus) to the result.\n");

        while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
        { 
            Console.WriteLine("Select one of the 5 functions:");
            Console.WriteLine("Type '1' for Addition");
            Console.WriteLine("Type '2' for Subtraction");
            Console.WriteLine("Type '3' for Multiplication");
            Console.WriteLine("Type '4' for Division");
            Console.WriteLine("Type '5' for Modulus");
            Console.WriteLine();
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st number");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            if (action == 1)
            {
                result = input_1 + input_2;
                Console.WriteLine("The Result is: " + result);
                Console.WriteLine();
            }
            else if (action == 2)
            {
                result = input_1 - input_2;
                Console.WriteLine("The Result is: " + result);
                Console.WriteLine();
            }
            else if (action == 3)
            {
                result = input_1 * input_2;
                Console.WriteLine("The Result is: " + result);
                Console.WriteLine();
            }
            else if (action == 4)
            {
                result = input_1 / input_2;
                Console.WriteLine("The Result is: " + result);
                Console.WriteLine();
            }
            else if (action == 5)
            {
                result = input_1 % input_2;
                Console.WriteLine("The Result is: " + result);
                Console.WriteLine();
            }
        }

    }
}

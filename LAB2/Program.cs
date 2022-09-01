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

        


    }
}
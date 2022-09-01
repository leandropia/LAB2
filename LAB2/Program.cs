internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** Welcome to Lab 2 ***");
        Console.WriteLine();

        int num1, num2;

        Console.WriteLine("Enter the first addend: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second addend: ");
        num2 = Convert.ToInt32(Console.ReadLine());

       int sum = num1 + num2;
              
        Console.WriteLine("The sum of the numbers entered is: "+ sum);

      Console.ReadKey();
    } }
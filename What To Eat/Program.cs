// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        int sodastock = 100;

        int sodarestock = 40;

        int chipstock = 40;

        int chiprestock = 20;

        int candystock = 60;

        int candyrestock = 40;



        Console.WriteLine("How many sodas have been sold today? There are " +sodastock+  " in stock");
        int sold = Convert.ToInt32(Console.ReadLine());


        if (sodastock < sold)
        {

            Console.WriteLine("Too high! Don't adjust the stock.");
        }
            if (sodastock > sold)
            {
                sodastock -= sold;
                Console.WriteLine("There are " + sodastock + "  sodas left.");

            }
        Console.WriteLine("How many chips have been sold today? There are " + chipstock + " in stock.");
         sold = Convert.ToInt32(Console.ReadLine());

            if (chipstock < sold)
            {
            Console.WriteLine("Too high! Don't adjust the stock.");
            }
            if (chipstock > sold)
            {
            chipstock -= sold;
            Console.WriteLine("There are " + chipstock + "  chips left.");
            }

        Console.WriteLine(" How many candies have been sold today? There are " + candystock + " in stock.");
        sold = Convert.ToInt32(Console.ReadLine());

            if(candystock < sold)
            {
            Console.WriteLine("Too high! Don't adjust the stock.");
            }
            if(candystock > sold)
        {
            candystock -= sold;
            Console.WriteLine("There are " + candystock + " canides left.");

        }

        Console.WriteLine("Thank you for filling out the values. Here is what needs to be restocked.");

        if(sodastock <= sodarestock)
        {
            Console.WriteLine("Soda needs to be restocked!");
        }
        if(chipstock <= chiprestock)
        {
            Console.WriteLine("Chips need to be restocked!");
        }
        if(candystock <= candyrestock)
        {
            Console.WriteLine("Candy needs to be restocked!");
        }
        Console.WriteLine("Goodbye");
    }
}
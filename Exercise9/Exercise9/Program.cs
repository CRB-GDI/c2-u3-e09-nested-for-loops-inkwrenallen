namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1 - Printing rows of asterisks that are a user-specified width

            //Prompting for and getting a row width from the user
            Console.Write("please insert row width:");
            int rowWidth = int.Parse(Console.ReadLine());

            //Prompting for and getting a number of rows from the user
            Console.Write("please insert number of rows:");
            int numberRows = int.Parse(Console.ReadLine());

            //Printing the appropriate number of rows of asterisks
            //with each row the user-specified row width
            for (int i = 1; i <= numberRows; i++)
            {
                Console.WriteLine("");
                for (int j = 1; j <=  rowWidth; j++)
                {
                     Console.Write("*");
                }
            }

            //Problem 2 – Printing rows of asterisks up to user-specified max width

            //Prompting for and getting a row width from the user
            Console.WriteLine("");
            Console.WriteLine("please insert row width:");
            int newRowwidth = int.Parse(Console.ReadLine());

            //Printing rows of asterisks
            //adding 1 to the asterisk in each row
            //until you print a row of the user-specified row width
            for (int i = 1; i >= newRowwidth; i++)
            {
                Console.Write("*");
                for (int j = 1; j <= i; j++)
                { 
                    Console.WriteLine("");
                }
            }
        }
    }
}


namespace ConsoleApplication1
{
    class Item_orders
    {
        public static bool AskforShowtime()
        {
            System.Console.Write("True/False.. Are you attending the Matinee?");
            return bool.Parse(System.Console.ReadLine());
        }

        public static int AskForPerson(string person)
        {
            System.Console.Write("How many " + person + " in attendance? ");
            return int.Parse(System.Console.ReadLine());
        }

        public static int AskforInt(string item)
        {
            System.Console.Write("How many " + item + " would you like? ");
            return int.Parse(System.Console.ReadLine());
        }
    }
}

    

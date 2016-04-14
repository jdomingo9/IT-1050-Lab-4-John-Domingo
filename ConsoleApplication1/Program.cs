namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCost = 0;
  
            Tickets c1 = new Tickets();

           
            c1.GetConcessionOrder();

            
            totalCost += c1.calculateConcession();

            
            totalCost -= c1.calculateDiscount();

            
            totalCost += c1.calculateTicket();
            System.Console.WriteLine("Total:" + totalCost);
            System.Console.Write("Complete order, press any key");
            System.Console.ReadKey();
        }
    }
}

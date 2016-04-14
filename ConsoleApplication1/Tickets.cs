

namespace ConsoleApplication1
{
    public class Tickets
    {
        public bool showTime;

        
        public int smallSoda;
        public int largeSoda;
        public int hotDog;
        public int popCorn;
        public int candy;
        public double realTotal;

        
        public int cChild;
        public int cAdult;
        public int cSenior;
        public int totalPeople;

       
        public double ticketCost;
        public double consTotal;
        public double discount;

        public Tickets()
        {
             
            this.showTime = Item_orders.AskforShowtime();

            
            this.cSenior = Item_orders.AskForPerson("seniors");

           
            this.cAdult = Item_orders.AskForPerson("adults");

            
            this.cChild = Item_orders.AskForPerson("children");
            System.Console.WriteLine();

            
            this.totalPeople = this.cSenior + this.cAdult + this.cChild;
        }

        public void GetConcessionOrder()
        {
            System.Console.WriteLine("Place your Orders:");
            this.smallSoda = Item_orders.AskforInt("small soda's");
            this.largeSoda = Item_orders.AskforInt("large soda 's");
            this.hotDog = Item_orders.AskforInt("hot dog's");
            this.popCorn = Item_orders.AskforInt("popcorn");
            this.candy = Item_orders.AskforInt("candy");
        }

        
        public double calculateConcession()
        {
            consTotal = 0;
            consTotal += Item_Prices.costSmallSoda * smallSoda;
            consTotal += Item_Prices.costLargeSoda * largeSoda;
            consTotal += Item_Prices.costHotDog * hotDog;
            consTotal += Item_Prices.costPopCorn * popCorn;
            consTotal += Item_Prices.costCandy * candy;
            System.Console.WriteLine();
            System.Console.WriteLine("Concession Total:" + realTotal);
            return consTotal;
        }

      
        public double calculateDiscount()
        {
            discount = 0;
            if (this.totalPeople > 0)
            {
                if (this.popCorn > 0 && this.largeSoda > 0)
                {
                    if (this.popCorn >= this.largeSoda && this.largeSoda <= this.totalPeople)
                    {
                        discount += 2 * largeSoda;
                    }
                    else if (this.popCorn >= this.largeSoda && this.largeSoda >= this.totalPeople)
                    {
                        discount += 2 * this.totalPeople;
                    }
                    else if (this.popCorn < this.largeSoda && this.popCorn <= this.totalPeople)
                    {
                        discount += 2 * popCorn;
                    }
                    else if (this.popCorn < this.largeSoda && this.popCorn >= this.totalPeople)
                    {
                        discount += 2 * this.totalPeople;
                    }
                }
            }

            if (this.showTime == true && this.totalPeople > 3)
            {
                System.Console.WriteLine("1 Bag of Free popcorn unlocked!");
            }

            if (candy > 3)
            {
                int x = candy / 3;
                System.Console.WriteLine("You have unlocked:" + x + " free candy!");
            }
            System.Console.WriteLine("Ticket Price Discount $" + discount);
            return discount;
        }

       
        public double calculateTicket()
        {
            if (this.showTime == true)
            {
                ticketCost = 0;
                ticketCost += this.cSenior * Item_Prices.aSenior;
                ticketCost += this.cAdult * Item_Prices.aAdult;
                ticketCost += this.cChild * Item_Prices.aChild;
                System.Console.WriteLine("Ticket Costs:" + ticketCost);
                System.Console.WriteLine();
                return ticketCost;
            }
            else
            {
                ticketCost = 0;
                ticketCost += cSenior * Item_Prices.bSenior;
                ticketCost += cAdult * Item_Prices.bAdult;
                ticketCost += cChild * Item_Prices.bChild;
                System.Console.WriteLine("Ticket Costs:" + ticketCost);
                System.Console.WriteLine();

                return ticketCost;
            }
        }
    }
}



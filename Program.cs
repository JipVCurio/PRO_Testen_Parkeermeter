using System;

class Program
{
    public static void Main(string[] args)
    {

        ParkingMeter meter = new ParkingMeter();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Maximale parkeertijd: " + meter.getMaxTime() + "mins");
            Console.WriteLine("Prijs per minuut: €" + meter.getPricePerMinute());
            Console.WriteLine();
            Console.WriteLine("Bedrag toegevoegd: €" + meter.getMoney());
            Console.WriteLine("Gekochte parkeertijd: " + meter.getTime() + "mins");
            Console.WriteLine();
            Console.WriteLine("Geld toevoegen, of typ 'koop':");
            string input = Console.ReadLine();
            if (input == "koop")
            {
                decimal moneyLeft = meter.buySlip();
                Console.Clear();
                Console.WriteLine("Ticket gekocht voor " + meter.getTime() + " minuten");
                Console.WriteLine("Geld retour: " + moneyLeft);
                break;
            }

            int money = Convert.ToInt32(input);
            meter.addMoney(money);
        }
    }
}
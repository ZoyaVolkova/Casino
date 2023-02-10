
using Casino;

static void Main()
{
    Random random = new Random();
    double odds = 0.75;
    Player player = new Player { Name = "The player", Cash = 100 };
    Console.WriteLine("Hello! The odds are " + odds );
    while (player.Cash > 0)
    {
        Console.WriteLine("The player have " + player.Cash);
        Console.Write("Enter your bet: ");
        string howMuch = Console.ReadLine(); 
        if (int.TryParse(howMuch, out int amount))
        {
            int pot = amount;
            pot *= 2;
           
            if (random.NextDouble() > odds)
            {
                player.RecieveCash(pot);
            } else
            {
                player.GiveCash(amount);
            }
        } else
        {
            Console.WriteLine("Please, enter a valid number.");
        }
       
    }
    Console.WriteLine("The house always wins.");
}

Main();
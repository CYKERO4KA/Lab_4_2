namespace Lab_4_2;

class Program
{
    static void Main(string[] args)
    {
        List<Client> clientsList = new List<Client>()
        {
            new ("Max",10),
            new ("Vlad", 344),
            new ("Arnold",200),
            new ("George", 43),
            new ("Egor", 120)
        };
        Queue<Client> clients = new Queue<Client>(clientsList);
        List<Tariff> tariffs = new List<Tariff>
        {
            new("Standard", 100),
            new("Standard+", 200),
            new("SuperNet", 300)
        };
        Provider provider = new Provider(clients, tariffs);
        provider.Start();
        Console.ReadKey();
    }
}
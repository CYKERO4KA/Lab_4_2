namespace Lab_4_2;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<Client> clientsList = new List<Client>()
        {
            new ("Max", random),
            new ("Vlad", random),
            new ("Arnold", random),
            new ("George", random),
            new ("Egor", random)
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
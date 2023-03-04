namespace Lab_4_2;

class Program
{
    static void Main(string[] args)
    {
        List<Client> clientsList = new List<Client>()
        {
            new Client("Max", "Okhtyrka", "+380958763832"),
            new Client("Vlad", "Symi", "+380958763889"),
            new Client("Arnold", "Kharkov", "+38095832873832"),
            //new Client("George", "Kyiv", "+380958654889")
        };
        Queue<Client> clients = new Queue<Client>(clientsList);
        List<Tariff> _tariffs = new List<Tariff>()
        {
            new Tariff("SuperNet", 300),
            new Tariff("Standard", 100),
            new Tariff("Standard+", 200)
        };
        Provider provider = new Provider(clients, _tariffs);
        provider.MakeNewOrder();
        Console.ReadKey();
    }
}
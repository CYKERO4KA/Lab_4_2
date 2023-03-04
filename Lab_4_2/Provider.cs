namespace Lab_4_2;

class Provider
{
    private List<Tariff> _tariffs = new List<Tariff>();
    private Queue<Client> _clients;

    public Provider(Queue<Client> clients, List<Tariff> tariff)
    {
        _clients = new Queue<Client>(clients);
        _tariffs.AddRange(tariff);
    }

    public void MakeNewOrder()
    {
        _clients.Dequeue();
        foreach (var clients in _clients)
        {
            Console.WriteLine($"Client {clients.Name}, tariff: {_tariffs[1].TariffName}");
        }
    }

    public void TerminateContract()
    {
            
    }
}
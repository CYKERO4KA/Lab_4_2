namespace Lab_4_2;

class Tariff
{
    private string _name;
    private int _countOfUsers;
    private int _tariffCost;
    private int _traffic;

    public string Name
    {
        get => _name;
    }
    public int TariffCost
    {
        get => _tariffCost;
    }
    public int TariffUsers
    {
        get => _countOfUsers;
    }
    public int Traffic
    {
        get => _traffic;
    }
    public Tariff(string name, int tariffCost)
    {
        _name = name;
        _tariffCost = tariffCost;
    }

    public void CheckForPayment(Client client)
    {
        if (client.Pay(_tariffCost))
        {
            _countOfUsers++;
            _traffic += 122;
            Console.WriteLine("A client bought your tariff!");
        }
        else
        {
            Console.WriteLine("Your client doesn't have enough money to pay!");
        }
    }
}
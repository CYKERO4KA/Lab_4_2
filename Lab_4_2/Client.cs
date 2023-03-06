namespace Lab_4_2;

class Client
{
    private readonly string _name;
    private readonly int _money;

    public string Name
    {
        get => _name;
    }
    public int Money
    {
        get => _money;
    }

    public Client(string name, Random random)
    {
        _name = name;
        _money = random.Next(70, 400);
    }
    public bool Pay(int paiment)
    {
        if (_money >= paiment)
            return true;
        else
            return false;
    }
}
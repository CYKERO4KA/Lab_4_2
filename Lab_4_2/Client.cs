namespace Lab_4_2;

class Client
{
    private readonly string _name;
    private readonly string _address;
    private readonly string _number;
    private int _money;

    private bool _isContract;
        
    public string Name { get => _name; }
    public string Adress { get => _address; }
    public string Number { get => _number; }
    public bool IsContract
    {
        get => _isContract;
        set => _isContract = IsContract;
    }
        


    public Client(string name, string address, string number)
    {
        _name = name;
        _address = address;
        _number = number;
    }
    public void Pay(int paiment)
    {
        if(_money >= paiment)
            _money -= paiment;
        else
            Console.WriteLine("ERROR!");
    }
}
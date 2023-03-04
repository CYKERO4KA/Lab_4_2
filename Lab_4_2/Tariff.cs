namespace Lab_4_2;

class Tariff
{
    private string _tariffName;
    private int _countOfUsers;
    private int _tariffCost;

    public string TariffName
    {
        get => _tariffName;
    }
    public int TariffCost
    {
        get => _tariffCost;
    }
    public int TariffUsers
    {
        get => _countOfUsers;
        set => _countOfUsers = TariffUsers;
    }
    public Tariff(string tariffName, int tariffCost)
    {
        _tariffName = tariffName;
        _tariffCost = tariffCost;
    }
}
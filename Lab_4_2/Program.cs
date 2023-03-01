namespace Lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Provider
    {
        private List<Tariff> _tariffs = new List<Tariff>();
    }

    class Client
    {
        private readonly string _name;
        private readonly string _address;
        private readonly string _number;
        
        public string Name { get => _name; }
        public string Adress { get => _address; }
        public string Number { get => _number; }

        private int _money;

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

    class Tariff
    {
        private List<Client> _clients = new List<Client>();
        private int _tariffCost;

        public void AddClient()
        {
        }

        public void RemoveClient()
        {
            
        }
    }
}
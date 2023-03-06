namespace Lab_4_2;

class Provider
{
    private List<Tariff> _tariffs = new List<Tariff>();
    private Queue<Client> _clients;

    public Provider(Queue<Client> clients, List<Tariff> tariffs)
    {
        _clients = new Queue<Client>(clients);
        _tariffs.AddRange(tariffs);
    }
    public void Start()
    {
        int index;
        Console.Clear();
        while (true)
        {
            Console.WriteLine("What you want?:\n1. Add clients\n2. See rating");

            index = Convert.ToInt32(Console.ReadLine());
            if(index == 1)
                MakeNewOrder();
            else if (index == 2)
                ShowRating();
            else
                Console.WriteLine("ERROR");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private void MakeNewOrder()
    {
        Console.Clear();
        int count = 0;
        
        while (_clients.Count > 0)
        {
            foreach (var clients in _clients)
            {
                Console.WriteLine($"Client {clients.Name}, money {clients.Money}$");
            }
            foreach (var tariffs in _tariffs)
            {
                Console.WriteLine(
                    $"{++count}. {tariffs.Name} --- {tariffs.TariffCost}$");
            }

            Console.WriteLine($"Which tariff you propose for {_clients.Peek().Name}?: ");
            var index = Convert.ToInt32(Console.ReadLine());

            _tariffs[index - 1].CheckForPayment(_clients.Dequeue());


            Console.ReadKey();
            count = 0;
            Console.Clear();
        }
        Console.WriteLine("You doesn't have any clients!");
    }


    private void ShowRating()
    {
        Console.Clear();
        int count = 0;
        string answer;
        
        foreach (var tariffs in _tariffs)
        {
            Console.WriteLine(
                $"{++count}. {tariffs.Name} --- {tariffs.TariffCost}$  (users: {tariffs.TariffUsers}) (traffic: {tariffs.Traffic})");
        }

        Console.WriteLine("You want to sort? (y/n):");
        answer = Console.ReadLine();
        if (answer == "y")
        {
            Sort();
        }
        else if(answer == "n")
        {
            return;
        }
        else
        {
            Console.WriteLine("ERROR!");
        }
    }

    private void Sort()
    {
        string sortBy;
        string sortTo;
        Console.Clear();
        Console.WriteLine("Sort by traffic or cost? (t/c):");
        sortBy = Console.ReadLine();
        if (sortBy == "t")
        {
            int i = 0;
            var traffic = _tariffs.OrderBy(n => n.Traffic);
            foreach (var tf in traffic)
            {
                Console.WriteLine($"{tf.Name}  {tf.TariffCost}  {tf.TariffUsers}  {tf.Traffic}");
                _tariffs[i++] = tf;
            }
        }
        else if(sortBy == "c")
        {
            
        }
        else
        {
            Console.WriteLine("ERROR!");
        }
    }
}
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
        char index;
        Console.Clear();
        while (true)
        {
            Console.WriteLine("What you want?:\n1. Add clients\n2. See rating");

            index = Convert.ToChar(Console.ReadLine());
            if(index == '1')
                MakeNewOrder();
            else if (index == '2')
                ShowRating();
            else
                Console.WriteLine("Incorrect index!");
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
                Console.WriteLine($"Client {clients.Name}, money - {clients.Money}$");
            }

            Console.WriteLine();
            foreach (var tariffs in _tariffs)
            {
                Console.WriteLine(
                    $"{++count}. {tariffs.Name} --- {tariffs.TariffCost}$");
            }

            Console.WriteLine();

            Console.Write($"Which tariff you propose for {_clients.Peek().Name}?: ");
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

        Console.Write("\nYou want to sort? (y/n): ");
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
            Console.WriteLine("Incorrect answer!");
        }
    }
//----------------------------------------------SORTING-----------------------------------------------------------------
    private void Sort()
    {
        string sortBy;
        Console.Clear();
        Console.Write("Sort by traffic or cost or average? (t/c/a): ");
        sortBy = Console.ReadLine();
        if (sortBy == "t")
        {
            SortByTraffic();
        }
        else if(sortBy == "c")
        {
            SortByCost();
        }
        else if (sortBy == "a")
        {
            SortByAverage();
        }
        else
        {
            Console.WriteLine("Incorrect answer!");
        }
    }

    private void SortByTraffic()
    {
        string sortTo;

        Console.Write("You want sort to max or to min? (max/min): ");
        sortTo = Console.ReadLine();
        Console.WriteLine();
        if (sortTo == "max")
        {
            int i = 0;
            var traffic = _tariffs.OrderBy(n => n.Traffic);
            ShowList(traffic, i);
        }
        else if (sortTo == "min")
        {
            int i = 0;
            var traffic = _tariffs.OrderByDescending(n => n.Traffic);
            ShowList(traffic, i);
        }
        else
        {
            Console.WriteLine("Incorrect answer!");
        }
    }
    private void SortByCost()
    {
        string sortTo;
        
        Console.Write("You want sort to max or to min? (max/min): ");
        sortTo = Console.ReadLine();
        Console.WriteLine();
        if (sortTo == "max")
        {
            int i = 0;
            var traffic = _tariffs.OrderBy(n => n.TariffCost);
            ShowList(traffic, i);
        }
        else if (sortTo == "min")
        {
            int i = 0;
            var traffic = _tariffs.OrderByDescending(n => n.TariffCost);
            ShowList(traffic, i);
        }
        else
        {
            Console.WriteLine("Incorrect answer!");
        }
    }
    private void SortByAverage()
    {
        string trafficSortTo;
        string costSortTo;
        
        Console.Write("You want sort traffic to max or to min? (max/min): ");
        trafficSortTo = Console.ReadLine();
        
        Console.Write("You want sort cost to max or to min? (max/min): ");
        costSortTo = Console.ReadLine();
        
        Console.WriteLine();
        if (trafficSortTo == "max" && costSortTo == "max")
        {
            int i = 0;
            var traffic = _tariffs.OrderBy(n => n.TariffCost).ThenBy(n => n.Traffic);
            ShowList(traffic, i);
        }
        else if (trafficSortTo == "max" && costSortTo == "min")
        {
            int i = 0;
            var traffic = _tariffs.OrderByDescending(n => n.TariffCost).ThenBy(n => n.Traffic);
            ShowList(traffic, i);
        }
        if (trafficSortTo == "min" && costSortTo == "max")
        {
            int i = 0;
            var traffic = _tariffs.OrderBy(n => n.TariffCost).ThenByDescending(n => n.Traffic);
            ShowList(traffic, i);
        }
        else if (trafficSortTo == "min" && costSortTo == "min")
        {
            int i = 0;
            var traffic = _tariffs.OrderByDescending(n => n.TariffCost).ThenByDescending(n => n.Traffic);
            ShowList(traffic, i);
        }
        else
        {
            Console.WriteLine("Incorrect answer!");
        }
    }

    private void ShowList(IOrderedEnumerable<Tariff> traffic, int i)
    {
        foreach (var tf in traffic)
        {
            Console.WriteLine($"{tf.Name} --- {tf.TariffCost}$  (users: {tf.TariffUsers}) (traffic: {tf.Traffic})");
            _tariffs[i++] = tf;
        }
    }
}
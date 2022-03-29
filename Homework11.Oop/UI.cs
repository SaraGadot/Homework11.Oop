namespace Homework11.Oop;
internal class UI
{
    public List<Client> Clients = new List<Client>()
        {
            new Client()
            {
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                Phone = "89031452627",
                Passport = "4569 123456",
            },
            new Client()
            {
                LastName = "Петров",
                FirstName = "Виктор",
                MiddleName = "Иванович",
                Phone = "89031467895",
                Passport = "4569 456789",
            },
            new Client()
            {
                LastName = "Сидоров",
                FirstName = "Виктор",
                MiddleName = "Михайлович",
                Phone = "89031467867",
                Passport = "",
            },
        };
    public Consultant Consultant = new Consultant();

    public void View()
    {
        var viewClients = Consultant.View(Clients);
        foreach (var client in viewClients)
        {
            Console.WriteLine($"{client.LastName} {client.FirstName} {client.MiddleName} {client.Phone} {client.Passport}");
        }

    }

    public void Menu()
    {
        for (; ; )
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - показать клиентов");
            var action = Console.ReadLine();
            if (action == "1")
            {
                View();
            }
            Console.WriteLine();
        }

                
               

        
    }
}


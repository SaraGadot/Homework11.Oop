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

    public void ChangeLastName()
    {
        var viewClients = Consultant.View(Clients);
        Console.WriteLine("Введите номер клиента");
        var clientIndex = Convert.ToInt32(Console.ReadLine());
        var client = viewClients[clientIndex];
        Console.WriteLine("Введите новую фамилию");
        var newLastName = Console.ReadLine();
        client.LastName = newLastName;
    }

    public void Menu()
    {
        for (; ; )
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - показать клиентов");
            Console.WriteLine("2 - изменить фамилию");
            var action = Console.ReadLine();
            try
            {
                switch (action)
                {
                    case "1":
                        {
                            View();
                            break;
                        }
                    case "2":
                        {
                            ChangeLastName();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

        }

                
               

        
    }
}


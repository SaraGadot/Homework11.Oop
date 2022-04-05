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
        var client = SelectClient(Clients);
        Console.WriteLine("Введите новую фамилию");
        var newLastName = Console.ReadLine();
        client.LastName = newLastName;
    }
    public void ChangePhone()
    {
        var client = SelectClient(Clients);
        Console.WriteLine("Введите новый номер телефона");
        var newPhone = Console.ReadLine();
        client.Phone = newPhone;
    }

    public ConsultantClient SelectClient(List<Client> clients)
    {
        var viewClients = Consultant.View(clients);
        Console.WriteLine("Введите номер клиента");
        var clientIndex = Convert.ToInt32(Console.ReadLine()) - 1;
        return viewClients[clientIndex];
    }


    public void Menu()
    {
        for (; ; )
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - показать клиентов");
            Console.WriteLine("2 - изменить фамилию");
            Console.WriteLine("3 - изменить номер телефона");

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
                    case "3":
                        {
                            ChangePhone();
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


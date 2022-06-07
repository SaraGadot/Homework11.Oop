namespace Homework11.Oop;
internal class UI
{
    public ClientStorage ClientStorage;
    public IEmployee Employee = new Consultant();

    public UI(ClientStorage clientStorage)
    {
        ClientStorage = clientStorage;
    }
   
    public void View()
    {
        var clients = Employee.View(ClientStorage.Clients);
        foreach (var client in clients)
        {
            Console.WriteLine($"{client.LastName} {client.FirstName} {client.MiddleName} {client.Phone} {client.Passport}" +
                $" {client.ChangeTime} {client.ChangeField} {client.ChangeKind} {client.Changer}");
        }

    }

    public void ChangeLastName()
    {
        var client = SelectClient(ClientStorage);
        Console.WriteLine("Введите новую фамилию");
        var newLastName = Console.ReadLine();
        Employee.ChangeLastName(client, newLastName);

        ClientStorage.Save();
    }
    public void ChangeFirstName()
    {
        var client = SelectClient(ClientStorage);
        Console.WriteLine("Введите новое имя");
        var newFirstName = Console.ReadLine();
        Employee.ChangeFirstName(client, newFirstName);

        ClientStorage.Save();
    }
    public void ChangeMiddleName()
    {
        var client = SelectClient(ClientStorage);
        Console.WriteLine("Введите новое отчество");
        var newMiddleName = Console.ReadLine();
        Employee.ChangeMiddleName(client, newMiddleName);

        ClientStorage.Save();
    }
    public void ChangePhone()
    {
        var client = SelectClient(ClientStorage);
        Console.WriteLine("Введите новый номер телефона");
        var newPhone = Console.ReadLine();
        Employee.ChangePhone(client, newPhone);

        ClientStorage.Save();
    }
    public void ChangePassport()
    {
        var client = SelectClient(ClientStorage);
        Console.WriteLine("Введите новые серию и номер паспорта");
        var newPassport = Console.ReadLine();
        Employee.ChangePassport(client, newPassport);

        ClientStorage.Save();
    }

    public Client SelectClient(ClientStorage clientStorage)
    {
        Console.WriteLine("Введите номер клиента");
        var clientIndex = Convert.ToInt32(Console.ReadLine()) - 1;
        return clientStorage.Clients[clientIndex];
    }

    public void SwitchEmployee()
    {
        if (Employee is Manager)
        {
            Employee = new Consultant();
        }
        else
        {
            Employee = new Manager();
        }
    }

    public void AddClient()
    {
        Console.WriteLine("Введите фамилию");
        var lastName = Console.ReadLine();
        Console.WriteLine("Введите имя");
        var firstName = Console.ReadLine();
        Console.WriteLine("Введите отчество");
        var middleName = Console.ReadLine();
        Console.WriteLine("Введите номер телефона");
        var phone = Console.ReadLine();
        Console.WriteLine("Введите серию и номер паспорта");
        var passport = Console.ReadLine();

        var client = new Client() 
        {
            LastName = lastName,
            FirstName = firstName,
            MiddleName = middleName,
            Phone = phone,
            Passport = passport
        };
        Employee.AddClient(ClientStorage, client);

        ClientStorage.Save();
    }

    public void Menu()
    {
        for (; ; )
        {
            Console.WriteLine($"Вы - {Employee.EmployeeKind}");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("0 - выйти");
            Console.WriteLine("1 - показать клиентов");
            Console.WriteLine("2 - изменить фамилию");
            Console.WriteLine("3 - изменить имя");
            Console.WriteLine("4 - изменить отчество");
            Console.WriteLine("5 - изменить номер телефона");
            Console.WriteLine("6 - изменить серию и номер паспорта");
            Console.WriteLine("7 - Консультант <-> Менеджер");
            Console.WriteLine("8 - добавить клиента");

            var action = Console.ReadLine();
            try
            {
                if(action == "0")
                {
                    break;
                }
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
                            ChangeFirstName();
                            break;
                        }
                    case "4":
                        {
                            ChangeMiddleName();
                            break;
                        }
                    case "5":
                        {
                            ChangePhone();
                            break;
                        }
                    case "6":
                        {
                            ChangePassport();
                            break;
                        }
                    case "7":
                        {
                            SwitchEmployee();
                            break;
                        }
                    case "8":
                        {
                            AddClient();
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


﻿namespace Homework11.Oop;
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
    public Consultant Employee = new Consultant();
   
    public void View()
    {
        var clients = Employee.View(Clients);
        foreach (var client in clients)
        {
            Console.WriteLine($"{client.LastName} {client.FirstName} {client.MiddleName} {client.Phone} {client.Passport}");
        }

    }

    public void ChangeLastName()
    {
        var client = SelectClient(Clients);
        Console.WriteLine("Введите новую фамилию");
        var newLastName = Console.ReadLine();
        Employee.ChangeLastName(client, newLastName);
    }
    public void ChangeFirstName()
    {
        var client = SelectClient(Clients);
        Console.WriteLine("Введите новое имя");
        var newFirstName = Console.ReadLine();
        Employee.ChangeFirstName(client, newFirstName);
    }
    public void ChangeMiddleName()
    {
        var client = SelectClient(Clients);
        Console.WriteLine("Введите новое отчество");
        var newMiddleName = Console.ReadLine();
        Employee.ChangeMiddleName(client, newMiddleName);
    }
    public void ChangePhone()
    {
        var client = SelectClient(Clients);
        Console.WriteLine("Введите новый номер телефона");
        var newPhone = Console.ReadLine();
        Employee.ChangePhone(client, newPhone);
    }

    public Client SelectClient(List<Client> clients)
    {
        Console.WriteLine("Введите номер клиента");
        var clientIndex = Convert.ToInt32(Console.ReadLine()) - 1;
        return clients[clientIndex];
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

    public void Menu()
    {
        for (; ; )
        {
            Console.WriteLine($"Вы - {Employee.EmployeeKind}");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - показать клиентов");
            Console.WriteLine("2 - изменить фамилию");
            Console.WriteLine("3 - изменить имя");
            Console.WriteLine("4 - изменить отчество");
            Console.WriteLine("5 - изменить номер телефона");
            Console.WriteLine("6 - Консультант <-> Менеджер");

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
                            SwitchEmployee();
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


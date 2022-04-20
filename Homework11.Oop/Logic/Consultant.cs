﻿namespace Homework11.Oop;
public class Consultant
{
    public virtual EmployeeKind EmployeeKind
    {
        get
        {
            return EmployeeKind.Consultant;
        }
    }
    public List<Client> View(List<Client> clients)
    {
        return clients.Select(client => TransformClient(client)).ToList();
       
    }
    private Client TransformClient(Client client)
    {
        return new Client()
        {
            LastName = client.LastName,
            FirstName = client.FirstName,
            MiddleName = client.MiddleName,
            Phone = client.Phone,
            Passport = TransformPassport(client.Passport),
        };
    }
    private string? TransformPassport(string? passpotr)
    {
        if (!string.IsNullOrWhiteSpace(passpotr))
        {
            return "********";
        }
        else
        {
            return "";
        }
    }

    public virtual void ChangeLastName(Client client, string? lastName)
    {
        throw new Exception("Нет доступа к смене фамилии");
    }
    public virtual void ChangeFirstName(Client client, string? firstName)
    {
        throw new Exception("Нет доступа к смене имени");
    }
    public virtual void ChangeMiddleName(Client client, string? middleName)
    {
        throw new Exception("Нет доступа к смене отчества");
    }
    public virtual void ChangePhone(Client client, string? phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
        {
            throw new Exception("Номер телефона не должен быть пустым");
        }
        client.Phone = phone;
    }
    public virtual void ChangePassport(Client client, string? passport)
    {
        throw new Exception("Нет доступа к смене паспорта");
    }

}


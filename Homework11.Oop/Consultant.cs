namespace Homework11.Oop;
public class Consultant
{
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

    public void ChangeLastName(Client client, string? lastName)
    {
        throw new Exception("Нет доступа к смене фамилии");
    }
    public void ChangeFirstName(Client client, string? firstName)
    {
        throw new Exception("Нет доступа к смене имени");
    }
    public void ChangeMiddleName(Client client, string? middleName)
    {
        throw new Exception("Нет доступа к смене отчества");
    }
    public void ChangePhone(Client client, string? phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
        {
            throw new Exception("Номер телефона не должен быть пустым");
        }
        client.Phone = phone;
    }

}

public class ConsultantClient
{
    private Client _client;
    public ConsultantClient(Client client)
    {
        _client = client;
    }

    public string LastName
    {
        get { return _client.LastName; }
        set 
        {
            throw new Exception("Нет доступа к смене фамилии");
        }
    }
    public string FirstName
    {
        get { return _client.FirstName; }
        set
        {
            throw new Exception("Нет доступа к смене имени");
        }
    }
    public string MiddleName
    {
        get { return _client.MiddleName; }
        set
        {
            throw new Exception("Нет доступа к смене отчества");
        }
    }
    public string Phone
    {
        get { return _client.Phone; }
        set
        {
           
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Номер телефона не должен быть пустым");
            }
            _client.Phone = value;
        }
    }
    public string Passport
    {
        get 
        {
            if (!string.IsNullOrWhiteSpace(_client.Passport))
            {
                return "********";
            }
            else
            {
                return "";
            }
        }
        set
        {

        }
    }
}


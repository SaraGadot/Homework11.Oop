namespace Homework11.Oop;
public class Consultant
{
    public List<ConsultantClient> View(List<Client> clients)
    {
        return clients.Select(client => new ConsultantClient(client)).ToList();
       
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


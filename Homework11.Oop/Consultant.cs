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
    }
    public string FirstName
    {
        get { return _client.FirstName; }
    }
    public string MiddleName
    {
        get { return _client.MiddleName; }
    }
    public string Phone
    {
        get { return _client.Phone; }
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


using Newtonsoft.Json;

namespace Homework11.Oop;
public class ClientStorage
{
    public List<Client> Clients { get; set;} = new List<Client>();

    public void AddClient (Client client)
    {
        Clients.Add(client);
    }

    public void Save ()
    {
        var json = JsonConvert.SerializeObject(Clients, Formatting.Indented);
        File.WriteAllText("Clients.json", json);
    }
}


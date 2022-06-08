using Newtonsoft.Json;

namespace Homework11.Oop;
public class ClientStorage
{
    public List<Client> Clients { get; set;} = new List<Client>();

    public void AddClient(Client client)
    {
        Clients.Add(client);
    }

    public void Save()
    {
        var json = JsonConvert.SerializeObject(Clients, Formatting.Indented);
        File.WriteAllText("Clients.json", json);
    }

    public static ClientStorage Load()
    {
        if (!File.Exists("Clients.json"))
        {
            return new ClientStorage();
        }
        var json = File.ReadAllText("Clients.json");
        var clients = JsonConvert.DeserializeObject<List<Client>>(json);
        return new ClientStorage()
        {
            Clients = clients
        };

    }
}


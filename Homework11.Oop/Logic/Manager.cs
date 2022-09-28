namespace Homework11.Oop;
public class Manager: Consultant
{
    public override EmployeeKind EmployeeKind
    {
        get { return EmployeeKind.Manager; }
    }
    public override List<Client> View(List<Client> clients)
    {
        return clients;
    }

    public override void AddClient(ClientStorage storage, Client client)
    {
        storage.AddClient(client);

        LogChange(client, "", ChangeKind.Add);
    }
    public override void ChangeLastName(Client client, string? lastName)
    {
        client.LastName = lastName;

        LogChange(client, nameof(client.LastName));

    }
    public override void ChangeFirstName(Client client, string? firstName)
    {
        client.FirstName = firstName;

        LogChange(client, nameof(client.FirstName));
    }
    public override void ChangeMiddleName(Client client, string? middleName)
    {
        client.MiddleName = middleName;

        LogChange(client, nameof(client.MiddleName));
    }
    public override void ChangePhone(Client client, string? phone)
    {
        client.Phone = phone;

        LogChange(client, nameof(client.Phone));
    }
    public override void ChangePassport(Client client, string? passport)
    {
        client.Passport = passport;

        LogChange(client, nameof(client.Passport));
    }
}


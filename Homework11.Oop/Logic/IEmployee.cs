namespace Homework11.Oop;

public interface IEmployee
{
    EmployeeKind EmployeeKind { get; }
    List<Client> View(List<Client> clients);

    void AddClient(ClientStorage storage, Client client);

    void ChangeLastName(Client client, string? lastName);

    void ChangeFirstName(Client client, string? firstName);

    void ChangeMiddleName(Client client, string? middleName);

    void ChangePhone(Client client, string? phone);

    void ChangePassport(Client client, string? passport);

}


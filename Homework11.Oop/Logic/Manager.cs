namespace Homework11.Oop;
internal class Manager: Consultant
{
    public override EmployeeKind EmployeeKind
    {
        get { return EmployeeKind.Manager; }
    }
    public override void ChangeLastName(Client client, string? lastName)
    {
        client.LastName = lastName;
    }
    public override void ChangeFirstName(Client client, string? firstName)
    {
        client.FirstName = firstName;
    }
    public override void ChangeMiddleName(Client client, string? middleName)
    {
        client.MiddleName = middleName;
    }
    public override void ChangePhone(Client client, string? phone)
    {
        client.Phone = phone;
    }
    public override void ChangePassport(Client client, string? passport)
    {
        client.Passport = passport;
    }
}


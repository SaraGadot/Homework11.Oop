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
}


namespace Homework11.Oop;
internal class Manager: Consultant
{
    public override void ChangeLastName(Client client, string? lastName)
    {
        client.LastName = lastName;
    }
}


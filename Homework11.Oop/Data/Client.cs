namespace Homework11.Oop;
public class Client
{
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? Phone { get; set; }
    public string? Passport { get; set; }

    public DateTime? ChangeTime { get; set; }
    public string? ChangeField { get; set; }
    public ChangeKind? ChangeKind { get; set; }
    public EmployeeKind? Changer { get; set; }

}
public enum ChangeKind
{
    Change,
    Add
}


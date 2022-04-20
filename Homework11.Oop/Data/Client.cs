namespace Homework11.Oop;
public class Client
{
    public string? LastName;
    public string? FirstName;
    public string? MiddleName;
    public string? Phone;
    public string? Passport;

    public DateTime? ChangeTime;
    public string? ChangeField;
    public ChangeKind? ChangeKind;
    public EmployeeKind? Changer;

}
public enum ChangeKind
{
    Change,
    Add
}


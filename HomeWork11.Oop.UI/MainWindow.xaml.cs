using System.Windows;
using System.Windows.Controls;

namespace Homework11.Oop.UI;

public partial class MainWindow : Window
{
    public ClientStorage Storage { get; set; } = new ClientStorage();
    
    public IEmployee Employee { get; set; } = new Consultant();
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this;

        Storage.AddClient(new Client()
        {
            FirstName = "Иван",
            MiddleName = "Иванович",
            LastName = "Иванов",
            Passport = "4502 451269",
            Phone = "89031450566"
        }
        );

        Storage.AddClient(new Client()
        {
            FirstName = "Мария",
            MiddleName = "Петровна",
            LastName = "Сидорова",
            Passport = "4502 451345",
            Phone = "89031650561"
        }
        );

        Clients_Grid.ItemsSource = Storage.Clients;
    }

    

    private void ToManager_Menu_Click(object sender, RoutedEventArgs e)
    {
        Employee = new Manager();

        Employee_TextBlock.GetBindingExpression(TextBlock.TextProperty).UpdateTarget();
    }

    private void ToConsultant_Menu_Click(object sender, RoutedEventArgs e)
    {
        Employee = new Consultant();

        Employee_TextBlock.GetBindingExpression(TextBlock.TextProperty).UpdateTarget();
    }

    private void Apply_Button_Click(object sender, RoutedEventArgs e)
    {
        var client = new Client()
        {
            FirstName = FirstName_TextBox.Text,
            MiddleName = MiddleName_TextBox.Text,
            LastName = LastName_TextBox.Text,
            Passport = Passport_TextBox.Text,
            Phone = Phone_TextBox.Text
        };
       
        Employee.AddClient(Storage, client);

        Clients_Grid.ItemsSource = null;
        Clients_Grid.ItemsSource = Storage.Clients;

        FirstName_TextBox.Text = null;
        MiddleName_TextBox.Text = null;
        LastName_TextBox.Text = null;
        Passport_TextBox.Text = null;
        Phone_TextBox.Text = null;
    }

}

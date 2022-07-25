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
}

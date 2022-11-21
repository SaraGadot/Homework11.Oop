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

        Storage = ClientStorage.Load();

        Clients_Grid.ItemsSource = Employee.View(Storage.Clients);
    }

    

    private void ToManager_Menu_Click(object sender, RoutedEventArgs e)
    {
        Employee = new Manager();

        Employee_TextBlock.GetBindingExpression(TextBlock.TextProperty).UpdateTarget();

        Clients_Grid.ItemsSource = Employee.View(Storage.Clients);

    }

    private void ToConsultant_Menu_Click(object sender, RoutedEventArgs e)
    {
        Employee = new Consultant();

        Employee_TextBlock.GetBindingExpression(TextBlock.TextProperty).UpdateTarget();

        Clients_Grid.ItemsSource = Employee.View(Storage.Clients);

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

        Storage.Save();

        Refresh_Clients_Grid();


        FirstName_TextBox.Text = null;
        MiddleName_TextBox.Text = null;
        LastName_TextBox.Text = null;
        Passport_TextBox.Text = null;
        Phone_TextBox.Text = null;
    }

    private void Clients_Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var client = Clients_Grid.SelectedItem as Client;
        Change_LastName_TextBox.Text = client?.LastName;
        Change_FirstName_TextBox.Text = client?.FirstName;
        Change_MiddleName_TextBox.Text = client?.MiddleName;
        Change_Phone_TextBox.Text = client?.Phone;
        Change_Passport_TextBox.Text = client?.Passport;
    }

    private void Change_LastName_Button_Click(object sender, RoutedEventArgs e)
    {
        var client = Storage.Clients[Clients_Grid.SelectedIndex];
        Employee.ChangeLastName(client, Change_LastName_TextBox.Text);

        Refresh_Clients_Grid();
    }

    private void Refresh_Clients_Grid()
    {
        Clients_Grid.ItemsSource = null;
        Clients_Grid.ItemsSource = Employee.View(Storage.Clients);
    }

    private void Change_FirstName_Button_Click(object sender, RoutedEventArgs e)
    {
        var client = Storage.Clients[Clients_Grid.SelectedIndex];
        Employee.ChangeFirstName(client, Change_FirstName_TextBox.Text);

        Refresh_Clients_Grid();

    }

    private void Change_MiddleName_Button_Click(object sender, RoutedEventArgs e)
    {
        var client = Storage.Clients[Clients_Grid.SelectedIndex];
        Employee.ChangeMiddleName(client, Change_MiddleName_TextBox.Text);

        Refresh_Clients_Grid();

    }

    private void Change_Phone_Button_Click(object sender, RoutedEventArgs e)
    {
        var client = Storage.Clients[Clients_Grid.SelectedIndex];
        Employee.ChangePhone(client, Change_Phone_TextBox.Text);

        Refresh_Clients_Grid();

    }

    private void Change_Passport_Button_Click(object sender, RoutedEventArgs e)
    {
        var client = Storage.Clients[Clients_Grid.SelectedIndex];
        Employee.ChangePassport(client, Change_Passport_TextBox.Text);

        Refresh_Clients_Grid();

    }
}

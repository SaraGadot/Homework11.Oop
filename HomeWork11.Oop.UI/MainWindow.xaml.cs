using System.Windows;
using System.Windows.Controls;

namespace Homework11.Oop.UI;

public partial class MainWindow : Window
{
    public IEmployee Employee { get; set; } = new Consultant();
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this;
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

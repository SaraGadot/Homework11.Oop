using System.Windows;

namespace Homework11.Oop.UI;

public partial class MainWindow : Window
{
    public IEmployee Employee { get; set; } = new Consultant();
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this;
    }
}

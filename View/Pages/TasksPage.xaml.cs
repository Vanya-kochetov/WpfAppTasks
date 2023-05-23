using System.Windows;
using System.Windows.Controls;
using WpfAppTasks.View.Pages.Tasks;

namespace WpfAppTasks.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Tasks.xaml
    /// </summary>
    public partial class TasksPage : Page
    {
        public TasksPage()
        {
            InitializeComponent();
        }

        private void ToTask1_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task1Page());
        }

        private void ToTask2_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task2Page());
        }

        private void ToTask3_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task3Page());
        }

        private void ToTask4_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task4Page());
        }

        private void ToTask5_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task5Page());
        }

        private void ToTask6_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task6Page());
        }

        private void ToTask7_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task7Page());
        }

        private void ToTask8_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task8Page());
        }

        private void ToTask9_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task9Page());
        }

        private void ToTask10_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new Task10Page());
        }
    }
}

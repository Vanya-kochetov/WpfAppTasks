using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTasks.View.Pages.Tasks
{
    /// <summary>
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public int[,] InputMatrix { set; get; }
        public double[,] ResultMatrix { set; get; }

        readonly Random random = new();

        public Task1Page()
        {
            InitializeComponent();
            InputMatrix = new int[5, 5];
            ResultMatrix = new double[5, 5];
        }

        private void ButtonFillRandom_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    InputMatrix[i, j] = random.Next(-100, 100);
            InputMatrixDataGrid.Items.Refresh();
        }

        private void ButtonSolve_Click(object sender, RoutedEventArgs e)
        {
            double max = InputMatrix[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Math.Abs(InputMatrix[i, j]) > Math.Abs(max))
                        max = InputMatrix[i, j];
                }
            }
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    ResultMatrix[i, j] = InputMatrix[i, j] / max;
            ResultMatrixDataGrid.Items.Refresh();
        }

        private void ToTasks_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new TasksPage());
        }
    }
}

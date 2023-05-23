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
    public partial class Task6Page : Page
    {
        public int[,] InputMatrix { set; get; }
        public int[,] ResultMatrix { set; get; }

        readonly Random random = new();

        public Task6Page()
        {
            InitializeComponent();
            InputMatrix = new int[5, 5];
            ResultMatrix = new int[5, 5];
        }

        private void ButtonFillRandom_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    InputMatrix[i, j] = random.Next(100);
            InputMatrixDataGrid.Items.Refresh();
        }

        private void ButtonSolve_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < InputMatrix.GetLength(0); i++)
            {
                int maxIndex = 0;
                for (int j = 0; j < 5; j++)
                {
                    ResultMatrix[i, j] = InputMatrix[i, j];
                    if (InputMatrix[i, j] > InputMatrix[i, maxIndex])
                        maxIndex = j;
                }
                ResultMatrix[i, i] = InputMatrix[i, maxIndex];
                ResultMatrix[i, maxIndex] = InputMatrix[i, i];
            }
            ResultMatrixDataGrid.Items.Refresh();
        }

        private void ToTasks_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new TasksPage());
        }
    }
}

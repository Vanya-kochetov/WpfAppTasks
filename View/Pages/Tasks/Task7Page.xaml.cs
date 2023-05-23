using System;
using System.Windows;
using System.Windows.Controls;
using Gu.Wpf.DataGrid2D;

namespace WpfAppTasks.View.Pages.Tasks
{
    /// <summary>
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public int[,] InputMatrix { set; get; } = new int[5, 5];
        readonly Random random = new();

        public Task7Page()
        {
            InitializeComponent();
        }

        private void ToTasks_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new TasksPage());
        }

        private void ButtonFillRandom_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < InputMatrix.GetLength(0); i++)
                for (int j = 0; j < InputMatrix.GetLength(1); j++)
                    InputMatrix[i, j] = random.Next(0, 100);
            InputMatrixDataGrid.Items.Refresh();
        }

        private void ButtonSolve_Click(object sender, RoutedEventArgs e)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;
            for (int i = 0; i < InputMatrix.GetLength(0); i++)
            {
                int number = 0;
                for (int j = 0; j < InputMatrix.GetLength(1); j++)
                    if (i + j != 0 && InputMatrix[i, j] % (i + j) == 0)
                        number++;
                if (number < minNumber)
                {
                    minNumber = number;
                    minIndex = i;
                }
            }
            ColumnNumber.Text = minIndex.ToString();
            InputMatrixDataGrid.Items.Refresh();
        }
    }
}

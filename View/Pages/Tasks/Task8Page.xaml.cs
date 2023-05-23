using System;
using System.Windows;
using System.Windows.Controls;
using Gu.Wpf.DataGrid2D;

namespace WpfAppTasks.View.Pages.Tasks
{
    /// <summary>
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public int[,] InputMatrix { set; get; } = new int[5, 5];
        readonly Random random = new();

        public Task8Page()
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
                    InputMatrix[i, j] = random.Next(50);
            InputMatrixDataGrid.Items.Refresh();
        }

        private void ButtonSolve_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < InputMatrix.GetLength(0); i++)
                for (int j = 0; j < InputMatrix.GetLength(1); j++)
                    if (j > i)
                        sum += InputMatrix[i, j];
            Summ.Text = sum.ToString();
            InputMatrixDataGrid.Items.Refresh();
        }
    }
}

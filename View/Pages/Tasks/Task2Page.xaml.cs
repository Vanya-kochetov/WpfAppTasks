using System;
using System.Windows;
using System.Windows.Controls;
using Gu.Wpf.DataGrid2D;

namespace WpfAppTasks.View.Pages.Tasks
{
    /// <summary>
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public int[,] InputMatrix { set; get; } = new int[5, 6];
        readonly Random random = new();

        public Task2Page()
        {
            InitializeComponent();
        }

        private void RowNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(RowNumber.Text, out int row))
            {
                int[,] buffer = new int[row, InputMatrix.GetLength(1)];
                for (int i = 0; i < Math.Min(InputMatrix.GetLength(0), buffer.GetLength(0)); i++)
                    for (int j = 0; j < Math.Min(InputMatrix.GetLength(1), buffer.GetLength(1)); j++)
                        buffer[i, j] = InputMatrix[i, j];
                InputMatrix = buffer;
                InputMatrixDataGrid.SetArray2D(InputMatrix);
                InputMatrixDataGrid.Items.Refresh();
            }
        }

        private void ColumnNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(ColumnNumber.Text, out int column))
            {
                int[,] buffer = new int[InputMatrix.GetLength(0), column];
                for (int i = 0; i < Math.Min(InputMatrix.GetLength(0), buffer.GetLength(0)); i++)
                    for (int j = 0; j < Math.Min(InputMatrix.GetLength(1), buffer.GetLength(1)); j++)
                        buffer[i, j] = InputMatrix[i, j];
                InputMatrix = buffer;
                InputMatrixDataGrid.SetArray2D(InputMatrix);
                InputMatrixDataGrid.Items.Refresh();
            }
        }

        private void ToTasks_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new TasksPage());
        }

        private void ButtonFillRandom_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < InputMatrix.GetLength(0); i++)
                for (int j = 0; j < InputMatrix.GetLength(1); j++)
                    InputMatrix[i, j] = random.Next(-100, 100);
            InputMatrixDataGrid.Items.Refresh();
        }

        private void ButtonSolve_Click(object sender, RoutedEventArgs e)
        {
            for (int z = 0; z < InputMatrix.GetLength(1); z++)
            {
                int temp;
                for (int i = 0; i < InputMatrix.GetLength(0); i++)
                {
                    for (int j = i + 1; j < InputMatrix.GetLength(0); j++)
                    {
                        if (z % 2 == 0 ? InputMatrix[i, z] > InputMatrix[j, z] :
                            InputMatrix[i, z] < InputMatrix[j, z])
                        {
                            temp = InputMatrix[i, z];
                            InputMatrix[i, z] = InputMatrix[j, z];
                            InputMatrix[j, z] = temp;
                        }
                    }
                }
            }
            InputMatrixDataGrid.Items.Refresh();
        }
    }
}

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
    public partial class Task3Page : Page
    {
        public int[,] InputMatrix { set; get; }

        readonly Random random = new();

        public Task3Page()
        {
            InitializeComponent();
            InputMatrix = new int[5, 8];
        }

        private void ButtonFillRandom_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < InputMatrix.GetLength(0); i++)
                for (int j = 0; j < InputMatrix.GetLength(1); j++)
                    InputMatrix[i, j] = random.Next(0, 20);
            InputMatrixDataGrid.Items.Refresh();
        }

        private void ButtonSolve_Click(object sender, RoutedEventArgs e)
        {
            int sum2Column = 0;
            for (int i = 0; i < InputMatrix.GetLength(0); i++)
                sum2Column += InputMatrix[i, 1];
            Summ2Column.Text = sum2Column.ToString();
            int sum3row = 0;
            for (int i = 0; i < InputMatrix.GetLength(1); i++)
                sum3row += InputMatrix[2, i];
            Summ3Row.Text = sum3row.ToString();
        }

        private void ToTasks_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).MainFrame.Navigate(new TasksPage());
        }
    }
}

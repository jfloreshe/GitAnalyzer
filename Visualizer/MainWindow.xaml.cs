using Domain.Interfaces;
using System.Windows;

namespace Visualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataAccess _dataAccess;

        public MainWindow(IDataAccess dataAccess)
        {
            InitializeComponent();
            _dataAccess = dataAccess;
        }

        private void MainActionButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_dataAccess.GetData());
        }
    }
}

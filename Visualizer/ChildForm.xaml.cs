using System.Windows;

namespace Visualizer
{
    /// <summary>
    /// Interaction logic for ChildForm.xaml
    /// </summary>
    public partial class ChildForm : Window
    {
        public int Count { get; private set; } = 0;
        public ChildForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Counter.Text = (++Count).ToString();
        }
    }
}

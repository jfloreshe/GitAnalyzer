using Domain.Interfaces;
using Domain.Interfaces.Factories;
using Infrastructure.Factories;
using System;
using System.Globalization;
using System.Windows;

namespace Visualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataAccess _dataAccess;
        private readonly IAbstractFactory<ChildForm> _childFormFactory;
        private readonly IAbstractFactory<ChildForm2> _childForm2Factory;

        public MainWindow(IDataAccess dataAccess, IAbstractFactory<ChildForm> childFormFactory, IAbstractFactory<ChildForm2> childForm2Factory)
        {
            InitializeComponent();
            _dataAccess = dataAccess;
            _childFormFactory = childFormFactory;
            _childForm2Factory = childForm2Factory;
        }

        private void getData_click(object sender, RoutedEventArgs e)
        {
            data.Text = _dataAccess.GetData();
        }

        private void openChildForm_Click(object sender, RoutedEventArgs e)
        {
            _childFormFactory.Create().Show();
        }

        private void openChildForm2_Click(object sender, RoutedEventArgs e)
        {
            _childForm2Factory.Create().Show();
        }
    }
}

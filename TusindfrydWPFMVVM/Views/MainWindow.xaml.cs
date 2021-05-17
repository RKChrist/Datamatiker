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
using TusindfrydWPFMVVM.Models;
using TusindfrydWPFMVVM.ViewModels;
using TusindfrydWPFMVVM.Views;

namespace TusindfrydWPFMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainViewModel mvm = new MainViewModel();
        CreateFlowerDialog cf;
        EditFlowerDialog ef;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void CreateFlower_Click(object sender, RoutedEventArgs e)
        {
            // Create the dialog
            cf = new CreateFlowerDialog();

            // Show the cf
            cf.ShowDialog();

            if (((bool)cf.DialogResult))
            {
                mvm.AddDefaultFlower(cf.Flower);
            }

        }

        private void EditFlower_Click(object sender, RoutedEventArgs e)
        {

            ef = new EditFlowerDialog(mvm);

            ef.ShowDialog();

            if (((bool)ef.DialogResult))
            {
                mvm.UpdateFlower(ef.Flower);
            }
        }

        private void DeleteFlower_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

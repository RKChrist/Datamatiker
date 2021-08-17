using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TusindfrydWPFMVVM.Models;
using TusindfrydWPFMVVM.ViewModels;

namespace TusindfrydWPFMVVM.Views
{
    /// <summary>
    /// Interaction logic for EditFlowerDialog.xaml
    /// </summary>
    public partial class EditFlowerDialog : Window
    {

        public MainViewModel mvm;
        public Flower Flower { get; set; }

        public EditFlowerDialog(MainViewModel mvm)
        {
            InitializeComponent();
            Flower = mvm.GetCurrentFlower();
            this.mvm = mvm;
            DataContext = Flower;
        }

        private void EEditFlower_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}

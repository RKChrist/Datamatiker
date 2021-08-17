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
    /// Interaction logic for CreateFlowerDialog.xaml
    /// </summary>
    public partial class CreateFlowerDialog : Window
    {
        public Flower Flower { get; set; }

        public CreateFlowerDialog()
        {
            InitializeComponent();

            Flower = new Flower();
            DataContext = Flower;
        }

        private void DCreateFlower_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}

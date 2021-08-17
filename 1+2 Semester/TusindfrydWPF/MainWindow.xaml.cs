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

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Global variables
        List<FlowerSort> flowerSorts;
        CreateFlowerSortDialog cf;
        EditFlowerSortDialog ef;

        // Constructor
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();
            UpdateInformationsXd();
        }

        /// <summary>
        /// Custom method, used for updating various information after user input.
        /// </summary>
        private void UpdateInformationsXd()
        {
            if(flowerSorts.Count > 0)
            {
                FlowersortsLabel.Content = $"Blomstersorter ({flowerSorts.Count})";
                string flowers = "";
                foreach(FlowerSort flower in flowerSorts)
                {
                    flowers += $"{flower.Name}\n";
                }
                SortContainer.Text = flowers;
            } else
            {
                FlowersortsLabel.Content = $"Blomstersorter";
            }
        }

        // New flower sort button click
        private void CreateFlower_Click(object sender, RoutedEventArgs e)
        {
            // Instantiate the dialog box
            cf = new CreateFlowerSortDialog();

            // Open it
            cf.ShowDialog();

            if(((bool)cf.DialogResult))
            {
                // Adds to the list
                flowerSorts.Add(cf.Fs);
                UpdateInformationsXd();
            }
        }

        private void EditFlower_Click(object sender, RoutedEventArgs e)
        {
            ef = new EditFlowerSortDialog();
            ef.flowerSorts = flowerSorts;   // Send information about current flowers.

            ef.ShowDialog();

            if((bool)ef.DialogResult)
            {
                flowerSorts = ef.flowerSorts;
                UpdateInformationsXd();
            }
        }

        private void DeleteFlower_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

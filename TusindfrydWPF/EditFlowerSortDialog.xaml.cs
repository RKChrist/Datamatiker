using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class EditFlowerSortDialog : Window
    {
        // Property for getting this information
        public FlowerSort Fs;

        public List<FlowerSort> flowerSorts;

        // Constructor
        public EditFlowerSortDialog()
        {
            InitializeComponent();
            Fs = new FlowerSort();
        }

        // On text flower name change
        private void FlowerNameChanged(object sender, TextChangedEventArgs e)
        {
            // If flower name exists
            foreach(FlowerSort flower in flowerSorts)
            {
                if(flower.Name == FlowerName.Text)
                {
                    Fs = flower;
                    PicturePath.Text = Fs.PicturePath;
                    ProductionTime.Text = Fs.ProductionTime.ToString();
                    HalfTime.Text = Fs.HalfLifeTime.ToString();
                    Size.Text = Fs.Size.ToString();

                    try
                    {
                        Image.Source = new BitmapImage(new Uri(PicturePath.Text));
                    }
                    catch (Exception ex)
                    {
                        PicturePath.Text = "Incorrect path.";
                    }
                    break;
                } else
                {
                    PicturePath.Text = "";
                    ProductionTime.Text = "";
                    HalfTime.Text = "";
                    Size.Text = "";
                    Fs = null;
                }
            }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void HalfTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            Fs.HalfLifeTime = int.Parse(HalfTime.Text); // should have error checking....

            // Save the new value
            flowerSorts[flowerSorts.FindIndex(i => i.Name == Fs.Name)] = Fs;
        }
    }
}
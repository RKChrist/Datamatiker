using System;
using System.Collections.Generic;
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
    public partial class CreateFlowerSortDialog : Window
    {
        // Property for getting this information
        public FlowerSort Fs { get; }

        // This is probably not a good way of doing it, but well... I don't know any other way.
        // It's used for keeping the "Ok" button disabled, till something has been typed in all input fields.
        bool nameSet = false;
        bool pictureSet = false;
        bool productionSet = false;
        bool halflifeSet = false;
        bool sizeSet = false;

        // Constructor
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            Fs = new FlowerSort();
        }

        /// <summary>
        /// Runs when FlowerName text field changes.
        /// </summary>
        private void FlowerNameChanged(object sender, TextChangedEventArgs e)
        {
            // Set the property in the flower object, to the value of FlowerName input field.
            Fs.Name = FlowerName.Text;

            // Check ifthe FlowerName input field is empty (probably exists a better way xd)
            if (FlowerName.Text != "" || FlowerName.Text != " ")
            {
                // Then make sure the program knows this field has been set and update stuff accordingly
                nameSet = true;
            } else
            {
                nameSet = false;
            }
            UpdateStuff();
        }

        /// <summary>
        /// Runs when PicturePath has been changed.
        /// </summary>
        private void PicturePathChanged(object sender, TextChangedEventArgs e)
        {
            Fs.PicturePath = PicturePath.Text;
            if (PicturePath.Text != "" || PicturePath.Text != " ")
            {
                pictureSet = true;
            }
            UpdateStuff();
        }

        /// <summary>
        /// Runs when ProductionTime changes.
        /// </summary>
        private void ProductionTimeChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                // Try to parse the information into an int from a string
                Fs.ProductionTime = int.Parse(ProductionTime.Text);
                if (ProductionTime.Text != "" || ProductionTime.Text != " ")
                {
                    productionSet = true;
                    UpdateStuff();
                }
            } catch(FormatException ex)
            {
                MessageBox.Show("Gør kun brug af heltal.");
            } catch(Exception ex)
            {
                MessageBox.Show($"Der skete en fejl.\n{ex.Message}");
            }
        }

        /// <summary>
        /// Runs when HalfTime changes.
        /// </summary>
        private void HalfTimeChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Fs.HalfLifeTime = int.Parse(HalfTime.Text);
                if (HalfTime.Text != "" || HalfTime.Text != " ")
                {
                    halflifeSet = true;
                    UpdateStuff();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Gør kun brug af heltal.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Der skete en fejl.\n{ex.Message}");
            }
        }

        /// <summary>
        /// Runs when Size changes.
        /// </summary>
        private void FlowerSizeChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Fs.Size = int.Parse(Size.Text);
                if (Size.Text != "" || Size.Text != " ")
                {
                    sizeSet = true;
                    UpdateStuff();
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Gør kun brug af heltal.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Der skete en fejl.\n{ex.Message}");
            }
        }

        private void PicturePath_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            try
            {
                Image.Source = new BitmapImage(new Uri(PicturePath.Text));
            } catch(Exception ex)
            {
                PicturePath.Text = "Incorrect path.";
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

        private void UpdateStuff()
        {
            // Check if all inputs has been set.
            if(nameSet && pictureSet && productionSet && halflifeSet && sizeSet)
            {
                OkButton.IsEnabled = true;
            } else
            {
                OkButton.IsEnabled = false;
            }
        }
    }
}
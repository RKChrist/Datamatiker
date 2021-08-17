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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;

        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();

            // Disabled if this true
            EnableCheck(controller);
        }

        private void EnableCheck(Controller controller)
        {
            if (controller.PersonCount == 0 && controller.PersonIndex == -1)
            {
                FirstNameText.IsEnabled = false;
                LastNameText.IsEnabled = false;
                AgeText.IsEnabled = false;
                TelephoneNoText.IsEnabled = false;
                DeletePerson.IsEnabled = false;
                Up.IsEnabled = false;
                Down.IsEnabled = false;
            }
            else
            {
                PersonCount.Content = "Person count " + controller.PersonCount;
                MyIndex.Content = "Index " + controller.PersonIndex;

                // Change all stuff to enabled
                FirstNameText.IsEnabled = true;
                LastNameText.IsEnabled = true;
                AgeText.IsEnabled = true;
                TelephoneNoText.IsEnabled = true;
                DeletePerson.IsEnabled = true;
                Up.IsEnabled = true;
                Down.IsEnabled = true;

                // Update values
                FirstNameText.Text = controller.CurrentPerson.FirstName;
                LastNameText.Text = controller.CurrentPerson.LastName;
                AgeText.Text = Convert.ToString(controller.CurrentPerson.Age);
                TelephoneNoText.Text = controller.CurrentPerson.TelephoneNo;
            }
        }

        // New person
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            EnableCheck(controller);
        }

        // Delete person
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            EnableCheck(controller);
        }

        // Up
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            EnableCheck(controller);
        }

        // Down
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            EnableCheck(controller);
        }



        // Textbox change stuff lol
        private void FirstNameChange(object sender, TextChangedEventArgs args)
        {
            controller.CurrentPerson.FirstName = FirstNameText.Text;
        }
        private void LastNameChange(object sender, TextChangedEventArgs args)
        {
            controller.CurrentPerson.LastName = LastNameText.Text;
        }
        private void AgeChange(object sender, TextChangedEventArgs args)
        {
            try
            {
                controller.CurrentPerson.Age = int.Parse(AgeText.Text); // no error check, cuz no
            } catch(Exception e)
            {
                AgeText.Text = "Needs to be an integer.";
            }
        }
        private void TelephoneNoChange(object sender, TextChangedEventArgs args)
        {
            controller.CurrentPerson.TelephoneNo = TelephoneNoText.Text;
        }
    }
}

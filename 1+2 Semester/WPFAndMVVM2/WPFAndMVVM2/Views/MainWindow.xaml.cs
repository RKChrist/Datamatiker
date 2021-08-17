using System;
using System.Windows;
using WPFAndMVVM2.ViewModels;
using WPFAndMVVM2.Views;

namespace WPFAndMVVM2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm = new MainViewModel();


        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;

            mvm.PersonsVMChanged += PersonsVMChangedHandler;
            mvm.NewPersonRequested += NewPersonRequestedHandler;
        }

        private void PersonsVMChangedHandler(object sender, object e)
        {
            PersonsListBox.ScrollIntoView(mvm.SelectedPerson);
        }

        private void btnDeletePerson_Click(object sender, RoutedEventArgs e)
        {
            mvm.DeleteSelectedPerson();
        }

        private PersonEventArgs NewPersonRequestedHandler(object sender, PersonEventArgs args)
        {
            // Show the new dialog window
            AddPerson addP = new AddPerson();
            addP.ShowDialog();

            // Create new PersonEventArgs for handling all information from dialog window.
            PersonEventArgs p = new PersonEventArgs();

            if (((bool)addP.DialogResult))
            {
                // Change the properties of p to hold the information received.
                p.FirstName = addP.FirstName;
                p.LastName = addP.LastName;
                p.Age = addP.Age;
                p.Phone = addP.Phone;
            } 

            // return all the values we got from the dialog result
            return p;
        }
    }
}

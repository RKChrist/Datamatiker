using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WPFAndMVVM2.Commands;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();

        #region Old Properties

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<PersonViewModel> PersonsVM { get; set; }

        private PersonViewModel selectedPerson;

        public PersonViewModel SelectedPerson
        {
            get { return selectedPerson; }
            set { 
                selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }

        //public PersonViewModel SelectedPerson { get; set; }

        #endregion

        #region Commands
        public ICommand CommandNewPerson { get; } = new CommandNewPerson();
        public ICommand CommandDeletePerson { get; } = new CommandDeletePerson();
        #endregion

        #region Events & Delegates 
        public event EventHandler PersonsVMChanged;
        public delegate PersonEventArgs PersonEventHandler(object sender, PersonEventArgs args);
        public event PersonEventHandler NewPersonRequested;
        #endregion

        public MainViewModel()
        {
            // Initialize PVM list.
            PersonsVM = new ObservableCollection<PersonViewModel>();
            
            /* 
             * "... sørg for i PersonsVM at oprette et [..] PersonVIewModel-objekt for hvert Person-objekt i personRepo
             * Fortolker jeg som at man skal køre personRepo igennem, og for hver eneste smide en ny instance af PVM ind i ens liste. 
             */
            
            // Get all people in personRepo, and loop through 'em
            foreach(Person p in personRepo.GetAll())
            {
                // Add this current person to PVM
                PersonsVM.Add(new PersonViewModel(p));  // TLDR: Take current person. Create new PVM from it. Add it to PVM list.
            }

        }

        /// <summary>
        /// Adds a default person to the list.
        /// </summary>
        public void AddDefaultPerson()
        {
            // Create a new person, and in the same instant create a new personViewModel. 
            // Then change selectedPerson to the created PVM.
            SelectedPerson = new PersonViewModel(personRepo.Add(firstName: "Specify FirstName", lastName: "Specify LastName", age: 0, phone: "Specify Phone"));
            
            // Add the PVM to PersonsVM.    
            PersonsVM.Add(SelectedPerson);

            // Tell the view layer that we updated the property, so it can show the changes.
            OnPersonsVMChanged();
            OnPropertyChanged("SelectedPerson");
        }

        public void AddPerson()
        {
            PersonEventArgs p = OnNewPersonRequested();
            if(
                p.FirstName != null && 
                p.LastName != null &&
                p.Phone != null &&
                p.Age >= 0)
            {
                // Create a new person, then new view model, and then set SelectedPerson to the new PVM.
                var newPerson = personRepo.Add(p.FirstName, p.LastName, p.Age, p.Phone);
                SelectedPerson = new PersonViewModel(newPerson);

                // Add new PVM til list of PVM
                PersonsVM.Add(SelectedPerson);

                // Tell the view layer that we updated the property, so it can show the changes.
                OnPersonsVMChanged();
                OnPropertyChanged("SelectedPerson");
            }

        }

        /// <summary>
        /// Deletes the currently selected person from the list.
        /// </summary>
        public void DeleteSelectedPerson()
        {
            // SelectedPerson removed from personRepository.
            personRepo.Remove(SelectedPerson.GetPersonId());

            // Remove person from PersonsVM, by using the SelectedPerson
            PersonsVM.Remove(SelectedPerson);
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if(handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Helper method for the event PersonsVMChanged; calls methods who are subscribed to the event.
        /// </summary>
        protected void OnPersonsVMChanged()
        {
            EventHandler personsVMChanged = PersonsVMChanged;
            if(personsVMChanged != null)
            {
                personsVMChanged(this, null);
            }
        }

        /// <summary>
        /// Calls methods subscribed to the event. Handlesnew person information from dialog. I think.
        /// </summary>
        /// <returns></returns>
        protected PersonEventArgs OnNewPersonRequested()
        {
            PersonEventArgs result = null;

            PersonEventHandler newPersonRequested = NewPersonRequested;
            if(newPersonRequested != null)
            {
                PersonEventArgs args = null;
                result = newPersonRequested(this, args);
            }

            return result;
        }
    }
}

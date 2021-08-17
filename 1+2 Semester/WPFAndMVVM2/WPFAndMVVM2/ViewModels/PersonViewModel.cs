using System;
using System.Collections.Generic;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class PersonViewModel
    {
        // Informationer om præcist denne opsætning kan findes ved dokumentet Ex28-WPFAndMVVM2
        
        private Person person;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        /// <summary>
        /// Constructor for PersonViewModel. Initializes all the members of the class.
        /// </summary>
        /// <param name="person">A valid person object.</param>
        public PersonViewModel(Person person)
        {
            this.person = person;

            // Was told to "initialisere alle klassens medlemmer", so from my interpretation, I need to make sure all properties contain information.
            // And that information, we get from the person argument.
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
            Phone = person.Phone;
        }

        /// <summary>
        /// Returns the ID of the current person for this PVM.
        /// </summary>
        /// <returns></returns>
        public int GetPersonId()
        {
            return person.Id;
        }
    }
}

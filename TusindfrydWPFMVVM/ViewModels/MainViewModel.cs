using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TusindfrydWPFMVVM.Models;

namespace TusindfrydWPFMVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged 
    {
        /* Preface:
         * So yeah, the code is ugly as fuck, and it's convoluted and probably break the fucking layering purpose of MVVM...
         * But at least it works... sooe yeah. Well Create and edit works for now. */

        private FlowerRepository flowerRepo = new FlowerRepository();

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<FlowerViewModel> FlowersVM { get; set; }

        private FlowerViewModel selectedFlower;

        public FlowerViewModel SelectedFlower
        {
            get { return selectedFlower; }
            set { 
                selectedFlower = value;
            }
        }

        public MainViewModel()
        {
            FlowersVM = new ObservableCollection<FlowerViewModel>();

            foreach (Flower f in flowerRepo.GetAll())
            {
                FlowersVM.Add(new FlowerViewModel(f));
            }

            
        }

        public Flower GetCurrentFlower()
        {
            return flowerRepo.Get(selectedFlower.Name);
        }

        public void AddDefaultFlower(Flower f)
        {
            selectedFlower = new FlowerViewModel(flowerRepo.Add(f.Name, f.PicturePath, f.ProductionTime, f.HalfLifeTime, f.Size));

            FlowersVM.Add(selectedFlower);

            OnPropertyChanged("SelectedFlower");
        }

        public void DeleteSelectedFlower()
        {
            // Not set up yet.
        }

        public void UpdateFlower(Flower f)
        {
            // Update the flower repo
            flowerRepo.Update(f.Name, f.PicturePath, f.ProductionTime, f.HalfLifeTime, f.Size);

            // Need to update the FlowersVM
            FlowersVM[FlowersVM.IndexOf(selectedFlower)] = new FlowerViewModel(f);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if(handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TusindfrydWPFMVVM.Models
{
    public class Flower : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { 
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string picturePath;

        public string PicturePath
        {
            get { return picturePath; }
            set { 
                picturePath = value;
                OnPropertyChanged("PicturePath");
            }
        }

        private int productionTime;

        public int ProductionTime
        {
            get { return productionTime; }
            set { 
                productionTime = value;
                OnPropertyChanged("ProductionTime");
            }
        }

        private int halfLifeTime;

        public int HalfLifeTime
        {
            get { return halfLifeTime; }
            set { 
                halfLifeTime = value;
                OnPropertyChanged("HalfLifeTime");
            }
        }

        private int size;

        public int Size
        {
            get { return size; }
            set { 
                size = value;
                OnPropertyChanged("Size");
            }
        }






        public Flower(string name, string pp, int pt, int hlt, int fSize)
        {
            Name = name;
            PicturePath = pp;
            ProductionTime = pt;
            HalfLifeTime = hlt;
            Size = fSize;
        }

        public Flower() : this("Indtast Navn", "Indtast billedesti", 0, 0, 0)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

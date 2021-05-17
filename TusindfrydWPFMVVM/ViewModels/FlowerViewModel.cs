using System;
using System.Collections.Generic;
using System.Text;
using TusindfrydWPFMVVM.Models;

namespace TusindfrydWPFMVVM.ViewModels
{
    public class FlowerViewModel
    {
        private Flower _flower;
        public string Name { get; set; }

        public FlowerViewModel(Flower f)
        {
            _flower = f;
            Name = f.Name;
        }

        public string GetPP()
        {
            return _flower.PicturePath;
        }

        public int GetProductionTime()
        {
            return _flower.ProductionTime;
        }

        public int GetHalfLifeTime()
        {
            return _flower.HalfLifeTime;
        }

        public int GetSize()
        {
            return _flower.Size;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TusindfrydWPFMVVM.Models
{
    public class FlowerRepository
    {
        private List<Flower> _flowers = new List<Flower>();

        // Constructor
        public FlowerRepository()
        {

        }

        /// <summary>
        /// Add flower to flower list.
        /// </summary>
        public Flower Add(string name, string pp, int pt, int hl, int fSize)
        {
            Flower result = null;

            // Check the inpu
            if (!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(pp) &&
                pt > 0 &&
                hl > 0 &&
                fSize > 0)
            {
                result = new Flower(name, pp, pt, hl, fSize);

                // Add flower to list
                _flowers.Add(result);

            } else
                throw new ArgumentException("Incorrect arguments when adding flower.");

            return result;
        }

        /// <summary>
        /// Gets a flower with a specified name.
        /// </summary>
        public Flower Get(string name)
        {
            Flower result = null;
            foreach(Flower f in _flowers)
            {
                if(f.Name == name)
                {
                    result = f;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Returns the entire flowers list.
        /// </summary>
        public List<Flower> GetAll()
        {
            return _flowers;
        }


        public void Update(string name, string pp, int pt, int hl, int fSize)
        {
            // Find flower to update
            Flower foundFlower = this.Get(name);

            // Check if we found stuff
            if (foundFlower != null)
            {
                // Check values
                if (!string.IsNullOrEmpty(pp) &&
                    pt >= 0 &&
                    hl >= 0 &&
                    fSize >= 0)
                {
                    // Update the changed properties
                    if (foundFlower.Name != name)
                        foundFlower.Name = name;
                    if (foundFlower.PicturePath != pp)
                        foundFlower.PicturePath = pp;
                    if (foundFlower.ProductionTime != pt)
                        foundFlower.ProductionTime = pt;
                    if (foundFlower.HalfLifeTime != hl)
                        foundFlower.HalfLifeTime = hl;
                    if (foundFlower.Size != fSize)
                        foundFlower.Size = fSize;
                }
                else
                    throw new ArgumentException("Not all arguments for flower are valid.");
            }
            else
                throw new ArgumentException($"Flower with name {name} does not exist.");
        }
    }
}

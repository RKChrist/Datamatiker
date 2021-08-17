using System;
using System.Collections.Generic;
using System.Text;

namespace Ex16_MorgenGry
{
    public class Book : Merchandise, IValuable
    {
        public string Title { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Constructor for Book class. 
        /// </summary>
        /// <param name="itemId">ID of item.</param>
        /// <param name="title">Title of item.</param>
        /// <param name="price">Price of item.</param>
        public Book(string itemId, string title, double price)
        {
            base.ItemId = itemId;
            Title = title;
            Price = price;
        }

        // Overloaded constructors.
        public Book(string itemId, string title) : this(itemId, title, 0) { }
        public Book(string itemId) : this(itemId, "", 0) { }

        // Inherit from interface
        public double GetValue()
        {
            return Price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TFTHelper.Domain.Items
{
    public class Item
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Bonus { get; set; }
        /// <summary>
        /// Only for basic items
        /// </summary>
        public bool IsBasic { get; set; }
        /// <summary>
        /// Only for basic items
        /// </summary>
        public int Order { get; set; }
        /// <summary>
        /// Only for basic items
        /// </summary>
        public bool IsHiden { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

        public string ImagePath => $"/Resources/Images/Items/{Key}.png";

        public Item()
        {
            IsHiden = false;
            Order = 0;
            IsBasic = false;
        }
    }
}

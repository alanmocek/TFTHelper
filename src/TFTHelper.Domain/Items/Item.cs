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
        public bool IsBasic { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

        public string ImagePath => $"/Resources/Images/Items/{Key}.png";
    }
}

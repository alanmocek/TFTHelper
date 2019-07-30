using System;
using System.Collections.Generic;
using System.Text;

namespace TFTHelper.Domain.Items
{
    public class Recipe
    {
        public Item BaseItem { get; set; }
        public Item AdditionalItem { get; set; }
    }
}

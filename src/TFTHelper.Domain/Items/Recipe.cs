using System;
using System.Collections.Generic;
using System.Text;

namespace TFTHelper.Domain.Items
{
    public class Recipe
    {
        public Item AdditionalItem { get; set; }
        public Item ResultItem { get; set; }
    }
}

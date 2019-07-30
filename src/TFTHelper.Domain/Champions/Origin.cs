using System;
using System.Collections.Generic;
using System.Text;

namespace TFTHelper.Domain.Champions
{
    public class Origin
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<OriginBonus> Bonuses { get; set; }
    }
}

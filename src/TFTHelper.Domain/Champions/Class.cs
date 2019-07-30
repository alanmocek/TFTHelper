using System;
using System.Collections.Generic;
using System.Text;

namespace TFTHelper.Domain.Champions
{
    public class Class
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ClassBonus> Bonuses { get; set; }
    }
}

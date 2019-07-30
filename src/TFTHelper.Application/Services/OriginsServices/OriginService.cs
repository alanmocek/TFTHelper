using System;
using System.Collections.Generic;
using System.Text;
using TFTHelper.Domain.Champions;

namespace TFTHelper.Application.Services.OriginsServices
{
    public class OriginService : IOriginService
    {
        private List<Origin> origins;

        public OriginService()
        {
            InitializeOrigins();
        }

        private void InitializeOrigins()
        {
            origins = new List<Origin>()
            {
                new Origin()
                {
                    Name = "Demon",
                    Description = "costam",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            ChampionCount = 2,
                            Bonus = "25% szansy na wypalenie many uderzonego wroga"
                        },
                        new OriginBonus()
                        {
                            ChampionCount = 4,
                            Bonus = "50% szansy na wypalenie many uderzonego wroga"
                        },
                        new OriginBonus()
                        {
                            ChampionCount = 6,
                            Bonus = "85% szansy na wypalenie many uderzonego wroga"
                        }
                    }
                }
            };
        }

        public ICollection<Origin> GetOrigins()
        {
            return origins;
        }
    }
}

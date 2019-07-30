using System;
using System.Collections.Generic;
using System.Linq;
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
                    Description = "Attacks from Demons have a chance to burn all of an enemy's mana and deal that much true damage.",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 2,
                            Bonus = "25% chance on hit to Mana Burn."
                        },
                        new OriginBonus()
                        {
                            Needed = 4,
                            Bonus = "50% chance on hit to Mana Burn."
                        },
                        new OriginBonus()
                        {
                            Needed = 6,
                            Bonus = "85% chance on hit to Mana Burn."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Dragon",
                    Description = "",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 2,
                            Bonus = "Dragons are immune to Magic damage."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Exile",
                    Description = "",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 1,
                            Bonus = "If an Exile has no adjacent allies at the start of combat, they gain a shield equal to a 100% max health."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Glacial",
                    Description = "On hit, Glacials have a chance to stun for 2s.",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 2,
                            Bonus = "20% chance."
                        },
                        new OriginBonus()
                        {
                            Needed = 4,
                            Bonus = "30% chance."
                        },
                        new OriginBonus()
                        {
                            Needed = 6,
                            Bonus = "45% chance."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Imperial",
                    Description = "Imperials deal Double Damage.",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 1,
                            Bonus = "1 random Imperial."
                        },
                        new OriginBonus()
                        {
                            Needed = 4,
                            Bonus = "All Imperials."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Noble",
                    Description = "Nobles grant +100 Armor and heal for 35 on hit.",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 1,
                            Bonus = "1 random ally."
                        },
                        new OriginBonus()
                        {
                            Needed = 6,
                            Bonus = "All allies."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Ninja",
                    Description = "Ninjas gain a percentage of Attack Damage.",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 1,
                            Bonus = "1 Ninja only: Ninja gains +40% Attack Damage."
                        },
                        new OriginBonus()
                        {
                            Needed = 4,
                            Bonus = "4 Ninjas: All Ninjas gain +60% Attack Damage."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Pirate",
                    Description = "",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 3,
                            Bonus = "Earn up to 4 additional gold after combat against another player (avg 1.6g per chest)."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Phantom",
                    Description = "",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 2,
                            Bonus = "Curse a random enemy at the start of combat, setting their HP to 100."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Robot",
                    Description = "",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 1,
                            Bonus = "Robots start combat at full mana."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Wild",
                    Description = "Attacks generate stacks of Fury (up to 5). Each stack of Fury grants 10% Attack Speed.",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 2,
                            Bonus = "Wild allies only."
                        },
                        new OriginBonus()
                        {
                            Needed = 4,
                            Bonus = "All allies."
                        }
                    }
                },
                new Origin()
                {
                    Name = "Yordle",
                    Description = "Attacks against ally Yordles have a chance to miss.",
                    Bonuses = new List<OriginBonus>()
                    {
                        new OriginBonus()
                        {
                            Needed = 3,
                            Bonus = "25% chance to miss."
                        },
                        new OriginBonus()
                        {
                            Needed = 6,
                            Bonus = "60% chance to miss."
                        }
                    }
                }
            };
        }

        public ICollection<Origin> GetOrigins()
        {
            return origins;
        }

        public ICollection<Origin> GetOriginsByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return GetOrigins();
            }

            var originsByName = origins.Where(c => c.Name.Contains(name)).ToList();

            return originsByName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TFTHelper.Domain.Champions;

namespace TFTHelper.Application.Services.ClassesServices
{
    public class ClassesService : IClassesService
    {
        private List<Class> classes;

        public ClassesService()
        {
            InitializeClasses();
        }

        private void InitializeClasses()
        {
            classes = new List<Class>()
            {
                new Class()
                {
                    Name = "Assassin",
                    Description = "Assassins leap to the farthest enemy at the start of combat and deal additional Critical Strike Damage.",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            Needed = 3,
                            Bonus = "+125% critical strike damage."
                        },
                        new ClassBonus()
                        {
                            Needed = 6,
                            Bonus = "+350% critical strike damage."
                        }
                    }
                },
                new Class()
                {
                    Name = "Blademaster",
                    Description = "Blademasters have a 35% chance to strike additional times each attack.",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            Needed = 3,
                            Bonus = "One additional strike"
                        },
                        new ClassBonus()
                        {
                            Needed = 6,
                            Bonus = "Two additional strikes"
                        }
                    }
                },
                new Class()
                {
                    Name = "Brawler",
                    Description = "Brawlers receive bonus maximum health.",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            Needed = 2,
                            Bonus = "+300 Bonus health."
                        },
                        new ClassBonus()
                        {
                            Needed = 4,
                            Bonus = "+700 Bonus health."
                        }
                    }
                },
                new Class()
                {
                    Name = "Elementalist",
                    Description = "Elementalists gain double mana from attacks.",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            Needed = 3,
                            Bonus = "At the start of combat, summon an Elemental. Elemental has 2200 health and 100 Attack Damage."
                        }
                    }
                },
                new Class()
                {
                    Name = "Gunslinger",
                    Description = "After attacking, Gunslingers have a 50% chance to fire additional attacks.",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            Needed = 2,
                            Bonus = "Attack another random enemy."
                        },
                        new ClassBonus()
                        {
                            Needed = 4,
                            Bonus = "Attack 2 additional random enemies in range."
                        }
                    }
                },
                new Class()
                {
                    Name = "Knight",
                    Description = "Knights block damage from basic attacks.",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            Needed = 2,
                            Bonus = "20 damage blocked."
                        },
                        new ClassBonus()
                        {
                            Needed = 4,
                            Bonus = "40 damage blocked."
                        },
                        new ClassBonus()
                        {
                            Needed = 6,
                            Bonus = "60 damage blocked."
                        }
                    }
                },
                new Class()
                {
                    Name = "Ranger",
                    Description = "Rangers have a chance to double their attack speed for the next 3s.",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            Needed = 2,
                            Bonus = "25% chance."
                        },
                        new ClassBonus()
                        {
                            Needed = 4,
                            Bonus = "65% chance."
                        },
                    }
                },
                new Class()
                {
                    Name = "Shapeshifter",
                    Description = "Shapeshifters gain bonus maximum Health when they transform.",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            Needed = 3,
                            Bonus = "+60% bonus max health."
                        }
                    }
                },
                new Class()
                {
                    Name = "Sorcerer",
                    Description = "Sorcerers gain double mana from attacking and allies have increased spell damage.",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            Needed = 3,
                            Bonus = "+45% Spell Damage."
                        },
                        new ClassBonus()
                        {
                            Needed = 6,
                            Bonus = "+100% Spell Damage."
                        }
                    }
                }
            };
        }

        public ICollection<Class> GetClasses()
        {
            return classes;
        }

        public ICollection<Class> GetClassesByName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return GetClasses();
            }

            var classesByName = classes.Where(c => c.Name.Contains(name)).ToList();

            return classesByName;
        }
    }
}

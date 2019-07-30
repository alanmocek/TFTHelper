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
                    Name = "Zabójca",
                    Description = "Costam",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            ChampionCount = 3,
                            Bonus = "+125% obrażeń z ataku krytycznego"
                        },
                        new ClassBonus()
                        {
                            ChampionCount = 6,
                            Bonus = "+350% obrażeń z ataku krytycznego"
                        }
                    }
                },
                new Class()
                {
                    Name = "Osiłek",
                    Description = "Osiłki zyskują dodatkowe maksylane zdrowie",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            ChampionCount = 2,
                            Bonus = "300 punktów dodatkowego zdrowia"
                        },
                        new ClassBonus()
                        {
                            ChampionCount = 4,
                            Bonus = "700 punktów dodatkowego zdrowia"
                        }
                    }
                },
                new Class()
                {
                    Name = "Rycerz",
                    Description = "Costam",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            ChampionCount = 1,
                            Bonus = "2x costam"
                        }
                    }
                },
                new Class()
                {
                    Name = "Strzelec",
                    Description = "Costam",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            ChampionCount = 1,
                            Bonus = "2x costam"
                        }
                    }
                },
                new Class()
                {
                    Name = "Czarodziej",
                    Description = "Costam",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            ChampionCount = 1,
                            Bonus = "2x costam"
                        }
                    }
                },
                new Class()
                {
                    Name = "Zmiennokształtny",
                    Description = "Costam",
                    Bonuses = new List<ClassBonus>()
                    {
                        new ClassBonus()
                        {
                            ChampionCount = 1,
                            Bonus = "2x costam"
                        }
                    }
                }
            };
        }

        public ICollection<Class> GetClasses()
        {
            return classes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TFTHelper.Domain.Items;

namespace TFTHelper.Application.Services.ItemsServices
{
    public class ItemService : IItemService
    {
        private List<Item> items;

        public ItemService()
        {
            InitializeItems();
        }

        private void InitializeItems()
        {
            items = new List<Item>()
            {
                new Item()
                {
                    Key = "bfsword",
                    Name = "B.F. Sword",
                    Bonus = "+20 Attack Damage.",
                    IsBasic = true,
                    Order = 1
                },
                new Item()
                {
                    Key = "needlesslylargerod",
                    Name = "Needlessly Large Rod",
                    Bonus = "+20% Spell Damage.",
                    IsBasic = true,
                    Order = 2
                },
                new Item()
                {
                    Key = "recurvebow",
                    Name = "Recurve Bow",
                    Bonus = "+20% Attack Speed.",
                    IsBasic = true,
                    Order = 3
                },
                new Item()
                {
                    Key = "tearofthegoddess",
                    Name = "Tear of the Goddess",
                    Bonus = "+20 Starting Mana.",
                    IsBasic = true,
                    Order = 4
                },
                new Item()
                {
                    Key = "chainvest",
                    Name = "Chain Vest",
                    Bonus = "+20 Armor.",
                    IsBasic = true,
                    Order = 5
                },
                new Item()
                {
                    Key = "negatroncloak",
                    Name = "Negatron Cloak",
                    Bonus = "+20 Magic Resist.",
                    IsBasic = true,
                    Order = 6
                },
                new Item()
                {
                    Key = "giantsbelt",
                    Name = "Giant's Bell",
                    Bonus = "+200 Health.",
                    IsBasic = true,
                    Order = 7
                },
                new Item()
                {
                    Key = "spatula",
                    Name = "Spatula",
                    Bonus = "It must do something...",
                    IsBasic = true,
                    Order = 8
                },
                new Item()
                {
                    Key = "forceofnature",
                    Name = "Force of Nature",
                    Bonus = "Gain + team size.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "bladeoftheruinedking",
                    Name = "Blade of the Ruined King",
                    Bonus = "Wearer is also a Blademaster.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "bloodthirster",
                    Name = "Bloodthirster",
                    Bonus = "Attacks heal for 50% of damage.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "cursedblade",
                    Name = "Cursed Blade",
                    Bonus = "Attacks have a 20% chance to Shrink (-1 enemy star, down to level 0).",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "darkin",
                    Name = "Darkin",
                    Bonus = "Wearer is also a Demon.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "dragonsclaw",
                    Name = "Dragon's Claw",
                    Bonus = "83% resistance to magic damage.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "frozenheart",
                    Name = "Frozen Heart",
                    Bonus = "Adjacent enemies lose 25% Attack Speed.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "frozenmallet",
                    Name = "Frozen Mallet",
                    Bonus = "Wearer is also a Glacial.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "guardianangel",
                    Name = "Guardian Angel",
                    Bonus = "Revives champ with 1000 HP after 2 seconds.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "guinsoosrageblade",
                    Name = "Guinsoo's Rageblade",
                    Bonus = "Attacks give 4% Attack Speed. Stacks infinitely.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "hextechgunblade",
                    Name = "Hextech Gunblade",
                    Bonus = "Heal for 33% of all damage dealt.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "hush",
                    Name = "Hush",
                    Bonus = "Attacks have a 50% chance to Silence.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "infinityedge",
                    Name = "Infinity Edge",
                    Bonus = "Critical Strikes deal +150% damage.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "ionicspark",
                    Name = "Ionic Spark",
                    Bonus = "Whenever an enemy casts a spell they take 200 true damage.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "knightsvow",
                    Name = "Knights Vow",
                    Bonus = "Wearer is also a Knight.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "locketoftheironsolari",
                    Name = "Locket of the Iron Solari",
                    Bonus = "On start of combat, allies 2 spaces to the left and right gain 200 shield.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "ludensecho",
                    Name = "Luden's Echo",
                    Bonus = "Deal 200 splash damage on ability hit.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "morellonomicon",
                    Name = "Morellonomicon",
                    Bonus = "Spells burn for 5% of max HP per second and disable healing.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "phantomdancer",
                    Name = "Phantom Dancer",
                    Bonus = "Wearer dodges all Critical Strikes.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "rabadonsdeathcap",
                    Name = "Rabadon's Deathcap",
                    Bonus = "Wearer's Ability Damage increased by 50%.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "rapidfirecannon",
                    Name = "Rapid Firecannon",
                    Bonus = "Attacks cannot be dodged. Attack Range is doubled.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "redbuff",
                    Name = "Red Buff",
                    Bonus = "Attacks burn for 13% of max HP over 5s and disable healing.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "redemption",
                    Name = "Redemption",
                    Bonus = "At 25% health heal all nearby allies for 1000 HP.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "runaanshurricane",
                    Name = "Runaan's Hurricane",
                    Bonus = "Attacks hit 1 additional enemy. This extra hit does 25% damage and applies on-hit effects.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "seraphsembrace",
                    Name = "Seraph's Embrace",
                    Bonus = "Regain 20 mana each time a spell is cast.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "spearofshojin",
                    Name = "Spear of Shojin",
                    Bonus = "After casting, gain 15% of max mana per attack.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "statikkshiv",
                    Name = "Statikk Shiv",
                    Bonus = "Every 3rd attack deals 100 splash magical damage to 3 enemies.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "swordbreaker",
                    Name = "Sword Breaker",
                    Bonus = "Attacks have a 25% to disarm.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "swordofthedivine",
                    Name = "Sword of the Divine",
                    Bonus = "Every 1s gain a 5% chance to gain 100% Critical Strike.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "thornmail",
                    Name = "Thornmail",
                    Bonus = "Reflect 100% of of physical damage mitigated as True Damage.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "titanichydra",
                    Name = "Titanic Hydra",
                    Bonus = "Attacks deal 10% of the wearer's max HP as splash.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "warmogsarmor",
                    Name = "Warmog's Armor",
                    Bonus = "Regenerate 6% max Health per second.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "youmuusghostblade",
                    Name = "Youmuu's Ghostblade",
                    Bonus = "Wearer is also an Assassin.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "yuumi",
                    Name = "Yuumi",
                    Bonus = "Wearer is also a Sorcerer.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "zekesherald",
                    Name = "Zeke's Herald",
                    Bonus = "On start of combat, allies 2 spaces to the left and right gain +15% Attack Speed.",
                    IsBasic = false
                },
                new Item()
                {
                    Key = "zephyr",
                    Name = "Zephyr",
                    Bonus = "On start of combat banish an enemy.",
                    IsBasic = false
                }
            };

            GetItemByKey("bfsword").Recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("bfsword"),
                    ResultItem = GetItemByKey("infinityedge")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("giantsbelt"),
                    ResultItem = GetItemByKey("zekesherald")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("recurvebow"),
                    ResultItem = GetItemByKey("swordofthedivine")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("chainvest"),
                    ResultItem = GetItemByKey("guardianangel")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("negatroncloak"),
                    ResultItem = GetItemByKey("bloodthirster")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("tearofthegoddess"),
                    ResultItem = GetItemByKey("spearofshojin")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("spatula"),
                    ResultItem = GetItemByKey("youmuusghostblade")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("needlesslylargerod"),
                    ResultItem = GetItemByKey("hextechgunblade")
                }
            }.OrderBy(r => r.AdditionalItem.Order).ToList();


            GetItemByKey("recurvebow").Recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("bfsword"),
                    ResultItem = GetItemByKey("swordofthedivine")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("recurvebow"),
                    ResultItem = GetItemByKey("rapidfirecannon")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("needlesslylargerod"),
                    ResultItem = GetItemByKey("guinsoosrageblade")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("tearofthegoddess"),
                    ResultItem = GetItemByKey("statikkshiv")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("chainvest"),
                    ResultItem = GetItemByKey("phantomdancer")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("negatroncloak"),
                    ResultItem = GetItemByKey("cursedblade")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("giantsbelt"),
                    ResultItem = GetItemByKey("titanichydra")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("spatula"),
                    ResultItem = GetItemByKey("bladeoftheruinedking")
                }
            };

            GetItemByKey("chainvest").Recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("bfsword"),
                    ResultItem = GetItemByKey("guardianangel")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("recurvebow"),
                    ResultItem = GetItemByKey("phantomdancer")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("needlesslylargerod"),
                    ResultItem = GetItemByKey("locketoftheironsolari")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("tearofthegoddess"),
                    ResultItem = GetItemByKey("frozenheart")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("chainvest"),
                    ResultItem = GetItemByKey("thornmail")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("negatroncloak"),
                    ResultItem = GetItemByKey("swordbreaker")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("giantsbelt"),
                    ResultItem = GetItemByKey("redbuff")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("spatula"),
                    ResultItem = GetItemByKey("knightsvow")
                }
            };

            GetItemByKey("negatroncloak").Recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("bfsword"),
                    ResultItem = GetItemByKey("bloodthirster")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("recurvebow"),
                    ResultItem = GetItemByKey("cursedblade")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("needlesslylargerod"),
                    ResultItem = GetItemByKey("ionicspark")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("tearofthegoddess"),
                    ResultItem = GetItemByKey("frozenheart")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("chainvest"),
                    ResultItem = GetItemByKey("thornmail")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("negatroncloak"),
                    ResultItem = GetItemByKey("swordbreaker")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("giantsbelt"),
                    ResultItem = GetItemByKey("redbuff")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("spatula"),
                    ResultItem = GetItemByKey("knightsvow")
                }
            };

            GetItemByKey("needlesslylargerod").Recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("bfsword"),
                    ResultItem = GetItemByKey("hextechgunblade")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("recurvebow"),
                    ResultItem = GetItemByKey("guinsoosrageblade")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("needlesslylargerod"),
                    ResultItem = GetItemByKey("rabadonsdeathcap")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("tearofthegoddess"),
                    ResultItem = GetItemByKey("ludensecho")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("chainvest"),
                    ResultItem = GetItemByKey("locketoftheironsolari")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("negatroncloak"),
                    ResultItem = GetItemByKey("ionicspark")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("giantsbelt"),
                    ResultItem = GetItemByKey("morellonomicon")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("spatula"),
                    ResultItem = GetItemByKey("yuumi")
                }
            };

            GetItemByKey("tearofthegoddess").Recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("bfsword"),
                    ResultItem = GetItemByKey("spearofshojin")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("recurvebow"),
                    ResultItem = GetItemByKey("statikkshiv")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("needlesslylargerod"),
                    ResultItem = GetItemByKey("ludensecho")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("tearofthegoddess"),
                    ResultItem = GetItemByKey("seraphsembrace")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("chainvest"),
                    ResultItem = GetItemByKey("frozenheart")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("negatroncloak"),
                    ResultItem = GetItemByKey("hush")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("giantsbelt"),
                    ResultItem = GetItemByKey("redemption")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("spatula"),
                    ResultItem = GetItemByKey("darkin")
                }
            };

            GetItemByKey("giantsbelt").Recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("bfsword"),
                    ResultItem = GetItemByKey("zekesherald")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("recurvebow"),
                    ResultItem = GetItemByKey("titanichydra")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("needlesslylargerod"),
                    ResultItem = GetItemByKey("morellonomicon")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("tearofthegoddess"),
                    ResultItem = GetItemByKey("redemption")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("chainvest"),
                    ResultItem = GetItemByKey("redbuff")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("negatroncloak"),
                    ResultItem = GetItemByKey("zephyr")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("giantsbelt"),
                    ResultItem = GetItemByKey("warmogsarmor")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("spatula"),
                    ResultItem = GetItemByKey("frozenmallet")
                }
            };

            GetItemByKey("spatula").Recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("bfsword"),
                    ResultItem = GetItemByKey("youmuusghostblade")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("recurvebow"),
                    ResultItem = GetItemByKey("bladeoftheruinedking")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("needlesslylargerod"),
                    ResultItem = GetItemByKey("yuumi")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("tearofthegoddess"),
                    ResultItem = GetItemByKey("darkin")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("chainvest"),
                    ResultItem = GetItemByKey("knightsvow")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("negatroncloak"),
                    ResultItem = GetItemByKey("runaanshurricane")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("giantsbelt"),
                    ResultItem = GetItemByKey("frozenmallet")
                },
                new Recipe()
                {
                    AdditionalItem = GetItemByKey("spatula"),
                    ResultItem = GetItemByKey("forceofnature")
                }
            };
        }

        private Item GetItemByKey(string key)
        {
            var item = items.SingleOrDefault(i => i.Key == key);
            return item;
        }

        public ICollection<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public ICollection<Item> GetItemsByBasicItems(List<Item> basicItems)
        {
            var itemsByBasicItems = items.Where(i => basicItems.Contains(i)).ToList();

            return itemsByBasicItems;
        }

        public ICollection<Item> GetBasicItems()
        {
            var basicItems = items.Where(i => i.IsBasic == true).ToList();

            return basicItems;
        }
    }
}

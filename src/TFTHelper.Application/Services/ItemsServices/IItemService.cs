using System;
using System.Collections.Generic;
using System.Text;
using TFTHelper.Domain.Items;

namespace TFTHelper.Application.Services.ItemsServices
{
    public interface IItemService
    {
        ICollection<Item> GetBasicItems();
        ICollection<Item> GetItems();
        ICollection<Item> GetItemsByBasicItems(List<Item> basicItems);
    }
}

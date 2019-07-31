using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TFTHelper.Application.Services.ContainerServices;
using TFTHelper.Domain.Items;

namespace TFTHelper.WindowsClient.ViewModels
{
    public class ItemsViewViewModel : ViewModelBase
    {
        public List<Item> SelectedItems { get; set; }

        public List<Item> BasicItems { get; set; }

        public List<Item> Items { get; set; }

        public ItemsViewViewModel()
        {
            BasicItems = ContainerService.ItemService.GetBasicItems().ToList();

            ChangeItemSelectionCommand = new RelayCommand(ChangeItemSelection);

            SelectedItems = new List<Item>();
            foreach(Item item in BasicItems)
            {
                SelectedItems.Add(item);
            }

            Items = ContainerService.ItemService.GetItemsByBasicItems(SelectedItems).ToList();
        }

        public ICommand ChangeItemSelectionCommand { get; set; }
        private void ChangeItemSelection(object x)
        {
            Item item = (Item)x;
            if(SelectedItems.Contains(item))
            {
                item.IsHiden = true;
                SelectedItems.Remove(item);
            }else
            {
                item.IsHiden = false;
                SelectedItems.Add(item);
            }

            var newList = new List<Item>();

            foreach(Item i in BasicItems)
            {
                newList.Add(i);
            }

            Items = ContainerService.ItemService.GetItemsByBasicItems(SelectedItems).ToList();
            ChangeProperty(nameof(Items));

            BasicItems = newList;

            ChangeProperty(nameof(BasicItems));
        }
    }
}

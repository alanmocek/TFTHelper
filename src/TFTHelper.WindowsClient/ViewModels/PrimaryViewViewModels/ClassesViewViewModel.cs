using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TFTHelper.Application.Services.ContainerServices;
using TFTHelper.Domain.Champions;

namespace TFTHelper.WindowsClient.ViewModels
{
    //TODO add namespace
    public class ClassesViewViewModel : ViewModelBase
    {
        public string SearchName { get; set; }

        public List<Class> Classes { get; set; } = new List<Class>();

        public ClassesViewViewModel()
        {
            Classes = ContainerService.ClassesService.GetClasses().ToList();

            SearchClassesByNameCommand = new RelayCommand(SearchClassesByName);
        }

        public ICommand SearchClassesByNameCommand { get; set; }

        private void SearchClassesByName(object x)
        {
            Classes = ContainerService.ClassesService.GetClassesByName(SearchName).ToList();
            ChangeProperty(nameof(Classes));
        }
    }
}

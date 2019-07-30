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
    public class OriginsViewViewModel : ViewModelBase
    {
        public string SearchName { get; set; }

        public List<Origin> Origins { get; set; }

        public OriginsViewViewModel()
        {
            Origins = ContainerService.OriginService.GetOrigins().ToList();

            SearchOriginsByNameCommand = new RelayCommand(SearchOriginsByName);
        }

        public ICommand SearchOriginsByNameCommand { get; set; }

        private void SearchOriginsByName(object x)
        {
            Origins = ContainerService.OriginService.GetOriginsByName(SearchName).ToList();
            ChangeProperty(nameof(Origins));
        }
    }
}

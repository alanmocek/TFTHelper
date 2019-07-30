using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFTHelper.Application.Services.ContainerServices;
using TFTHelper.Domain.Champions;

namespace TFTHelper.WindowsClient.ViewModels
{
    public class OriginsViewViewModel : ViewModelBase
    {
        public List<Origin> Origins { get; set; }

        public OriginsViewViewModel()
        {
            Origins = ContainerService.OriginService.GetOrigins().ToList();
        }
    }
}

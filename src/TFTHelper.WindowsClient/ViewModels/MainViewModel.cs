using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFTHelper.Application.Services.ClassesServices;
using TFTHelper.Application.Services.ContainerServices;

namespace TFTHelper.WindowsClient.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly PrimaryViewViewModel _primaryViewViewModel;

        private ViewModelBase currentViewViewModel;
        public ViewModelBase CurrentViewViewModel
        {
            get => currentViewViewModel;
            set
            {
                currentViewViewModel = value;
                ChangeProperty(nameof(CurrentViewViewModel));
            }
        }

        public MainViewModel()
        {
            ContainerService.Initialize();

            _primaryViewViewModel = new PrimaryViewViewModel();

            CurrentViewViewModel = _primaryViewViewModel;
        }
    }
}

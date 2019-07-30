using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TFTHelper.WindowsClient.ViewModels
{
    public class PrimaryViewViewModel : ViewModelBase
    {
        private readonly ClassesViewViewModel _classesViewViewModel;
        private readonly ItemsViewViewModel _itemsViewViewModel;
        private readonly OriginsViewViewModel _originsViewViewModel;

        private ViewModelBase currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                currentViewModel = value;
                ChangeProperty(nameof(CurrentViewModel));
            }
        }

        public PrimaryViewViewModel()
        {
            _classesViewViewModel = new ClassesViewViewModel();
            _itemsViewViewModel = new ItemsViewViewModel();
            _originsViewViewModel = new OriginsViewViewModel();
            
            CurrentViewModel = _classesViewViewModel;

            ChangeViewCommand = new RelayCommand(ChangeView);
        }

        public ICommand ChangeViewCommand { get; set; }
        private void ChangeView(object x)
        {
            string viewName = (string)x;

            switch (viewName)
            {
                case "classes":
                    {
                        CurrentViewModel = _classesViewViewModel;
                        break;
                    }
                case "items":
                    {
                        CurrentViewModel = _itemsViewViewModel;
                        break;
                    }
                case "origins":
                    {
                        CurrentViewModel = _originsViewViewModel;
                        break;
                    }
                default:
                    {
                        CurrentViewModel = _classesViewViewModel;
                        break;
                    }
            }

        }

    }
}

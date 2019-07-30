using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFTHelper.Application.Services.ContainerServices;
using TFTHelper.Domain.Champions;

namespace TFTHelper.WindowsClient.ViewModels
{
    //TODO add namespace
    public class ClassesViewViewModel : ViewModelBase
    {
        public List<Class> Classes { get; set; } = new List<Class>();

        public ClassesViewViewModel()
        {
            Classes = ContainerService.ClassesService.GetClasses().ToList();
        }
    }
}

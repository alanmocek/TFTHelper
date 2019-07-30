using System;
using System.Collections.Generic;
using System.Text;
using TFTHelper.Domain.Champions;

namespace TFTHelper.Application.Services.ClassesServices
{
    public interface IClassesService
    {
        ICollection<Class> GetClasses();

        ICollection<Class> GetClassesByName(string name);
    }
}

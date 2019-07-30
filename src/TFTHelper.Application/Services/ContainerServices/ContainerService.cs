using System;
using System.Collections.Generic;
using System.Text;
using TFTHelper.Application.Services.ClassesServices;
using TFTHelper.Application.Services.ItemsServices;
using TFTHelper.Application.Services.OriginsServices;

namespace TFTHelper.Application.Services.ContainerServices
{
    public static class ContainerService
    {
        public static IClassesService ClassesService { get; private set; }
        public static IOriginService  OriginService { get; private set; }
        public static IItemService ItemService { get; private set; }

        public static void Initialize()
        {
            ClassesService = new ClassesService();
            OriginService = new OriginService();
            ItemService = new ItemService();
        }
    }
}

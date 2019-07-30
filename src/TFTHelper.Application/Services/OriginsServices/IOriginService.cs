using System;
using System.Collections.Generic;
using System.Text;
using TFTHelper.Domain.Champions;

namespace TFTHelper.Application.Services.OriginsServices
{
    public interface IOriginService
    {
        ICollection<Origin> GetOrigins();
    }
}

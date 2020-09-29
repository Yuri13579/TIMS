using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TIMS.DTO;

namespace TIMS.Service.Interfaces
{
    public interface ISaleService
    {
        Task<List<ProductPortalDto>> GetPortalProducts();
    }
}

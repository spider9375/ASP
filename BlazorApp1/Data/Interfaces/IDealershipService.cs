using BlazorApp1.Data.ViewModels;
using System.Collections.Generic;

namespace BlazorApp1.Data.Interfaces
{
    public interface IDealershipService
    {
        public List<DealershipViewModel> GetDealershipDataTable();

        public void Add(Models.DealershipModel model);

        public void Add(List<Models.DealershipModel> models);

        public List<CarsTableViewModel> GetCarsDataTableData(int dealershipId);
    }
}

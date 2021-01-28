using System.Collections.Generic;
using BlazorApp1.Data.Models;

namespace BlazorApp1.Data.Interfaces
{
    public interface IRegionService
    {
        NomModel Get(int id);
        int Create(NomModel model);
        void Update(NomModel model);
        void Delete(int id);
        List<NomModel> GetDataTableItems();
        List<OptionItemModel> GetOptionItems();
    }
}

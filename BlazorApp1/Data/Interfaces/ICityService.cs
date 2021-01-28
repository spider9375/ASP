using System.Collections.Generic;
using BlazorApp1.Data.Models;
using BlazorApp1.Data.ViewModels;

namespace BlazorApp1.Data.Interfaces
{
    public interface ICityService
    {
        public CityModel Get(int id);
        public int Create(CityModel model);
        public void Update(CityModel model);

        public void Delete(int id);
        public List<CityViewModel> GetDataTableItems();
        public List<OptionItemModel> GetOptionItems();
    }
}

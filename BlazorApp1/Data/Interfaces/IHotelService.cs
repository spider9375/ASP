using System.Collections.Generic;
using BlazorApp1.Data.Models;
using BlazorApp1.Data.ViewModels;

namespace BlazorApp1.Data.Interfaces
{
    public interface IHotelService
    {
        public HotelModel Get(int id);
        public int Create(HotelModel model);
        public void Update(HotelModel model);
        public void Delete(int id);
        public List<HotelViewModel> GetDataTableItems(int? regionId);
    }
}

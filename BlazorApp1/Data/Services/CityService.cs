using System.Collections.Generic;
using System.Linq;
using BlazorApp1.Data.DB;
using BlazorApp1.Data.Interfaces;
using BlazorApp1.Data.Models;
using BlazorApp1.Data.ViewModels;

namespace BlazorApp1.Data.Services
{
    public class CityService : ICityService
    {
        private readonly HotelsContext dbContext;

        public CityService(HotelsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public CityModel Get(int id)
        {
            var entity = this.dbContext.Cities.Find(id);
            var result = new CityModel
            {
                Id = entity.Id,
                Name = entity.Name,
                RegionId = entity.RegionId,
            };

            return result;
        }
        public int Create(CityModel model)
        {
            var entity = this.dbContext.Cities.Create();
            entity.RegionId = model.RegionId;
            entity.Name = model.Name;

            this.dbContext.Cities.Add(entity);
            this.dbContext.SaveChanges();

            return entity.Id;
        }

        public void Update(CityModel model)
        {
            var entity = this.dbContext.Cities.Find(model.Id);

            if (entity == null)
            {
                return;
            }

            entity.RegionId = model.RegionId;
            entity.Name = model.Name;

            this.dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.dbContext.Cities.Find(id);

            if (entity == null)
            {
                return;
            }

            this.dbContext.Cities.Remove(entity);
            this.dbContext.SaveChanges();
        }

        public List<CityViewModel> GetDataTableItems()
        {
            return this.dbContext.Cities.Select(x => new CityViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Region = x.Region.Name,
            })
            .ToList();
        }

        public List<OptionItemModel> GetOptionItems()
        {
            var result = this.dbContext.Cities
                .Select(x => new OptionItemModel()
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToList();

            return result;
        }
    }
}

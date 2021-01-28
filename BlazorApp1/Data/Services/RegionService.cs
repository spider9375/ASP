using System.Collections.Generic;
using System.Linq;
using BlazorApp1.Data.Interfaces;
using BlazorApp1.Data.Models;

namespace BlazorApp1.Data.Services
{
    public class RegionService : IRegionService
    {
        private readonly HotelsContext dbContext;

        public RegionService(HotelsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public NomModel Get(int id)
        {
            var entity = this.dbContext.Regions.Find(id);
            var result = new NomModel
            {
                Id = entity.Id,
                Name = entity.Name,
            };

            return result;
        }

        public int Create(NomModel model)
        {
            var entity = this.dbContext.Regions.Create();
            entity.Name = model.Name;

            this.dbContext.Regions.Add(entity);
            this.dbContext.SaveChanges();

            return entity.Id;
        }

        public void Update(NomModel model)
        {
            var entity = this.dbContext.Regions.Find(model.Id);

            if (entity == null)
            {
                return;
            }

            entity.Name = model.Name;

            this.dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.dbContext.Regions.Find(id);

            if (entity == null)
            {
                return;
            }

            this.dbContext.Regions.Remove(entity);
            this.dbContext.SaveChanges();
        }

        public List<NomModel> GetDataTableItems()
        {
            return this.dbContext.Regions.Select(x => new NomModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .ToList();
        }

        public List<OptionItemModel> GetOptionItems()
        {
            return this.dbContext.Regions.Select(x => new OptionItemModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .ToList();
        }
    }
}

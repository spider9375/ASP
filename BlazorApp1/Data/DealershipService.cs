using BlazorApp1.Data.Interfaces;
using BlazorApp1.Data.ViewModels;
using Car_Dealership;
using Car_Dealership.Models;
using Car_Dealership.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace BlazorApp1.Data
{
    public class DealershipService : IDealershipService
    {
        private readonly DealershipContext dbContext;
        private readonly IMappingService mappingService;

        public DealershipService(IMappingService mappingService, DealershipContext context)
        {
            this.dbContext = context;
            this.mappingService = mappingService;
        }

        public void Add(Models.DealershipModel model)
        {
            var entity = this.mappingService.ModelToEntity(model);

            this.dbContext.Dealerships.Add(entity);
            this.dbContext.SaveChanges();
        }

        public void Add(List<Models.DealershipModel> models)
        {
            throw new NotImplementedException();
        }

        public List<CarsTableViewModel> GetCarsDataTableData(int dealershipId)
        {
            var result = this.dbContext.Dealerships.FirstOrDefault(x => x.Id == dealershipId)
                ?.Cars.Select(car => new CarsTableViewModel()
                {
                    Id = car.Id,
                    Manufacturer = car.ManufactureDetails.Manufacturer,
                    EngineType = car.EngineDetails.EngineType,
                    EngineVolume = car.EngineDetails.EngineVolume,
                    Model = car.ManufactureDetails.Model,
                    Year = car.ManufactureDetails.Year
                })
                .ToList();

            return result;
        }

        public List<DealershipViewModel> GetDealershipDataTable()
        {
            var result = this.dbContext.Dealerships
                .Select(x => new DealershipViewModel
                {
                    Id = x.Id,
                    Address = x.Address,
                })
                .ToList();

            return result;
        }
    }
}

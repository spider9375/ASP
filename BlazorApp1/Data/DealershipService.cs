using BlazorApp1.Data.Interfaces;
using BlazorApp1.Data.ViewModels;
using Car_Dealership;
using Car_Dealership.Models;
using Car_Dealership.Models.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Xml;
using System.Xml.Schema;

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

        public void Delete(int id)
        {
            var entity = this.dbContext.Dealerships.Find(id);

            if (entity != null)
            {
                entity.Cars.ToList().ForEach(car =>
                {
                    this.dbContext.EngineDetails.Remove(car.EngineDetails);
                    this.dbContext.ManufactureDetails.Remove(car.ManufactureDetails);
                    this.dbContext.TransmissionsDetails.Remove(car.TransmissionDetails);
                    this.dbContext.VisualDetails.Remove(car.VisualDetails);
                    this.dbContext.Tires.Remove(car.Wheels.Tires);
                    this.dbContext.Rims.Remove(car.Wheels.Rims);
                    this.dbContext.Wheels.Remove(car.Wheels);
                    this.dbContext.Cars.Remove(car);
                });

                this.dbContext.Dealerships.Remove(entity);
                this.dbContext.SaveChanges();
            }
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

        public DealershipViewModel GetDealershipDetails(int dealershipId)
        {
            var entity = this.dbContext.Dealerships.Find(dealershipId);

            return new DealershipViewModel
            {
                Id = entity.Id,
                Address = entity.Address,
            };
        }

        public XmlSchemaSet GetSchemaSet()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            var schema = this.dbContext.Schemas.FirstOrDefault();

            if (schema != null)
            {
                var xmlReader = XmlReader.Create(new StringReader(System.Text.Encoding.UTF8.GetString(schema.Content)));
                schemas.Add(@"https://www.w3schools.com", xmlReader);
            }

            return schemas;
        }

        public XmlReader UploadSchema(MemoryStream stream)
        {
            byte[] byteArray = stream.ToArray();
            

            var entity = new DB.Schema()
            {
                Content = byteArray,
            };

            var exising = this.dbContext.Schemas.FirstOrDefault();

            if (exising != null)
            {
                this.dbContext.Schemas.Remove(exising);

            }
            this.dbContext.Schemas.Add(entity);
            this.dbContext.SaveChanges();

            string str = System.Text.Encoding.UTF8.GetString(byteArray);

            var result = XmlReader.Create(new StringReader(str));

            return result;
        }
    }
}

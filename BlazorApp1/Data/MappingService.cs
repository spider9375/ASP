using BlazorApp1.Data.Interfaces;
using BlazorApp1.Data.Models;
using Car_Dealership.Models.DB;
using System.Linq;

namespace BlazorApp1.Data
{
    public class MappingService : IMappingService
    {
        public Models.DealershipModel EntityToModel(Dealership entity)
        {
            return new Models.DealershipModel()
            {
                Address = entity.Address,
                Cars = entity.Cars.Select(x => new CarModel()
                {
                    EngineDetails = new EngineDetailsModel()
                    {
                        EngineType = x.EngineDetails.EngineType,
                        EngineVolume = x.EngineDetails.EngineVolume,
                        HorsePower = x.EngineDetails.HorsePower,
                    },
                    ManufactureDetails = new ManufactureDetailsModel()
                    {
                        Manufacturer = x.ManufactureDetails.Manufacturer,
                        Model = x.ManufactureDetails.Model,
                        Year = x.ManufactureDetails.Year,
                    },
                    Transmission = new TransmissionDetailsModel()
                    {
                        GearCount = x.TransmissionDetails.GearCount,
                        TransmissionType = x.TransmissionDetails.TransmissionType,
                    },
                    VisualDetails = new VisualDetailsModel()
                    {
                        BodyType = x.VisualDetails.BodyType,
                        Color = x.VisualDetails.Color,
                        DoorCount = x.VisualDetails.DoorCount,
                        HasWing = x.VisualDetails.HasWing,
                    },
                    Wheels = new WheelModel()
                    {
                        Rims = new RimsModel()
                        {
                            Color = x.Wheels.Rims.Color,
                            Model = x.Wheels.Rims.Model,
                            RimBrand = x.Wheels.Rims.RimBrand,
                            Size = x.Wheels.Rims.Size,
                        },
                        Tires = new TireModel()
                        {
                            Diameter = x.Wheels.Tires.Diameter,
                            TireBrand = x.Wheels.Tires.TireBrand,
                            TireSeason = x.Wheels.Tires.TireSeason,
                            Width = x.Wheels.Tires.Width,
                        }
                    },
                    Price = x.Price,
                })
                .ToList()
            };
        }

        public Dealership ModelToEntity(Models.DealershipModel model)
        {
            return new Dealership()
            {
                Id = model.Id,
                Address = model.Address,
                Cars = model.Cars.Select(x => new Car()
                {
                    EngineDetails = new EngineDetails()
                    {
                        EngineType = x.EngineDetails.EngineType,
                        EngineVolume = x.EngineDetails.EngineVolume,
                        HorsePower = x.EngineDetails.HorsePower,
                    },
                    ManufactureDetails = new ManufactureDetails()
                    {
                        Manufacturer = x.ManufactureDetails.Manufacturer,
                        Model = x.ManufactureDetails.Model,
                        Year = x.ManufactureDetails.Year,
                    },
                    TransmissionDetails = new TransmissionDetails()
                    {
                        GearCount = x.Transmission.GearCount,
                        TransmissionType = x.Transmission.TransmissionType,
                    },
                    VisualDetails = new VisualDetails()
                    {
                        BodyType = x.VisualDetails.BodyType,
                        Color = x.VisualDetails.Color,
                        DoorCount = x.VisualDetails.DoorCount,
                        HasWing = x.VisualDetails.HasWing,
                    },
                    Wheels = new Wheels()
                    {
                        Rims = new Rims()
                        {
                            Color = x.Wheels.Rims.Color,
                            Model = x.Wheels.Rims.Model,
                            RimBrand = x.Wheels.Rims.RimBrand,
                            Size = x.Wheels.Rims.Size,
                        },
                        Tires = new Tires()
                        {
                            Diameter = x.Wheels.Tires.Diameter,
                            TireBrand = x.Wheels.Tires.TireBrand,
                            TireSeason = x.Wheels.Tires.TireSeason,
                            Width = x.Wheels.Tires.Width,
                        }
                    },
                    Price = x.Price,
                })
                .ToList()
            };
        }

        public Car_Dealership.Models.DealershipModel ModelToXml(Models.DealershipModel model)
        {
            return new Car_Dealership.Models.DealershipModel()
            {
                Address = model.Address,
                Cars = model.Cars.Select(x => new Car_Dealership.Models.CarModel()
                {
                    EngineDetails = new Car_Dealership.Models.EngineDetailsModel()
                    {
                        EngineType = x.EngineDetails.EngineType,
                        EngineVolume = x.EngineDetails.EngineVolume,
                        HorsePower = x.EngineDetails.HorsePower,
                    },
                    ManufactureDetails = new Car_Dealership.Models.ManufactureModel()
                    {
                        Manufacturer = x.ManufactureDetails.Manufacturer,
                        Model = x.ManufactureDetails.Model,
                        Year = x.ManufactureDetails.Year,
                    },
                    Transmission = new Car_Dealership.Models.TransmissionModel()
                    {
                        GearCount = x.Transmission.GearCount,
                        TransmissionType = x.Transmission.TransmissionType,
                    },
                    VisualDetails = new Car_Dealership.Models.VisualDetailsModel()
                    {
                        BodyType = x.VisualDetails.BodyType,
                        Color = x.VisualDetails.Color,
                        DoorCount = x.VisualDetails.DoorCount,
                        HasWing = x.VisualDetails.HasWing,
                    },
                    Wheels = new Car_Dealership.Models.WheelModel()
                    {
                        Rims = new Car_Dealership.Models.RimModel()
                        {
                            Color = x.Wheels.Rims.Color,
                            Model = x.Wheels.Rims.Model,
                            RimBrand = x.Wheels.Rims.RimBrand,
                            Size = x.Wheels.Rims.Size,
                        },
                        Tires = new Car_Dealership.Models.TireModel()
                        {
                            Diameter = x.Wheels.Tires.Diameter,
                            TireBrand = x.Wheels.Tires.TireBrand,
                            TireSeason = x.Wheels.Tires.TireSeason,
                            Width = x.Wheels.Tires.Width,
                        }
                    },
                    Price = x.Price,
                })
                .ToList()
            };
        }

        public Models.DealershipModel XmlToModel(Car_Dealership.Models.DealershipModel xml)
        {
            return new Models.DealershipModel()
            {
                Address = xml.Address,
                Cars = xml.Cars.Select(x => new CarModel()
                {
                    EngineDetails = new EngineDetailsModel()
                    {
                        EngineType = x.EngineDetails.EngineType,
                        EngineVolume = x.EngineDetails.EngineVolume,
                        HorsePower = x.EngineDetails.HorsePower,
                    },
                    ManufactureDetails = new ManufactureDetailsModel()
                    {
                        Manufacturer = x.ManufactureDetails.Manufacturer,
                        Model = x.ManufactureDetails.Model,
                        Year = x.ManufactureDetails.Year,
                    },
                    Transmission = new TransmissionDetailsModel()
                    {
                        GearCount = x.Transmission.GearCount,
                        TransmissionType = x.Transmission.TransmissionType,
                    },
                    VisualDetails = new VisualDetailsModel()
                    {
                        BodyType = x.VisualDetails.BodyType,
                        Color = x.VisualDetails.Color,
                        DoorCount = x.VisualDetails.DoorCount,
                        HasWing = x.VisualDetails.HasWing,
                    },
                    Wheels = new WheelModel()
                    {
                        Rims = new RimsModel()
                        {
                            Color = x.Wheels.Rims.Color,
                            Model = x.Wheels.Rims.Model,
                            RimBrand = x.Wheels.Rims.RimBrand,
                            Size = x.Wheels.Rims.Size,
                        },
                        Tires = new TireModel()
                        {
                            Diameter = x.Wheels.Tires.Diameter,
                            TireBrand = x.Wheels.Tires.TireBrand,
                            TireSeason = x.Wheels.Tires.TireSeason,
                            Width = x.Wheels.Tires.Width,
                        }
                    },
                    Price = x.Price,
                })
                .ToList()
            };
        }
    }
}

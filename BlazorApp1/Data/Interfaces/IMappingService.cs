using Car_Dealership.Models.DB;

namespace BlazorApp1.Data.Interfaces
{
    public interface IMappingService
    {
        Dealership ModelToEntity(Models.DealershipModel model);

        Models.DealershipModel EntityToModel(Dealership entity);

        Models.DealershipModel XmlToModel(Car_Dealership.Models.DealershipModel xml);

        Car_Dealership.Models.DealershipModel ModelToXml(Models.DealershipModel model);
    }
}

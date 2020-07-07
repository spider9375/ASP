using BlazorApp1.Data.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace BlazorApp1.Data.Interfaces
{
    public interface IDealershipService
    {
        public List<DealershipViewModel> GetDealershipDataTable();

        public DealershipViewModel GetDealershipDetails(int dealershipId);

        public void Add(Models.DealershipModel model);

        public void Add(List<Models.DealershipModel> models);

        public List<CarsTableViewModel> GetCarsDataTableData(int dealershipId);

        public XmlReader UploadSchema(MemoryStream stream);

        public XmlSchemaSet GetSchemaSet();

        public void Delete(int id);
    }
}

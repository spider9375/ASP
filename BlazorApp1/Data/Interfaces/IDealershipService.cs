using BlazorApp1.Data.Models;
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

        public DealershipModel Get(int id);

        public void Add(DealershipModel model);

        public void Edit(DealershipModel model);

        public void Add(List<Models.DealershipModel> models);

        public XmlReader UploadSchema(MemoryStream stream);

        public XmlSchemaSet GetSchemaSet();

        public void Delete(int id);
    }
}

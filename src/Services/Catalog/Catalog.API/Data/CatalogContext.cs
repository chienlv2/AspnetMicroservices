using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration confg)
        {
            var client = new MongoClient(confg.GetValue<string>("DatabaseSettings:ConnectionString"));
            var db = client.GetDatabase(confg.GetValue<string>("DatabaseSettings:DatabaseName"));

            Products = db.GetCollection<Product>(confg.GetValue<string>("DatabaseSettings:CollectionName"));
        }

        public IMongoCollection<Product> Products { get; set; }
    }
}

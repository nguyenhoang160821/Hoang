using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice3.Models
{
    public class EFStoreRespository : IStoreRepository
    {
        
        private StoreDbContext context;
        public EFStoreRespository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    

}
}

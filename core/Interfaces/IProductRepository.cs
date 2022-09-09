using core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetAllProductsAsync();

        Task<IReadOnlyList<ProductBrand>> GetAllProductBrandsAsync();

        Task<IReadOnlyList<ProductType>> GetAllProductTypesAsync();

    }
}

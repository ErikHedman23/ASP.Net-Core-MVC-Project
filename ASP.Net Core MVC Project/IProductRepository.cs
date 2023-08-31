using ASP.Net_Core_MVC_Project.Models;

namespace ASP.Net_Core_MVC_Project
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}

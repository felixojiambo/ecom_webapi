using ecom.Models;

namespace ecom.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        Product GetById(int id);

        void Insert(Product obj);

        void Update(Product obj);

        void Delete(int id);

        void Save();
    }
}
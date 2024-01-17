using Restart.Models;

namespace Restart
{
    public interface IITProductsRepository
    {
        public IEnumerable<ProductsIT> GetALLITProducts();
        public Product GetProductByMoves(int moves);
        public void UpdateProduct(Product prod);

        public void InsertProduct(Product productToInsert);

        public IEnumerable<DistributorsIT> GetDistributor();
    }
}

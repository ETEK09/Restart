using Restart.Models;

namespace Restart
{
    public interface IITProductsRepository
    {
        public IEnumerable<ITProducts> GetALLITProducts();
        public Product GetProductByMoves(int moves);
        public void UpdateProduct(Product prod);
    }
}

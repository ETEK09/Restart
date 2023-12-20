//using Dapper;
//using Restart;
//using Restart.Models;
//using System.Data;

//namespace Restart
//{
//    public class ITProductsRepository : IITProductsRepository
//    {
//        private readonly IDbConnection _conn;

//        public ITProductsRepository(IDbConnection conn)
//        {
//            _conn = conn;
//        }

//        public IEnumerable<ITProducts> GetALLProducts()
//        {
//            return _conn.Query<ITProducts>("SELECT * FROM ITProducts");
//        }
//    }

//}

using Dapper;
using Restart.Models;
using System.Data;

namespace Restart
{
    public class ITProductsRepository : IITProductsRepository
    {
        private readonly IDbConnection _conn;

        public ITProductsRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<ProductsIT> GetALLITProducts()
        {
            //return _conn.Query<ITProducts>("SELECT * FROM PRODUCT p INNER JOIN itproducts itp ON p.InventoryTag = itp.InventoryTag");

            return _conn.Query<ProductsIT>("SELECT * FROM productsit");
        }


        public void InsertITProducts(ProductsIT model)
        {
            string query = "INSERT INTO ITProducts (ProductName, DateAssigned) VALUES (@ProductName, @DateAssigned)";

            _conn.Execute(query, new { model.ProductName, DateAssigned = model.DateAssigned.Date });
        }

        //public Product GetITProduct(int moves)
        //{

        //    return _conn.QuerySingle<Product>("SELECT * FROM PRODUCT WHERE MOVES = @moves", new { moves = moves });

        //}

        public Product GetProductByMoves(int id)
        {
            //return _conn.QuerySingle<Product>("SELECT * FROM PRODUCT p INNER JOIN productsit itp ON p.InventoryTag = itp.InventoryTag WHERE MovesID = @id", new { id = id });

            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCT WHERE MovesID = @id", new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE product SET InventoryTag = @InventoryTag, Distributor = @Distributor, Custodian = @Custodian WHERE MovesID = @id",
     new { inventorytag = product.InventoryTag, distributor = product.Distributor, custodian = product.Custodian, id = product.MovesID });
        }

        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO products (INVENTORYTAG, DISTRIBUTOR, CUSTODIAN) VALUES (@inventorytag, @distributor, @custodian);",
                new { inventorytag = productToInsert.InventoryTag, distributor = productToInsert.Distributor, custodian = productToInsert.Custodian });
        }

       
       

        public IEnumerable<DistributorsIT> GetDistributor()
        {
            return _conn.Query<DistributorsIT>("SELECT * FROM Distributorsit;");
        }

        public Product AssignDistributor()
        {
            var distributorList = GetDistributor();
            var product = new Product();
            product.Distributor = distributorList;
            return product;
        }
    }
}




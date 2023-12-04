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
using System;
using System.Collections.Generic;
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

        public IEnumerable<ITProducts> GetALLITProducts()
        {
            //return _conn.Query<ITProducts>("SELECT * FROM PRODUCT p INNER JOIN itproducts itp ON p.InventoryTag = itp.InventoryTag");

            return _conn.Query<ITProducts>("SELECT * FROM itproducts");
        }


        public void InsertITProducts(ITProducts model)
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
            //return _conn.QuerySingle<Product>("SELECT * FROM PRODUCT p INNER JOIN itproducts itp ON p.InventoryTag = itp.InventoryTag WHERE MovesID = @id", new { id = id });

            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCT WHERE MovesID = @id", new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE product SET InventoryTag = @InventoryTag, ITDistributor = @ITDistributor, Custodian = @Custodian WHERE MovesID = @id",
     new { inventorytag = product.InventoryTag, itdistributor = product.ITDistributor, custodian = product.Custodian, id = product.MovesID });
        }
    }
}




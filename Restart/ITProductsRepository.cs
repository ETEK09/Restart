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
            return _conn.Query<ITProducts>("SELECT * FROM ITProducts");
        }

       
        public void InsertITProduct(ITProducts model)
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
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCT WHERE MovesID = @id", new { id = id });
        }


    }
}




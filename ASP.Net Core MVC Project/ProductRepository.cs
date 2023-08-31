﻿using ASP.Net_Core_MVC_Project.Models;
using Dapper;
using System.Data;

namespace ASP.Net_Core_MVC_Project
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}

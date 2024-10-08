using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries
{
    public static class ProductQuery
    {
        public static string GetAll => @"SELECT * FROM dbo.Products";
        
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Product_Review
{
    class ProductManagement
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopOfRecords(List<Review>Products)
        {
            var Records = (from Review in Products orderby Review.Rating descending select Review).Take(5);
            foreach(var product in Records)
            {
                Console.WriteLine("ProductMangement");
                Console.WriteLine("productsname" + product.ProductName + " " + "userID" + product.UserID + " " + " Rating" + product.Rating + "Review " + product.Product_Review);
            }
        }
    }
}

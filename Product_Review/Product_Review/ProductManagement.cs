using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Product_Review
{
   public class ProductManagement
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
     
        public void Retrive(List<Review> Products)
        {
            var Records = (from Review in Products where Review.ProductName == "1" || Review.ProductName == "4" || Review.ProductName == "15" && Review.Rating > 3 select Review.Rating);
            foreach (var products in Records)
            {
                Console.WriteLine("ProductNAme" + products.ProductName + " " + "ProductId" + products.UserID + "" + "ProductRating" + products.Rating + " " + "Product Review" + products.Product_Review);

            }
        }
    }
}

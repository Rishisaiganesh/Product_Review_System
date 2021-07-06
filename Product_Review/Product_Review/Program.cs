using System;
using System.Collections.Generic;

namespace Product_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product review");
            List<Review> list = new List<Review>()
            {
            new Review() { ProductName = "Shoes", UserID = 22, Rating = 10, Product_Review = "EXCELLENT" },
            new Review() { ProductName= "Scooty", UserID = 23, Rating = 9, Product_Review = "EXCELLENT" },
            new Review() { ProductName = "Bags", UserID = 24, Rating = 8, Product_Review = "EXCELLENT" },
            new Review() { ProductName = "SunGlacess", UserID = 25, Rating = 7.7, Product_Review = "GOOD" },
            new Review() { ProductName = "Bikes", UserID = 26, Rating = 7.5, Product_Review = "GOOD" },
            new Review() { ProductName = "BabyToys", UserID = 27, Rating = 7,Product_Review = "GOOD" },
            new Review() { ProductName = "TV", UserID = 28, Rating = 6.8, Product_Review = "AVERAGE" },
            new Review() { ProductName = "Mobails", UserID = 29, Rating = 6.5, Product_Review = "AVERAGE" },
            new Review() { ProductName = "Shirts", UserID = 30, Rating = 6, Product_Review = "AVERAGE" },
            new Review() { ProductName = "Sandles", UserID = 31, Rating = 5.5, Product_Review = "AVERAGE" },
             new Review() { ProductName = "PhotoFrame", UserID = 22, Rating = 10, Product_Review = "EXCELLENT" },
            new Review() { ProductName= "Cars", UserID = 23, Rating = 9, Product_Review = "EXCELLENT" },
            new Review() { ProductName = "WaterPurefier", UserID = 20, Rating = 8, Product_Review = "EXCELLENT" },
            new Review() { ProductName = "Skechers", UserID = 19, Rating = 7.7, Product_Review = "GOOD" },
            new Review() { ProductName = "Bottle", UserID = 16, Rating = 7.5, Product_Review = "GOOD" },
            new Review() { ProductName = "BabyToys", UserID = 17, Rating = 7,Product_Review = "GOOD" },
            new Review() { ProductName = "Healmets", UserID = 18, Rating = 6.8, Product_Review = "AVERAGE" },
            };
            foreach (var check in list)
            {
                Console.WriteLine("ProductName" + check.ProductName + " " + "UserID" + check.UserID + " " + "Rating" + check.Rating + " " + "Product_Review" + check.Product_Review);
            }
            {
                ProductManagement mangement = new ProductManagement();
                mangement.TopOfRecords(list);
            }

        }
    }
}

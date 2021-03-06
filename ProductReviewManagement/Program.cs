using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Product> products = new List<Product>();
            ProductReview.AddProductReview(products);
            Console.WriteLine("1. Adding a Prodcut Review In list");
            Console.WriteLine("2.Retrive Top Three records");
            Console.WriteLine("3.Retrive records whoes rating is greater than 3");
            Console.WriteLine("4.Retrieving count by Rating");
            Console.WriteLine("5.Retrive Id and Review");
            Console.WriteLine("6.Skip Top Five records");
            Console.WriteLine("7.Creating Table");
            Console.WriteLine("8.Retrive data using islike");
            Console.WriteLine("9.Find Average Rating");
            Console.WriteLine("10.Find Review of the product");
            Console.WriteLine("11.Retrive all data based on the User id");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ProductReview.AddProductReview(products);
                    break;
                case 2:
                    ProductReview.RetrieveTopThreeRecords(products);
                    break;
                case 3:
                    ProductReview.Retrieve(products);
                    break;
                case 4:
                    ProductReview.RetrieveCount(products);
                    break;
                case 5:
                    ProductReview.RetrieveIdAndReview(products);
                    break;
                case 6:
                    ProductReview.SkipRecords(products);
                    break;
                case 7:
                    ProductTable.AddDetails(products);
                    break;
                case 8:
                    ProductTable.RetrieveBasedOnIsLike(products);
                    break;
                case 9:
                    ProductTable.AverageRating(products);
                    break;
                case 10:
                    ProductTable.Review(products);
                    break;
                case 11:
                    ProductTable.BasedOnUserId(products);
                    break;
            }

        }
    }

}


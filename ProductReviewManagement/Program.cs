using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<ProductReview> products = new List<ProductReview>();
            Console.WriteLine("1. Adding a Prodcut Review In list");
            Console.WriteLine("2.Retrive Top Three records");
            Console.WriteLine("3.Retrive records whoes rating is greater than 3");
            Console.WriteLine("4.Retrieving count by Rating");
            Console.WriteLine("5.Retrive Id and Review");

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

            }
        }

    }
}

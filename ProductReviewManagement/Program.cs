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
            List<ProductReview> products = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Rating=7,Review="Good",isLike=true },
                new ProductReview(){ProductId=2,UserId=2,Rating=9,Review="Good",isLike=true },
                new ProductReview(){ProductId=3,UserId=3,Rating=5,Review="Bad",isLike=true },
                new ProductReview(){ProductId=4,UserId=4,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=5,UserId=5,Rating=9,Review="Good",isLike=true },
                new ProductReview(){ProductId=6,UserId=6,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=7,UserId=7,Rating=6,Review="Average",isLike=true },
                new ProductReview(){ProductId=8,UserId=8,Rating=9,Review="Good",isLike=true },
                new ProductReview(){ProductId=9,UserId=9,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=10,UserId=10,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=11,UserId=11,Rating=10,Review="Good",isLike=true },
                new ProductReview(){ProductId=12,UserId=12,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=13,UserId=13,Rating=9,Review="Good",isLike=true },
                new ProductReview(){ProductId=14,UserId=14,Rating=2,Review="Very Bad",isLike=true },
                new ProductReview(){ProductId=15,UserId=15,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=16,UserId=16,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=17,UserId=17,Rating=9,Review="Good",isLike=true },
                new ProductReview(){ProductId=18,UserId=18,Rating=7,Review="Good",isLike=true },
                new ProductReview(){ProductId=19,UserId=19,Rating=9,Review="Good",isLike=true },
                new ProductReview(){ProductId=20,UserId=20,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=21,UserId=21,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=22,UserId=23,Rating=9,Review="Good",isLike=true },
                new ProductReview(){ProductId=23,UserId=23,Rating=8,Review="Good",isLike=true },
                new ProductReview(){ProductId=24,UserId=24,Rating=6,Review="Average",isLike=true },
                new ProductReview(){ProductId=25,UserId=25,Rating=9,Review="Good",isLike=true },
            };

            foreach (var i in products)
            {
                Console.WriteLine("Product Id :" + i.ProductId + ", User Id :" + i.UserId + ", Rating :" + i.Rating + ", REview :" + i.Review);
            }
            ProductReview.RetrieveTopThreeRecords(products);
            ProductReview.Retrieve(products);

        }
        
    }
}

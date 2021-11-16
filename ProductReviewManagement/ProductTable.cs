using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    class ProductTable
    {
        public static DataTable AddDetails(List<Product> products)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserId");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");

            foreach (var i in products)
            {
                var row = table.NewRow();
                row["ProductId"] = i.ProductId;
                row["UserId"] = i.UserId;
                row["Rating"] = i.Rating;
                row["Review"] = i.Review;
                row["isLike"] = i.isLike;
                table.Rows.Add(row);
            }
            ViewTable(table);
            return table;
        }
        public static void ViewTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {

                foreach (var i in row.ItemArray)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public static int RetrieveBasedOnIsLike(List<Product> products)
        {
            int count = 0;
            DataTable table = AddDetails(products);
            var res = from t in table.AsEnumerable() where t.Field<bool>("isLike") == true select t;
            foreach (var i in res)
            {
                Console.WriteLine($"{i["isLike"]}");
                count++;
            }
            return count;
        }
        public static void AverageRating(List<Product> products)
        {
            DataTable table = AddDetails(products);
            double avg = (double)table.AsEnumerable().Average(x => x.Field<int>("Rating"));
            Console.WriteLine("Average of ratings of all products is ");
            Console.WriteLine(avg);
        }
        public static void Review(List<Product> products)
        {
            DataTable table = AddDetails(products);
            Console.WriteLine("Products with Average Review are ");
            var res = from product in table.AsEnumerable() where product.Field<string>("Review") == "Average" select product;
            foreach (var i in res)
            {
                Console.WriteLine($"{i["ProductId"]},{i["Review"]}");
            }
        }
        public static void BasedOnUserId(List<Product> products)
        {
            DataTable table = AddDetails(products);
            var res = from record in table.AsEnumerable() where record.Field<int>("UserId") == 10 orderby record.Field<int>("Rating") select record;
            Console.WriteLine("Products with userId 10 are");
            foreach (var i in res)
            {
                Console.WriteLine(".");
                Console.WriteLine($"{i["ProductId"]}");

            }
        }

    }
}

using System;
using System.Collections.Generic;
namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management!");
            ReviewManager review = new ReviewManager();
            List<ProductReview> list = new List<ProductReview>();
            Console.WriteLine("1.Add Product Reviews\n2.Retrieve Top three Rated Products\n3.Retrieve Rating Greater than Three\n4.Count the Review for ID\n5.Retrieve ProductID and Reviews\n6.Skip Top Five\n7.Create Data Table\n8.Count IsLike True\n9.Average Rating\n10.Count Reviews Contains Good");
            Console.WriteLine("Enter the option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    review.AddReviews();
                    break;
                case 2:
                    review.RetrieveTopThreeRated();
                    break;
                case 3:
                    review.RetrieveRatingGreaterThanThree();
                    break;
                case 4:
                    review.CountReviewUsingID();
                    break;
                case 5:
                    review.RetrieveProductIdAndReviews();
                    break;
                case 6:
                    review.SkipTopFiveRecords();
                    break;
                case 7:
                    review.CreateDataTable(list);
                    break;
                case 8:
                    review.CountIsLikeField();
                    break;
                case 9:
                    review.AverageRating();
                    break;
                case 10:
                    review.RetrivingListContainGood();
                    break;
                case 11:
                    review.RetriveTheRecordOfUserId(17);
                    break;
            }
        }
    }
}

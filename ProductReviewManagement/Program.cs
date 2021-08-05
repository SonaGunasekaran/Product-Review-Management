using System;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management!");
            ReviewManager review = new ReviewManager();
            review.AddReviews();
        }
    }
}

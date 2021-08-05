using System;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management!");
            ReviewManager review = new ReviewManager();
            Console.WriteLine("1.Add Product Reviews\n2.Retrieve Top three Rated Products");
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

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
    }
}

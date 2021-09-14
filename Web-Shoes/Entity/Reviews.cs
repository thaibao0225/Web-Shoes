using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class Reviews
    {
        public string review_id { set; get; }
        public string review_Comment { set; get; }
        public AppUser AppUserR { get; set; }
        public string review_UserId { set; get; }
        public List<ReviewInproduct> ReviewInproductR { get; set; }
        public List<SubReviewInReview> SubReviewInReview { get; set; }

        public DateTime review_UploadTime { set; get; }

    }
}

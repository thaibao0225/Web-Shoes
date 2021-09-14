using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Models
{
    public class ReviewModel
    {
        //Table review
        public string review_id { set; get; }
        public string review_Comment { set; get; }
        public string review_UserId { set; get; }
        public int review_ProductId { set; get; }
        public string review_UserName { set; get; }
        public DateTime review_UploadTime { set; get; }

        
        public List<SubreviewModel> review_SubreviewModelList { set; get; }

        //Option
        public int review_CountReview { set; get; }
        public int review_CountSubReview { set; get; }
    }
}

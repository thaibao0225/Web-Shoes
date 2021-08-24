using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Models
{
    public class ReviewModel
    {
        public int review_id { set; get; }
        public string review_Comment { set; get; }
        public string review_UserId { set; get; }
        public int review_ProductId { set; get; }
        public string review_UserName { set; get; }
        public DateTime review_UploadTime { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public partial class Post : Base
    {

        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public string PostContent { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsActive { get; set; }
    }
}

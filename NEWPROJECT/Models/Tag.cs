using System.ComponentModel.DataAnnotations;

namespace NEWPROJECT.Models
{
    public class Tag
    {
        public int Id{ get; set; }
        [StringLength(100)]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<TagBlog>? tagBlogs { get; set; }



    }
}

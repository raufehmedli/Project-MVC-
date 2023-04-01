using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace NEWPROJECT.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [StringLength(100)]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(100)]
        [MinLength(2)]
        [MaxLength(100)]

        public string Title { get; set; }
        [MaybeNull]
        [StringLength(500)]
       
        public string Description { get; set; }
        [StringLength(100)]
        public string Slug { get; set; }
        public List<TagBlog>? tagBlogs { get; set; }



    }
}

namespace NEWPROJECT.Models
{
    public class TagBlog
    {
        public int BlogId { get; set; }
        public int TagId { get; set; }

        public Tag? tag { get; set; }
        public Blog? blog { get; set; }


    }
}

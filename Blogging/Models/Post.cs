using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogging.Models
{
    // designate table and schema
    [Table("Post", Schema="dbo")]
    public partial class Post
    {
        [Key]
        [Required]
        public int PostId { get; set; }

        [Required]
        public int BlogId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Content { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }

        public virtual Blog Blog { get; set; }
    }
}

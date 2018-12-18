using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogging.Models
{
    // designate table and schema
    [Table("Blog", Schema="dbo")]
    public partial class Blog
    {
        public Blog()
        {
            Post = new HashSet<Post>();
        }

        [Key]
        [Required]
        public int BlogId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Url { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}

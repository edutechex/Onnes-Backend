using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onnes.DTO
{
    public class AddBlog
    {
        [NotMapped]
        public IFormFile imageFile { get; set; }
        public string content { get; set; }
    }
    public class DeleteBlog
    {
        public int Id { get; set; }
    }
}

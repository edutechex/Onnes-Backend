using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onnes.DTO
{
    public class AddJoinUs
    {
        public string mail { get; set; }
        [NotMapped]
        public IFormFile imageFile { get; set; }
        public string content { get; set; }
    }
    public class DeleteJoinUs
    { 
        public int Id { get; set; }
    }
}

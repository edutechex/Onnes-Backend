using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onnes.DTO
{
    public class AddAbout
    {
        [NotMapped]
        public IFormFile imageFile { get; set; }
        public string content { get; set; }
    }
    public class DeleteAbout
    {
        public int Id { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onnes.DTO
{
    public class AddOffering
    {
        public string content { get; set; }
        [NotMapped]
        public IFormFile imageFile { get; set; }
        public string title { get; set; }
    }
    public class DeleteOffering
    {
        public int Id { get; set; }
    }
}

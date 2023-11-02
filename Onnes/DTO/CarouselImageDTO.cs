using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onnes.DTO
{
    public class AddCarouselImage
    {
        [NotMapped]
        public IFormFile imageFile { get; set; }
        public string text { get; set; }
    }
    public class DeleteCarouselImage
    {
        public int Id { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onnes.Model
{
    public class CarouselImage
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public IFormFile imageFile { get; set; }
        public string image { get; set; }
        public string text { get; set; }
    }
}

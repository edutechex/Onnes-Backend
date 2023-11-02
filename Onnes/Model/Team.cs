using System.ComponentModel.DataAnnotations;

namespace Onnes.Model
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public string about { get; set; }
    }
}

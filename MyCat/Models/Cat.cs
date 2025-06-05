using System.ComponentModel.DataAnnotations;

namespace CatPetWebsite.Models
{
    public class Cat
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, 30)]
        public int Age { get; set; }

        public string Breed { get; set; }

        public string Color { get; set; }

        public string Gender { get; set; }

        public string Description { get; set; }
    }
}

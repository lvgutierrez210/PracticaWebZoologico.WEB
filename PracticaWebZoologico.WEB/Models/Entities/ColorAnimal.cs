using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaWebZoologico.WEB.Models.Entities
{
    public class ColorAnimal
    {
        [Key]
        public int ColorId { get; set; }
        [Required]
        public string NombreColor { get; set; }

        ////Propiedad de navegación a la entidad Animal
        //public virtual List<Animal> Animal { get; set; }
    }
}

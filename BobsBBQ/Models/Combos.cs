using System.ComponentModel.DataAnnotations.Schema;

namespace BobsBBQ.Models
{
    public class Combos
    {
        public int Id { get; set; }

        [ForeignKey("Entree")]
        public int EntreeId { get; set; }

        [ForeignKey("Side")]
        public int SideId { get; set; }

        [ForeignKey("Dessert")]
        public int DessertId { get; set; }
    }
}

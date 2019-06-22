using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CarsApplication.Models
{
    public class Car
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Marka { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Data produkcji")]
        public DateTime DataProdukcji { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Silnik { get; set; }

        [Required]
        [Display(Name = "Rodzaj paliwa")]
        [StringLength(50, MinimumLength = 3)]
        public string RodzajPaliwa { get; set; }

        [Required]
        public int Przebieg { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int Cena { get; set; }
    }

    public class CarsApplicationDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}

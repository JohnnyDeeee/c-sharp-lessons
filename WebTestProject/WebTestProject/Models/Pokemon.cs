using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebTestProject.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Pokemon Name")]
        [StringLength(20)]
        public string Name { get; set; }

        [Display(Name = "Trainer")]
        public int? TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        [Required]
        public PokemonType Type { get; set; }

        [Required]
        [Range(1,100, ErrorMessage = "Pokemon level is between 1 and 100")]
        public int Level { get; set; }
    }

    public enum PokemonType
    {
        FIRE,
        WATER,
        GRASS,
        ELECTRIC,
        DRAGON
    }
}
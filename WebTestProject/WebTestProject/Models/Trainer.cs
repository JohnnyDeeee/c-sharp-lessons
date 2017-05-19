using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTestProject.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Motto { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Pokemon> Pokemons { get; set; }
    }

    public enum Gender
    {
        MALE,
        FEMALE
    }
}
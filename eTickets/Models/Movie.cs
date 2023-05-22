﻿using eTickets.Data.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {

        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }

        //cinema
        //add foreign key
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }

        //producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }




    }

}

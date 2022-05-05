using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project_Games.Models
{
    public class Game
    {
        public int GameID {get; set;}
        public string GameName {get; set;}
        public string Rating {get; set;}
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}
        
    }
    public class Publisher
    {
        public int PublisherID {get; set;}
        public string  PublisherName{get; set;}
        public string PublisherLocation {get; set;}
        
    }
}
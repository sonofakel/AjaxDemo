using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AjaxDemo.Models
{
    [Table("Destinations")]
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        public Destination(string city, string country, int id = 0)
        {
            City = city;
            Country = country;
            Id = id;
        }

        public Destination() { }
    }
}

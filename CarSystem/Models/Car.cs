using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarSystem.Models
{
    public class Car
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Make { get; set; }

        [Required]
        [StringLength(255)]
        public string CarModel { get; set; }
        

        public CarType CarType { get; set; }
    }
}
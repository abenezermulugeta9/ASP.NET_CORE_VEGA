﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.API.Core.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public bool IsRegistered { get; set; }
        
        [Required]
        [StringLength(255)]
        public string ContactName { get; set; } 
        
        [StringLength(255)]
        public string ContactEmail { get; set; }
        
        [Required]
        [StringLength(255)]
        public string ContactPhone { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<VehicleFeature> Features { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public Vehicle()
        {
            Features = new Collection<VehicleFeature>();
            Photos = new Collection<Photo>();
        }
    }
}

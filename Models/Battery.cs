
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace FrancisVersion.Models
{
    public partial class Battery
    {

        public long id { get; set; }
        public long? building_id { get; set; }
        public string? status { get; set; }
        public long? employee_id { get; set; }
        public DateTime? date_of_commissioning { get; set; }
        public DateTime? date_of_last_inspection { get; set; }
        public string? information { get; set; }
        public string? notes { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string? typing { get; set; }
      
        public virtual Building? building { get; set; }

        // public virtual Employee? employee { get; set; }
    
        // public virtual ICollection<Column> columns { get; set; }

    }
}
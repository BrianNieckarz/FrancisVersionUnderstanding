using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace FrancisVersion.Models
{
    public partial class Column
    {

        public long id { get; set; }
        public long? battery_id { get; set; }
        public string? number_of_floors_served { get; set; }
        public string? status { get; set; }
        public string? information { get; set; }
        public string? notes { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string? typing { get; set; }

    }
}

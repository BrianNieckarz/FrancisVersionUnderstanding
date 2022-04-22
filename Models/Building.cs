using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace FrancisVersion.Models
{
    public partial class Building
    {
        
        public long id { get; set; }
        public long? customer_id { get; set; }
        public string? full_name_of_the_building_administrator { get; set; }
        public string? email_of_the_administrator_of_the_building { get; set; }
        public string? phone_number_of_the_building_administrator { get; set; }
        public string? full_name_of_the_technical_contact_for_the_building { get; set; }
        public string? technical_contact_email_for_the_building { get; set; }
        public string? technical_contact_phone_for_the_building { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public long? address_id { get; set; }

    }
}
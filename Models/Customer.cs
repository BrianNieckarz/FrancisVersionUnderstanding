using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace FrancisVersion.Models

{
    public partial class Customer
    {

        public long Id { get; set; }
        public long? UserId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyHeadquartersAddress { get; set; }
        public string? FullNameOfTheCompanyContact { get; set; }
        public string? CompanyContactPhone { get; set; }
        public string? EmailOfTheCompanyContact { get; set; }
        public string? CompanyDescription { get; set; }
        public string? FullNameOfServiceTechnicalAuthority { get; set; }
        public string? TechnicalAuthorityPhoneForService { get; set; }
        public string? TechnicalManagerEmailForService { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? CustomerCreationDate { get; set; }
        public long? AddressId { get; set; }

    }
}

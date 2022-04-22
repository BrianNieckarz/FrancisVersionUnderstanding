using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace FrancisVersion.Models

{
    public partial class User
    {

        public long Id { get; set; }
        public string Email { get; set; } = null!;
        public string EncryptedPassword { get; set; } = null!;
        public string? ResetPasswordToken { get; set; }
        public DateTime? ResetPasswordSentAt { get; set; }
        public DateTime? RememberCreatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}

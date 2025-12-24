using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim gerekli")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email gerekli")]
        [EmailAddress(ErrorMessage = "Geçerli bir email giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mesaj gerekli")]
        public string MessageText { get; set; }
    }
}
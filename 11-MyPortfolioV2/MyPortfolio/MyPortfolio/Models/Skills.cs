using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        public string TwitterUrl { get; set; }
        public string GithubUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string YoutubeUrl { get; set; }
    }
}
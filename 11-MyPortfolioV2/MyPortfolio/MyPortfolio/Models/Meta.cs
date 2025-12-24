using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class Meta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık alanı zorunludur.")]
        [StringLength(60, ErrorMessage = "Başlık en fazla 60 karakter olabilir.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama alanı zorunludur.")]
        [StringLength(160, ErrorMessage = "Açıklama en fazla 160 karakter olabilir.")]
        public string Description { get; set; }

        [StringLength(255, ErrorMessage = "URL en fazla 255 karakter olabilir.")]
        public string OgUrl { get; set; }
        [NotMapped]
        public HttpPostedFileBase ogImage { get; set; }
    }
}
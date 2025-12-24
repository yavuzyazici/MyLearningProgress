using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyPortfolio.Context
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext() : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Meta> Metas { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectHead> ProjectHeads { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
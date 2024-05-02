using Microsoft.EntityFrameworkCore;
using StepStepWebSiteApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepStepWebSiteApp.DataAccess.Concrete.Contexts;
public class StepStepWebSiteContext : DbContext
{
    //public StepStepWebSiteContext(DbContextOptions<StepStepWebSiteContext> options) : base(options)
    //{
        
    //}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
         "Data Source=AKINCENGIZ;initial catalog=StepStepWebSiteDB;Integrated Security=True;Trust Server Certificate=True;");
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialAccount> SocialAccounts { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}

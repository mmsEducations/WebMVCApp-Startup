using System.Data.Entity;
using WebApp.UI.Data.Entities;

namespace WebApp.UI.Data
{
    public class EducationDbContext : DbContext
    {
        public EducationDbContext() : base("name=localDbConstr")//Connection bilgilerimi set ediyrum 
        {
        }

        public DbSet<Student> Students { get; set; }//Student Entity'si bir database objesidir 
        public DbSet<Group> Groups { get; set; }
    }
}
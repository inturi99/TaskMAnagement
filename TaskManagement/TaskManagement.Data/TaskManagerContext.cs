using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Data.Mappings;
using TaskManagement.Model;

namespace TaskManagement.Data
{
  public class TaskManagerContext :DbContext
    {
      public TaskManagerContext()
          : base(@"Data Source=192.168.0.11\TECHNOID;Initial Catalog=TaskManagement;User ID=sa;Password=Design_20")
      {

      }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<IssueType> IssueTypes { get; set; }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new PriorityMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new IssueTypeMap());
        }
    }
}

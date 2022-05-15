using MySql.Data.MySqlClient;
using ScoreManagementSystem.Models;
using System.Data.Entity;

/*创建数据库连接类*/
namespace ScoreManagementSystem.App_Start
{
    [DbConfigurationType(typeof(MySqlConfiguration))]
    public class DatabaseContext : DbContext
    {
        public DbSet<Academy> Academys { get; set; }
        public DbSet<AcademyHealth> AcademyHealths { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<MyClass> MyClasses { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }

        public DatabaseContext() : base("DefaultConnection")
        {
            Database.CreateIfNotExists();
        }
    }
}
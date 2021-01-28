namespace WebApplication1.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class StudentModel : DbContext
    {
        // Your context has been configured to use a 'StudentModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebApplication1.Entity.StudentModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentModel' 
        // connection string in the application configuration file.
        public StudentModel()
            : base("name=StudentModel")
        {
            Database.SetInitializer(new DBStudentsInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Students { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
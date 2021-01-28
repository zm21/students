using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Entity
{
    public class DBStudentsInitializer : DropCreateDatabaseIfModelChanges<StudentModel>
    {
        protected override void Seed(StudentModel context)
        {
            base.Seed(context);
            List<Student> students = new List<Student>()
            {
            new Student{
                Id = 1,
                FullName = "Mykola Zaiets",
                Age = 17,
                Address = "Rivne",
                ImageUrl = "https://i.pinimg.com/originals/8b/6e/c6/8b6ec60427f9b17c1d9aaf4c415babe3.png"
            },
            new Student{
                Id = 2,
                FullName = "Sergiy Novak",
                Age = 18,
                Address = "Kiev",
                ImageUrl = "https://i.pinimg.com/originals/9d/9b/27/9d9b27a9cca99df1e51a0cd7e02a8de5.jpg"
            },
            new Student{
                Id = 3,
                FullName = "Ann Stepaniuk",
                Age = 17,
                Address = "Lviv",
                ImageUrl = "https://image.freepik.com/free-vector/smiling-girl-avatar_102172-32.jpg"
            }
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
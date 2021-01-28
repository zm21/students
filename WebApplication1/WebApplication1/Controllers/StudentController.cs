using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Entity;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private List<StudentViewModel> studentsModel;
        private static int lastId;
        private StudentModel studentModel;
        public StudentController()
        {
            studentsModel = new List<StudentViewModel>();
            studentsModel.Add(new StudentViewModel
            {
                Id = 1,
                FullName = "Mykola Zaiets",
                Age = 17,
                Address = "Rivne",
                ImageUrl = "https://i.pinimg.com/originals/8b/6e/c6/8b6ec60427f9b17c1d9aaf4c415babe3.png"
            });
            studentsModel.Add(new StudentViewModel
            {
                Id = 2,
                FullName = "Sergiy Novak",
                Age = 18,
                Address = "Kiev",
                ImageUrl = "https://i.pinimg.com/originals/9d/9b/27/9d9b27a9cca99df1e51a0cd7e02a8de5.jpg"
            });
            studentsModel.Add(new StudentViewModel
            {
                Id = 3,
                FullName = "Ann Stepaniuk",
                Age = 17,
                Address = "Lviv",
                ImageUrl = "https://image.freepik.com/free-vector/smiling-girl-avatar_102172-32.jpg"
            });
            lastId = 3;
            studentModel = new StudentModel();
        }

        [HttpGet]
        public ActionResult Index()
        {
            studentsModel = studentModel.Students.Select(st => new StudentViewModel()
            {
                Id = st.Id,
                FullName = st.FullName,
                Age = st.Age,
                Address = st.Address,
                ImageUrl = st.ImageUrl
            }).ToList();    
            return View(studentsModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddStudentViewModel model)
        {
            lastId++;
            studentModel.Students.Add(new Student
            { 
                FullName = model.FullName,
                Age = model.Age,
                Address = model.Address,
                ImageUrl = model.ImageUrl
            });
            studentModel.SaveChanges();
            return RedirectToAction(nameof(Index), "Student");
        }
        
    }
}
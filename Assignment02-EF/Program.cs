using Assignment02_EF.Context;
using Assignment02_EF.Entities;
using System;

namespace Assignment02_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Crud Operations
            using ITIDbContext dbcontext = new ITIDbContext();
            #region instructor
            #region Create
            //Instructor instructor1 = new Instructor()
            //{
            //    Name = "Ahmed",
            //    Bouns = 300,
            //    Salary = 5000,
            //    HoursRate = 10,
            //};
            //Instructor instructor2 = new Instructor()
            //{
            //    Name = "Mohamed",
            //    Address = "Cairo",
            //    Bouns = 400,
            //    Salary = 6000,
            //    HoursRate = 15,
            //};

            //dbcontext.Instructores.Add(instructor1);
            //dbcontext.Instructores.Add(instructor2);
            //Console.WriteLine(dbcontext.Entry(instructor1).State); 
            //dbcontext.SaveChanges();
            //Console.WriteLine(dbcontext.Entry(instructor2).State);
            #endregion

            #region Read
            //var instructor = dbcontext.Instructores;

            //foreach (var item in instructor)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var instructor = (from I in dbcontext.Instructores
            //                  where I.Id == 1
            //                  select I).First();

            //Console.WriteLine(instructor?.Name ?? "NotFound");



            #endregion

            #region Update
            //Console.WriteLine(dbcontext.Entry(instructor).State);//Unchanged
            //instructor.Name = "Abdo";
            //Console.WriteLine(dbcontext.Entry(instructor).State);//modified
            //dbcontext.SaveChanges();
            //Console.WriteLine(dbcontext.Entry(instructor).State);//Unchanged
            #endregion

            #region Delete
            //Console.WriteLine(dbcontext.Entry(instructor).State);//Unchanged
            // dbcontext.Remove(instructor);
            //Console.WriteLine(dbcontext.Entry(instructor).State);//modified
            //dbcontext.SaveChanges();
            //Console.WriteLine(dbcontext.Entry(instructor).State);//Unchanged
            #endregion

            #endregion

            #region Department
            #region Create
            //Department department1 = new Department()
            //{

            //    Name = "IT",
            //   HiringDate= DateTime.Now

            //};

            //Department department2 = new Department()
            //{

            //    Name = "CS",
            //    HiringDate = DateTime.Now
            //};
            //Console.WriteLine(dbcontext.Entry(department1).State);

            //dbcontext.Departmentes.Add(department1);
            //dbcontext.Departmentes.Add(department2);
            //Console.WriteLine(dbcontext.Entry(department1).State);
            //dbcontext.SaveChanges();
            //Console.WriteLine(dbcontext.Entry(department1).State);


            #endregion

            #region Read
            //var department = dbcontext.Departmentes;
            //foreach(var item in department)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var department = (from D in dbcontext.Departmentes
            //                  where D.Id == 50
            //                  select D).First();

            //Console.WriteLine(department?.Name ?? "Not Found");
            #endregion

            #region Update
            //  department.Name = "CS";
            #endregion

            #region Delete
            //dbcontext.Remove(department);
            #endregion
            #endregion

            #region Student
            #region Create
            //Student student1=new Student()
            //{
            //    FName = "Ahmed",
            //    LName = "Abdo",
            //    Address = "Cairo",
            //    Age = 20,
            //};
            //Student student2 = new Student()
            //{
            //    FName = "Mohamed",
            //    LName = "Ali",
            //    Address = "Giza",
            //    Age = 22,
            //};
            //Console.WriteLine(dbcontext.Entry(student1).State);
            //dbcontext.Studentes.Add(student1);
            //dbcontext.Studentes.Add(student2);
            //Console.WriteLine(dbcontext.Entry(student1).State);
            //dbcontext.SaveChanges();
            // Console.WriteLine(dbcontext.Entry(student1).State);
            #endregion

            #region Read
            //var student = dbcontext.Studentes;
            //foreach (var item in student)
            //{
            //    Console.WriteLine(item.FName);
            //}

            //var studnet = (from S in dbcontext.Studentes
            //               where S.Id == 1
            //               select S).First();
            //Console.WriteLine(studnet?.FName ?? "Not Found");
            #endregion

            #region Update
            //  studnet.Name = "Ali";
            #endregion

            #region Delete
            // dbcontext.Remove(studnet);
            #endregion
            #endregion

            #region Course
            #region Create
            //Course course1 = new Course()
            //{
            //    Name = "C#",
            //    Discripition = "C# Beginner",
            //    Duration = 10,
            //};

            //Course course2 = new Course()
            //{
            //    Name = "Java",
            //    Discripition = "Java Beginner",
            //    Duration = 15,
            //};
            //Console.WriteLine(dbcontext.Entry(course1).State);
            //dbcontext.Courses.Add(course1);
            //dbcontext.Courses.Add(course2);
            //Console.WriteLine(dbcontext.Entry(course1).State);

            //dbcontext.SaveChanges();
            //Console.WriteLine(dbcontext.Entry(course1).State);

            #endregion

            #region Read
            //var course = dbcontext.Courses;
            //foreach(var item in course)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var course = (from C in dbcontext.Courses
            //              where C.Id == 1
            //              select C).First();
            // Console.WriteLine(course.Name);
            #endregion

            #region Update
            // course.Name = "C++";
            #endregion

            #region Delete
            // dbcontext.Remove(course);
            #endregion
            #endregion

            #region Topic
            #region Create
            //Topic topic1 = new Topic()
            //{
            //    Name = "OOP",
            //};
            //Topic topic2 = new Topic()
            //{
            //    Name = "Data Structure",
            //};
            //Console.WriteLine(dbcontext.Entry(topic1).State);
            //dbcontext.Set<Topic>().Add(topic1);
            //dbcontext.Set<Topic>().Add(topic2);
            //Console.WriteLine(dbcontext.Entry(topic1).State);
            //dbcontext.SaveChanges();
            //Console.WriteLine(dbcontext.Entry(topic1).State);
            #endregion

            #region Read
            //var topic= dbcontext.Topices;
            //foreach(var item in topic)
            //{
            //    Console.WriteLine(item.Name);
            //};

            //var topic = (from t in dbcontext.Topices
            //             where t.id == 1
            //             select t).First();
            //Console.WriteLine(topic?.Name ?? "Not Found");
            #endregion

            #region Update
            //topic.Name = "Algorithm";
            #endregion

            #region Delete
            //dbcontext.Remove(topic);
            #endregion
            #endregion

            #region StudentCourse
            #region Create
            //StudentCourse studentCourse1 = new StudentCourse()
            //{
            //    StudentId = 1,
            //    CourseId = 1,
            //    grade = 90,
            //};
            //StudentCourse studentCourse2 = new StudentCourse()
            //{
            //    StudentId = 2,
            //    CourseId = 2,
            //    grade = 80,
            //};
            //Console.WriteLine(dbcontext.Entry(studentCourse1).State);
            //dbcontext.Set<StudentCourse>().Add(studentCourse1);
            //dbcontext.Set<StudentCourse>().Add(studentCourse2);
            //Console.WriteLine(dbcontext.Entry(studentCourse1).State);
            //dbcontext.SaveChanges();
            //Console.WriteLine(dbcontext.Entry(studentCourse1).State);
            #endregion

            #region Read
            //var studentCourse = dbcontext.Set<StudentCourse>();
            //foreach (var item in studentCourse)
            //{
            //    Console.WriteLine(item.grade);
            //}

            //var studentCourse = (from SC in dbcontext.Set<StudentCourse>()
            //                     where SC.StudentId == 1
            //                     select SC).First();
            #endregion

            #region Update
           // studentCourse.Grade = 95;
            #endregion

            #region Delete
           // dbcontext.Remove(studentCourse);
            #endregion
            #endregion

            #endregion


        }
    }
}

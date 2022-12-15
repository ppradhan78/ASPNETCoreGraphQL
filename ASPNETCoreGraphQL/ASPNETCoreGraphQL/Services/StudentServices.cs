using ASPNETCoreGraphQL.Models;
using System;
using System.Collections.Generic;

namespace ASPNETCoreGraphQL.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly List<Student>  studentList =new List<Student>();
        public StudentServices()
        {
            studentList.Add(new Student {StudentId=1,Name="Scott",DateOfBirth="11/12/2000" ,Email="Scott@gmail.com"});
            studentList.Add(new Student { StudentId = 2, Name = "King", DateOfBirth = "10/03/1980", Email = "King@gmail.com" });
            studentList.Add(new Student { StudentId = 3, Name = "Black", DateOfBirth = "10/03/1990", Email = "Black@gmail.com" });

        }
        public List<Student> GetList()
        {
            return studentList;
        }
    }
}

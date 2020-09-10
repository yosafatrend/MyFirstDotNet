using FirstWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF.Repository
{
    public class StudentRepo
    {
        public List<Student> PrintStudents()
        {
            var studentList = new List<Student>();
            studentList.Add(new Student
            {
                Nis = 15236,
                Name = "Midoriya",
                Email = "midoriyadeku@gmail.com"
            });

            studentList.Add(new Student
            {
                Nis = 15238,
                Name = "Yuno",
                Email = "yunogazai@gmail.com"
            });

            studentList.Add(new Student
            {
                Nis = 15231,
                Name = "Mimosa",
                Email = "astamimosa@gmail.com"
            });

            studentList.Add(new Student
            {
                Nis = 15239,
                Name = "Uraraka",
                Email = "urarakaocha@gmail.com"
            });

            studentList.Add(new Student
            {
                Nis = 15234,
                Name = "Bakugou",
                Email = "bakudeku@gmail.com"
            });

            return studentList;
        }
    }
}

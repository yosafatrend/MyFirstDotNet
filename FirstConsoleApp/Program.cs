using FirstWPF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentRepo = new StudentRepo();
            var listStudent = studentRepo.PrintStudents();

            foreach(var student in listStudent)
            {
                Console.WriteLine("Nama : " + student.Name + "\n Email : " + student.Email + "\n Nis : " + student.Nis);
            }
            Console.ReadKey();
        }
    }
}

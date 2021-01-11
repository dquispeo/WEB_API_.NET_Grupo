using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductoService
    {
        public List<Producto> Get()
        {
            List<Producto> students = null;
            using (var context = new SchoolContext())
            {
                //students = context.Students.ToList();
            }
            return students;
        }

        public Producto GetById(int ID)
        {
            Producto student = null;
            using (var context = new SchoolContext())
            {
                //student = context.Students.Find(ID);
            }
            return student;
        }

        public void Insert(Producto student)
        {
            using (var context = new SchoolContext())
            {
                //context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public void Update(Producto student, int ID)
        {
            using (var context = new SchoolContext())
            {
                //var studentNew = context.Students.Find(ID);
                //studentNew.studentName = student.studentName;
                //studentNew.studentAddress = student.studentAddress;
                //studentNew.studentLastName = student.studentLastName;
                //studentNew.studentCode = student.studentCode;
                //studentNew.startDate = student.startDate;
                //student.EnrollmentDate = student.EnrollmentDate;
                context.SaveChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var context = new SchoolContext())
            {
               // var student = context.Students.Find(ID);
                //context.Students.Remove(student);
                //context.SaveChanges();
            }
        }

    }
}

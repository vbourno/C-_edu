using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student4App
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public Address? MyAdress { get; set; }

        public Student GetCopyReference()
        {
            return this;
        }

        public Student GetShallowCopy()
        {
            return (Student)MemberwiseClone();
        }

        public Student GetDeepCopy()
        {
            Student student = (Student)MemberwiseClone();
            student.MyAdress = new()
            {
                Street = MyAdress?.Street,
                Number = MyAdress?.Number,
                ZipCode = MyAdress?.ZipCode
            };
            return student;
        }

        // Copy Constructor
        public Student(Student student)
        {
            Id = student.Id;
            Firstname = student.Firstname;
            Lastname = student.Lastname;
            MyAdress = new()
            {
                Street = student?.MyAdress?.Street,
                Number = student?.MyAdress?.Number,
                ZipCode = student?.MyAdress?.ZipCode
            };
        }
    }
}

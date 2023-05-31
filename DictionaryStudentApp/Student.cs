using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryStudentApp
{
    internal class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public int CompareTo(Student? other) 
        {
            if (other is null || other.Firstname is null || other.Lastname is null)
            {
                throw new ArgumentNullException("Error - Null arguments not allowed");
            }

            return Lastname!.CompareTo(other.Lastname);
        }

        public override bool Equals(object? obj)
        {
            if ((obj is null) || GetType() != obj.GetType())
            {
                return false;
            }

            Student other = (Student)obj;

            if (Firstname is not null && Lastname is not null)
            {
                return (Id.Equals(other.Id) && Lastname!.Equals(other.Lastname) && Firstname!.Equals(other.Firstname));
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Firstname, Lastname);
        }

        public override string? ToString()
        {
            return $"{Id} {Firstname} {Lastname}";
        }
    }
}

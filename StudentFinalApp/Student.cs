using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFinalApp

{
    /// <summary>
    /// <c>Student</c> Plain Old CLR Class.
    /// </summary>
    internal class Student
    {

        public Student() { }

        /*public Student(int id, string? firstName, string? lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }*/

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}

        public override string ToString() => $"{Id} {FirstName} {LastName}";

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {  
                return false; 
            }

            Student? other = obj as Student;

            return (Id == other?.Id && FirstName!.Equals(other.FirstName) && LastName!.Equals(other.LastName));
        }

        public override int GetHashCode()
        {
            // return HashCode.Combine(Id, FirstName, LastName);

            unchecked
            {
                int hash = 13;
                hash = hash * 23 + Id;
                hash = hash * 23 + FirstName?.GetHashCode()?? 0;
                hash = hash * 23 + LastName?.GetHashCode()?? 0;
                return hash;
            }
        }
    }
}

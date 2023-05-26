using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student2App
{
    internal class Student
    {
        private int id;
        private string? firstname;
        private string? lastname;

        public int Id { get { return id; }  init { id = value; } }
        public string? Firstname { get { return firstname; } init { firstname = value; } }
        public string? Lastname { get { return lastname; } init { lastname = value; } }
    }
}

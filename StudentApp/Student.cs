using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    /// <summary>
    /// A simple <c>Student</c> POCO class.
    /// </summary>
    internal class Student
    {
        private int id;
        private string? firstname;
        private string? lastname;

        /*public int Id { get { return id; } set {  id = value; } }
        public string Firstname { get { return firstname!; } set { firstname = value; } }
        public string Lastname { get { return lastname!; } set { lastname = value; } }*/

        // Expression-bodied members
        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname!; set => firstname = value; }
        public string Lastname { get => lastname!; set => lastname = value; }
    }
}

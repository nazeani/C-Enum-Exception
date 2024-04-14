using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        private int _id;
        public string Name { get; set; }
        public string Surname {  get; set; }
        public Student()
        {
            _id++;
            Id = _id;
        }
        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public override string ToString() 
        {
            return $"{Name} {Surname}";
        }

    }
}

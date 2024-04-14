using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Core.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        private int _id;
        public string Name { get; set; }
        Student[] _students = { };
        public Type Type { get; set; }
        private int _limit;
        public int Limit 
        {
            get { return _limit; }
            set
            {
                if(Type==Type.Student)
                {
                    _limit = 15;
                }
                else if(Type==Type.Backend) 
                {
                    _limit = 20;
                }
            }
        }
        public Classroom()
        {
            _id++;
            Id = _id;
        }
        public Classroom(string name,Type type)
        {
            _id++;
            Id = _id;
            Name = name;
            Type = type;
        }

        public void StudentAdd(Student student)
        {
            if (_students.Length <= _limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
        }
        public Student[] GetStudents() { return _students; }
        public void FindId(int id) 
        {
            foreach(Student student in _students) 
            {
                if(student.Id == id)
                    Console.WriteLine(student.Name);
            }
        }
        public Student[] Delete(int id)
        {
            Student[] deleteStudent = { };
            foreach (Student student in _students)
            {
                if(student.Id != id)
                {
                    Array.Resize(ref deleteStudent, deleteStudent.Length + 1);
                    deleteStudent[deleteStudent.Length - 1] = student;
                }
                if(_students==deleteStudent)
                {
                    throw StudentNotFoundException("Don't found!");
                }
            }
            _students=deleteStudent;
            return deleteStudent;
        }

        private Exception StudentNotFoundException(string v)
        {
            throw new NotImplementedException();
        }
    }
}

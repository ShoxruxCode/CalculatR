using System;
using System.Collections.Generic;
using System.Linq;
using CalculatR.Enums;

namespace CalculatR.Classes
{
    class Student
    {
        private int id;
        private string name;
        private string surName;
        private int classes;
        private StudentType grades;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }
        public int Classes
        {
            get { return classes; }
            set { classes = value; }
        }
        public StudentType Grades
        {
            get { return grades; }
            set { grades = value; }
        }
        public void PrintEnteredGradeStudents(List<Database> students, StudentType grade)
        {
            var filteredStudents = students.Where(s => s.Grades == grade).ToList();

            if (filteredStudents.Any())
            {
                Console.WriteLine($"{(int)grade} baho olgan o'quvchilar:");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"O'quvchining noyob raqami-{student.Id}, {student.Classes}-sinf o'quvchisi {student.Name} {student.SurName}");
                }
            }
            else
            {
                Console.WriteLine($"Hech kim {grade} baho olmagan.");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using CalculatR.Classes;
using CalculatR.Enums;

namespace CalculatR
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student= new Student();
            List<Database> students = Database.GetStudents();

            Console.Write("1 dan 5 gacha bo'lgan oraliqda bahoni kiriting, shu baho olgan o'quvchilar ro'yxatini olish uchun: ");
            int grades;
            if (int.TryParse(Console.ReadLine(), out grades) && grades >= 0 && grades <= 5)
            {
                StudentType grade = (StudentType)grades;

                student.PrintEnteredGradeStudents(students, grade);
            }
            else
            {
                Console.WriteLine("Notog'ri baho kiritildi.");
            }
        }
    }
}
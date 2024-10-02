using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatR.Classes
{
    class Boxer
    {
        private int id;
        private string name;
        private string surName;
        private int age;
        private double weight;
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
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public void PrintEnteredAgeBoxers(List<Database> boxers)
        {
            Console.WriteLine("Yengil(50 kg gacha), o'rta(50 dan 76kg gacha) va og'ir(90 kg va undan og'irlar) vaznli bokschilar saralandi.");
            var filteredBoxersLight = boxers.Where(s => s.Weight > 0 && s.Weight <= 50).ToList();
            Console.WriteLine($"\nYengil vazn toifasidagi bokschilar");
            foreach(var boxer in filteredBoxersLight)
            {
                Console.WriteLine($"Bokschining noyob raqami {boxer.Id}, bokschining ism familiyasi {boxer.Name} {boxer.SurName}, bokschining vazni {boxer.Weight} kg");
            }

            var filteredBoxersMedium = boxers.Where(s => s.Weight > 50 && s.Weight <= 76).ToList();
            Console.WriteLine($"\nO'rta vazn toifasidagi bokschilar");
            foreach(var boxer in filteredBoxersMedium)
            {
                Console.WriteLine($"Bokschining noyob raqami {boxer.Id}, bokschining ism familiyasi {boxer.Name} {boxer.SurName}, bokschining vazni {boxer.Weight} kg");
            }

            var filteredBoxersHeavy = boxers.Where(s => s.Weight >= 90).ToList();
            Console.WriteLine($"\nOg'ir vazn toifasidagi bokschilar");
            foreach(var boxer in filteredBoxersHeavy)
            {
                Console.WriteLine($"Bokschining noyob raqami {boxer.Id}, bokschining ism familiyasi {boxer.Name} {boxer.SurName}, bokschining vazni {boxer.Weight} kg");
            }
        }
    }
}
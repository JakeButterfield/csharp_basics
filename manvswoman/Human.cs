using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Human
    {
        public string name;
        public int age;
        public string gender;
        public int strength;
        public int health;

        Random rnd = new Random();

        public Human(string name)
        {
            this.name = name;
            this.age = 30;
            this.gender = "Male";
            this.strength = 100;
        }

        public Human(string name, int age, string gen, int str, int hp)
        {
            this.name = name;
            this.age = age;
            this.gender = gen;
            this.strength = str;
            this.health = hp;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public int Health
        {
            get { return health; }
            set { this.health = value; }
        }

        public int GetAttack()
        {
            return rnd.Next(1, (int)strength);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Battle
    {

        private Human contestant1;
        private Human contestant2;

        public Battle(Human cont1, Human cont2)
        {
            this.contestant1 = cont1;
            this.contestant2 = cont2;

            StartBattle();
        }

        public void StartBattle()
        {
            Console.WriteLine("Welcome to the fight");

            Console.WriteLine("Our first contestant is {0}, they are {1} years old", contestant1.Name, contestant1.Age);
            Console.WriteLine("Our second contestant is {0}, they are {1} years old", contestant2.Name, contestant2.Age);

            while (true)
            {
                if (contestant1.Health <= 0)
                {
                    Console.WriteLine("{0} has been killed!", contestant1.Name);
                    EndBattle(contestant1, contestant2);
                    break;
                }

                if (contestant2.Health <= 0)
                {
                    Console.WriteLine("{0} has been killed!", contestant2.Name);
                    EndBattle(contestant2, contestant1);
                    break;
                }

                int attack1 = (int)contestant2.GetAttack();
                int attack2 = (int)contestant1.GetAttack();

                contestant1.Health = (contestant1.Health - attack1);
                Console.WriteLine("{0} has hit {1} for {2} damage!", contestant2.Name, contestant1.Name, attack1);
                Console.WriteLine("{0} now has {1} health", contestant1.Name, contestant1.Health);

                contestant2.Health = (contestant2.Health - attack2);
                Console.WriteLine("{0} has hit {1} for {2} damage!", contestant1.Name, contestant2.Name, attack2);
                Console.WriteLine("{0} now has {1} health", contestant2.Name, contestant2.Health);

            }

        }

        public void EndBattle(Human loser, Human winner)
        {
            Console.WriteLine("{0} has Won! Bad luck {1}", winner.Name, loser.Name);
        }

    }
}

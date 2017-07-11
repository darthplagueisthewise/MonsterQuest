using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterApp
{
    class Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are walking in the woods");
            Console.WriteLine("Ahhh a Monster!");

            Random rnd = new Random();
            MonsterFight orcFight = new MonsterFight(30, 15);

            while (orcFight._Monster.MonsterHP > 0 && orcFight._Player.PlayerHP > 0)
            {
                Console.WriteLine("You take a shot at the Monster");

                int rand = rnd.Next(101);
                if (rand < 75)
                {
                    orcFight._Monster.PlayerLandsShot(10);
                    if (rand < 65 && orcFight._Monster.MonsterHP > 0)
                    {
                        orcFight._Monster.MonsterAttacks();
                    }
                }
                else
                {
                    Console.WriteLine("Your Shot Missed!");
                }
                int currentHP = orcFight._Monster.MonsterHP;
                if (rand > 50 && currentHP > 0 && orcFight._Monster.IsHurt)
                {
                    orcFight._Monster.MonsterRegensHealth(5);
                }
                Console.WriteLine(rand);
            }

            if (orcFight._Monster.MonsterHP <= 0)
            {
                Console.WriteLine("You Defeated the Monster!");
            }
            else
            {
                Console.WriteLine("You have died. GAME OVER");
            }
           

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterApp      
{
    class MonsterFight
    {
        public Monster _Monster;
        public Player _Player;

        public MonsterFight(int x, int y)
        {
            _Monster = new Monster(x, y);
            _Player = new Player(100);
            _Player.CurrentMonster = _Monster;
    
            _Monster.MonsterEvent += (s, e) =>
            {
                int MonHP = _Monster.MonsterHP;
                if (MonHP > 0)
                {
                    Console.WriteLine("The Monster\'s HP is: {0}", MonHP);
                }
            };

            _Monster.MonsterAttackEvent += (z) =>
            {
                Console.WriteLine("You are hurt! Current HP: {0}", _Player.PlayerHP);
            };

            Console.WriteLine("The Monster\'s HP is: {0}", x);
        }

    }
}

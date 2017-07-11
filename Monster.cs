using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterApp
{
    class Monster
    {
        public event EventHandler MonsterEvent;
        public delegate void MonsterAttack(int x);
        public event MonsterAttack MonsterAttackEvent; 

        private int initialHP;
        public int MonsterHP { get; set; }

        public int Attack { get; set; }

        public bool IsHurt
        {
            get
            {
                return (initialHP != MonsterHP);
            }

            set
            {   
            }
        }

        public Monster() { }

        public Monster(int x, int y)
        {
            initialHP = x;
            MonsterHP = x;
            Attack = y;
        }

        public void PlayerLandsShot(int x)
        {
            if (MonsterEvent != null)
            {
                Console.WriteLine("You hit the Monster!");
                MonsterHP -= x;
                MonsterEvent(this, null);
            }
        }

        public void MonsterRegensHealth(int x)
        {
            if (MonsterEvent != null)
            {
                Console.WriteLine("The Monster is regening health!");
                MonsterHP += x;
                MonsterEvent(this, null);
            }
        }

        public void MonsterAttacks()
        {
            if (MonsterAttackEvent != null)
            {
                Console.WriteLine("The Monster is Attacking!");
                MonsterAttackEvent(this.Attack);
            }
        }

    }
}

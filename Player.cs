using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterApp
{
    class Player
    {
        private string[] PlayerName = new string[NumberOfPlayers];

        static private int NumberOfPlayers = 4;
        
        public string this[int i] => PlayerName[i];
        public int PlayerHP { get; set; }

        public int PlayerLevel { get; set; }

        public int PlayerAttack { get; set; }

        private Monster c_Monster;

        public Monster CurrentMonster
        {
            get
            {
                return c_Monster;
            }

            set
            {
                c_Monster = value;
                if (value != null)
                {
                    c_Monster.MonsterAttackEvent += (x) =>
                    {
                        PlayerHP -= x;
                    };
                }
            }
        }

        public Player()
        {
            PlayerHP = 100;
            PlayerLevel = 1;
            CurrentMonster = null; 
        }

        public Player(int x)
        {
            PlayerLevel = 1;
            PlayerHP = x;
            CurrentMonster = null;
        }
    }
}

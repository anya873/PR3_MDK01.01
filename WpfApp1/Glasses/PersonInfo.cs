using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Glasses
{
    internal class PersonInfo
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Level { get; set; }
        public int Glasses { get; set; }
        public int Money { get; set; }
        public float Damage { get; set; }

        public PersonalInfo(string name, int health, int armor, int level, int glasses, int money, float damage)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.Level = level;
            this.Glasses = glasses;
            this.Money = money;
            this.Damage = damage;
        }
    }
}

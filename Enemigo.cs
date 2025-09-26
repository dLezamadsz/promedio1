using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class Enemigo
    {
        private int hp;
        private int dmg;

        public Enemigo(int a, int b)
        {
            this.hp = a;
            this.dmg = b;
        }

        public Enemigo()
        {

        }

        public int Damage()
        {
            return dmg;
        }

        public void GetDamage()
        {

        }

        public bool Alive()
        {
            bool alive = true;
            if (hp <= 0)
            {
                alive = false;
            }
            return alive;
        }
    }
}

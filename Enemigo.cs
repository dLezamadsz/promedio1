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
        private bool alive;

        public Enemigo(int a, int b, bool c)
        {
            this.hp = a;
            this.dmg = b;
            this.alive = c;
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
            if (hp <= 0)
            {
                alive = false;
            }
            return alive;
        }
    }
}

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

        public int Damage()
        {
            return dmg;
        }

        public void GetDamage(Jugador p)
        {
            hp -= p.Damage();
            if(hp < 0)
            {
                hp = 0;
            }
        }

        public bool Alive()
        {
            if (hp <= 0)
            {
                alive = false;
            }
            return alive;
        }

        public int GetHP()
        {
            return hp;
        }
    }
}

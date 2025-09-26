using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class Jugador
    {
        private int hp;
        private int dmg;
        public bool alive;

        public Jugador(int a, int b, bool c)
        {
            this.hp = a;
            this.dmg = b;
            this.alive = c;
        }

        public int Damage()
        {
            return dmg;
        }

        public void GetDamage(Enemigo e)
        {
            hp -= e.Damage();
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

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

        public Jugador(int a, int b)
        {
            this.hp = a;
            this.dmg = b;
        }

        public Jugador()
        {

        }

        public int Damage()
        {
            return dmg;
        }

        public void GetDamage()
        {

        }
    }
}

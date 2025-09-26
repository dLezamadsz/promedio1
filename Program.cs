using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a)
            {
                // Crear personaje, asignar stats (x<=100)
                Console.WriteLine("Ingresar vida del jugador");
                int php = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar daño que causa el jugador");
                int pdmg = int.Parse(Console.ReadLine());
                if (php > 100 || pdmg > 100)
                {
                    Console.WriteLine("No se pudo crear al jugador\n(Uno de los stats supera los 100 puntos)");
                    Console.ReadLine();
                    a = false; break;
                }
                else
                {
                    Jugador p = new Jugador(php, pdmg);
                    Console.WriteLine("El jugador se ha creado con éxito.\n--------------------------");
                }

                // Cantidad de enemigos
                List<Enemigo> enemigos = new List<Enemigo>();
                Console.WriteLine("Ingresar cantidad de enemigos");
                int ecount = int.Parse(Console.ReadLine());
                if(ecount < 0)
                {
                    Console.WriteLine("????????");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    for (int i = 0; i < ecount; i++)
                    {
                        // Asignar stats
                        Console.WriteLine("Ingresar vida del enemigo " + (i + 1));
                        int ehp = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar daño que causa el enemigo");
                        int edmg = int.Parse(Console.ReadLine());

                        // Añadir a lista de enemigos
                        Enemigo enemy = new Enemigo(ehp, edmg, true);
                        enemigos.Add(enemy);
                        Console.WriteLine("El enemigo se ha creado con éxito.\n--------------------------");
                    }
                }
                

                
                // Jugador ataca, enemigo random ataca de vuelta
                // Si el enemigo está muerto, el jugador no podrá atacarlo (enemigos.Remove())
                // Si el jugador queda sin vida, mensaje de derrota
                // Si se acaban los enemigos, mensaje de victoria
                //Reiniciar la partida
                Console.WriteLine("¿Desea reiniciar la partida?\n(1) SÍ\n(2) NO");
                string b = Console.ReadLine();
                switch (b)
                {
                    default: a = false; break;
                    case "1": a = true; break;
                }
            }
        }
    }
}

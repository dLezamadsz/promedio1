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
                Jugador player;
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
                    player = new Jugador(php, pdmg, true);
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

                bool game = true;
                while (game && ecount > 0)
                {
                    
                    // Jugador ataca
                    Console.WriteLine($"HP: {player.GetHP()}");
                    Console.WriteLine("Elija al enemigo para atacar");
                    for (int i = 0; i < ecount; i++)
                    {
                        Console.WriteLine($"({i}) Enemigo {i} - {enemigos[i].GetHP()} HP");
                    }
                    int index = int.Parse(Console.ReadLine());

                    // Si el enemigo está muerto, el jugador no podrá atacarlo
                    if (enemigos[index].Alive() == false)
                    {
                        Console.WriteLine("El enemigo está muerto y no se puede atacar");
                    }
                    else
                    {
                        Console.WriteLine($"Atacaste al enemigo {index} ({player.Damage()}puntos)");
                        enemigos[index].GetDamage(player);
                    }
                    // Si se acaban los enemigos, mensaje de victoria
                    int evivos = enemigos.FindAll(x => x.Alive()).Count;
                    if (evivos == 0)
                    {
                        Console.WriteLine("----VICTORIA----");
                        game = false;
                        Console.ReadLine();
                    }
                    else
                    {
                        Random random = new Random();
                        int r = random.Next(enemigos.Count);
                        // Enemigo random ataca de vuelta
                        while (!enemigos[r].Alive())
                        {
                            r = random.Next(enemigos.Count);
                        }
                        Console.WriteLine($"El enemigo {r} atacó ({enemigos[r].Damage()} puntos)\n--------------------------");
                        player.GetDamage(enemigos[r]);
                        // Si el jugador queda sin vida, mensaje de derrota
                        if (player.Alive() == false)
                        {
                            Console.WriteLine("No le queda HP al jugador\n----GAME OVER----");
                            game = false;
                            Console.ReadLine();
                        }
                    }
                }
                
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

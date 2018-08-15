using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy1 = new Enemy();
            enemy1.positionX = 2;
            enemy1.positionY = 4;
            enemy1.movement = 4;
            enemy1.shot = 8;
            if (enemy1.shot < 5)
            {
                enemy1.points = 1000;
            }
            else if (enemy1.shot < 2)
            {
                enemy1.shot = 100;
            }

            Console.WriteLine("¡¡¡ACABA CON ROBT!!!");
            Console.WriteLine(" ");
            Console.WriteLine("Información de Robt:");
            Console.WriteLine("posición en X:" + enemy1.positionX);
            Console.WriteLine("posición Y: " + enemy1.positionY);
            Console.WriteLine("Numero de movimientos: " + enemy1.movement);
            Console.WriteLine("Tiros: " + enemy1.shot);
            Console.WriteLine(" ");
            if (enemy1.points == 1000 || enemy1.points < 1000)
            {
                enemy1.explosion();
                Console.WriteLine("YOU WIN!!!");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Enemy
    {
        //Autopropertires
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int movement { get; set; }
        public int points { get; set; }
        //Propertires
        private int _shot;
        public int shot
        {
            get
            {
                return _shot;
            }
            set
            {
                if (value >= 4)
                {
                    _shot = value;

                }
                else if (value < 4)
                {
                    Console.WriteLine("+500 POINTS");
                    Console.WriteLine("Points: " + points + 500);
                }
                else if (value == 0)
                {
                    Console.WriteLine("You fail");
                }
            }

        }
        public void explosion()
        {
            Console.WriteLine("You killed him, He explode");
        }
    }
}


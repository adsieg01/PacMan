using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public class PacManController
    {
        private static PacManService game = new PacManService();


        public static void Start()
        {
            //Call methods in this order
            game.ReadGameFile();
            game.AddPoints();
            game.AddLives();
            game.CheckCurrentItem();
        }


    }
}

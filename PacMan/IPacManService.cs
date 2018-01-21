using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    interface IPacManService
    {
        //Create contracts for Services 
        string[] ReadGameFile();
        void CheckCurrentItem();
        int AddPoints();
        int AddLives();
    }
}

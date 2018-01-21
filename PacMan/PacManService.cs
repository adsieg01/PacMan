using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PacMan
{
    class PacManService
    {
        public void ReadGameFile()
        {
            string text = @"C:\Users\Andrew\source\repos\PacMan";
            string[] levelOne = File.ReadAllText("text").Split(',');
            
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PacMan
{

    public class PacManService : IPacManService
    {
       
        //PacMan Model Inst.
        private static PacMan pacMan = new PacMan();
        //Make array global 
        string[] getLevelOne;
         

        //Read File and Put it into an array 
        public string[] ReadGameFile()
        {
            string text = @"C:\Users\Andrew\source\repos\PacMan\KataPacman-seq.txt";
            string[] levelOne = File.ReadAllText(text).Split(',');
            getLevelOne = levelOne;
            return levelOne;
            
        }

        //Determines how many lives PM gains
        public int AddLives()
        {
            int livesGained = 0;
            int livesLeft = 3;

            for (int i = pacMan.Points; i >= 10000; i-=10000)
            {
                livesLeft += 1;
                livesGained += 1;
            }
            pacMan.Lives = livesLeft;
            return pacMan.LivesGained = livesGained;
        }

        //Determeines how many points PM gained 
        public int AddPoints()
        {
            int score = 0;

            score += 5000;
            

            foreach (string l in getLevelOne)
            {
             
                switch (l.ToLower())
                {
                    case "dot":
                        score += 10;
                        break;

                    case "cherry":
                        score += 100;
                        break;

                    case "strawberry":
                        score += 300;
                        break;

                    case "orange":
                        score += 500;
                        break;

                    case "apple":
                        score += 700;
                        break;

                    case "melon":
                        score += 1000;
                        break;

                    case "galaxian":
                        score += 2000;
                        break;

                    case "bell":
                        score += 3000;
                        break;

                    case "key":
                        score += 5000;
                        break;

                    case "vulnerableghost":
                        score += EatVulnerableGhost();
                        pacMan.VulnerableGhostsEaten++;
                        break;

                    case "invincibleghost":
                        pacMan.Lives-= 1;
                        break;
                }

   
            }

            int EatVulnerableGhost()
            {
                var ghostPointValue = 200;

                for (int i = 0; i < pacMan.VulnerableGhostsEaten; i++)
                {
                    ghostPointValue *= 2;
                }

                return ghostPointValue;
            }
            return pacMan.Points = score;
            
        }


        //Prints out game outcome to console 
        public void CheckCurrentItem()
        {
            if (pacMan.Lives <= 0)
            {
                Console.WriteLine("Game Over!" + pacMan.Points + pacMan.Lives );
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The score for the dots is " + pacMan.Points + " and you gained " + pacMan.LivesGained + " lives");
                Console.ReadLine();
            }
        }

        
        
    }

}

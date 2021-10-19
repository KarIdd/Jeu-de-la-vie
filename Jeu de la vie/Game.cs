using System;
using System.Collections.Generic;
using System.Threading;


namespace Jeu_de_la_vie
{
    class Game
    {
        private int n; // taille de la grille
        private int iter; // nombre d’itérations de la simulation
        public Grid grid; // grille des emplacements possibles
        List<Coords> AliveCellsCoords; // liste des coordonnées des cellules vivantes en début de simulation.
        public Random random;

        public Game(int nbCells, int nbIterations) // Constructeur de la class Game
        {
            n = nbCells;
            iter = nbIterations;
            AliveCellsCoords = new List<Coords>();
            random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (random.Next(0, 2) == 1)
                    {
                        Coords coords = new Coords(i, j);
                        AliveCellsCoords.Add(coords);
                    }
                }
            }
            grid = new Grid(n, AliveCellsCoords);
        }

        public void RunGameConsole() // Méthode de supervisation qui implémente
        {
            grid.DisplayGrid();
            while (iter > 0)
            {
                grid.UpdateGrid();
                grid.DisplayGrid();
                Thread.Sleep(1000);
                iter--;
            }
        }





    }
}

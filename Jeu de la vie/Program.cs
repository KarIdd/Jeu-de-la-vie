using System;

namespace Jeu_de_la_vie
{
    class Program
    {
        static void Main()
        {
            Game game = new Game(10, 10);

            game.RunGameConsole();
        }
    }
}

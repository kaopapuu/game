using System;

namespace FinalProject
{
    public class Menu
    {
        public static void OpenMenu(Player player)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Resume the game");
            Console.WriteLine("Quit the game");
            Console.WriteLine("Enter Command [Resume,Quit]");

            var command = Console.ReadLine();
            var lowercommand = command.ToLower();

            switch (lowercommand)
            {
                case "resume":
                    Gameplay.IdleState(player);
                    break;
                case "Quit":
                    break;
            }
        }
    }
}
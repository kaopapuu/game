using System;

namespace FinalProject
{
    public abstract class Story
    {
        public static void StartStory()
        {
            Console.WriteLine("It is the story of a high school student with no special abilities.");
            Console.ReadLine();
            Console.WriteLine("But then something happened that changed his life.");
            Console.ReadLine();
            Console.WriteLine("Because he was kidnapped in a place full of monsters he don't know anything.");
            Console.ReadLine();
            Console.WriteLine("But he had to survive to return to the place where he came from");
            Console.ReadLine();
            Console.WriteLine("Enter To Start");
            Console.ReadLine();
        }

        public static void EndGame()
        {
            Console.WriteLine("After the main character can defeat the boss. He returned to a normal life");
        }
    }
}
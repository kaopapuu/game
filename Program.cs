namespace FinalProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataEnemy.AllEnemySetskills();

            Story.StartStory();
            Gameplay.SelectYourCharacter();
            Gameplay.SelectItem();

            var player = Gameplay.Player1;

            Gameplay.IdleState(player);
        }
    }
}
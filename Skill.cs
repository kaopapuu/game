namespace FinalProject
{
    public class Skill
    {
        public int Damage;

        public int ManaUsed;

        //copy from GI161-Character-Solution
        public string Name;

        public Skill(string name, int manaUsed, int damage)
        {
            Name = name;
            ManaUsed = manaUsed;
            Damage = damage;
        }
    }
}
namespace FinalProject
{
    public class DataEnemy
    {
        //Slime
        public static readonly Enemy Slime = new Enemy("Slime", 150, 30, 30, 0, false);
        public static readonly Skill SkillSlime1 = new Skill("Slime Rain", 10, 70);
        public static readonly Skill SkillSlime2 = new Skill("Acid Flare", 5, 50);

        //Skeleton
        public static readonly Enemy Skeleton = new Enemy("Skeleton", 350, 50, 30, 10, false);
        public static readonly Skill SkillSkeleton = new Skill("Slash", 5, 200);

        //Mummy
        public static readonly Enemy Mummy = new Enemy("Mummy", 450, 60, 50, 5, false);
        public static readonly Skill SkillMummy1 = new Skill("Anxiety", 10, 75);
        public static readonly Skill SkillMummy2 = new Skill("Reprisal of Shadows", 5, 50);

        //Snowman Gangsta
        public static readonly Enemy SnowmanGangsta = new Enemy("Snowman Gangsta", 150, 100, 70, 0, false);
        public static readonly Skill SkillSnowmanGangsta1 = new Skill("Pew pew", 10, 75);
        public static readonly Skill SkillSnowmanGangsta2 = new Skill("Shadow Missiles", 10, 80);

        //Medusa
        public static readonly Enemy Medusa = new Enemy("Medusa", 250, 150, 30, 0, false);
        public static readonly Skill SkillMedusa1 = new Skill("Stoned", 10, 85);
        public static readonly Skill SkillMedusa2 = new Skill("Life Whip", 10, 105);

        //Krampus is Boss
        public static readonly Enemy Krampus = new Enemy("Krampus", 5, 100, 30, 10, true);
        public static readonly Skill SkillKrampus1 = new Skill("Punch in the face", 5, 50);
        public static readonly Skill SkillKrampus2 = new Skill("Inferno", 5, 100);
        public static readonly Skill SkillKrampus3 = new Skill("Assault of Painkillers", 10, 150);

        public static readonly Enemy[] Enemies = {Slime, Skeleton, Mummy, SnowmanGangsta, Medusa}; 
        public static void AllEnemySetskills()
        {
            Slime.Setskills(new[] {SkillSlime1, SkillSlime2});
            Skeleton.Setskills(new[] {SkillSkeleton});
            Mummy.Setskills(new[] {SkillMummy1, SkillMummy2});
            SnowmanGangsta.Setskills(new[] {SkillSnowmanGangsta1, SkillSnowmanGangsta2});
            Medusa.Setskills(new[] {SkillMedusa1, SkillMedusa2});
            Krampus.Setskills(new[] {SkillKrampus1, SkillKrampus2, SkillKrampus3});
        }
    }
}
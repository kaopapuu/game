using System;

namespace FinalProject
{
    public class Enemy : CharacterBase
    {
        public Enemy(string name, int hp, int mana, int atk, int def, bool isBoss) : base(name, hp, mana, atk, def)
        {
            IsBoss = isBoss;
            IsDead = false;
            MaxHp = hp;
            MaxMana = mana;
        }
        
        public override void Setskills(Skill[] skill)
        {
            base.Setskills(skill);
        }
        
        public override void PhysicalAttack(CharacterBase opponent)
        {
            base.PhysicalAttack(opponent);
        }
        
        public override void SkillAttack(CharacterBase opponent)
        {
            var random = new Random();
            var skillNumber = random.Next(Skills.Length);
            var selectedSkill = Skills[skillNumber];
            var damage = 0;

            if (Mana >= selectedSkill.ManaUsed)
            {
                Mana -= selectedSkill.ManaUsed;
                if (Mana <= 0) Mana = 0;
                Console.WriteLine($"{Name} using Skill {selectedSkill.Name} to Make {selectedSkill.Damage} Damage");
                damage = selectedSkill.Damage;
            }

            opponent.TakeHit(opponent, damage);
        } 
        
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
        
        public override void TakeHit(CharacterBase opponent, int damage)
        {
            base.TakeHit(opponent, damage);
        } 
        
        protected override void Dead()
        {
            base.Dead();
            DataRandom.RandomItem();
        } 
        
        protected override void UseSkill(CharacterBase opponent)
        {
            base.UseSkill(opponent);
        }
    }
}
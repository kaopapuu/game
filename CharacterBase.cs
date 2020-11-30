using System;

namespace FinalProject
{
    public class CharacterBase
    { 
        public int Atk;
        public int Defend;
        public int Hp;
        public int MaxHp;
        public int Mana;
        public int MaxMana;
        public bool IsBoss;
        public bool IsDead;
        public string Name;
        public Skill SelectedSkill;
        public Skill[] Skills;
        private static bool Command;

        public CharacterBase(string name, int maxhp, int maxmana, int atk, int defend)
        {
            IsDead = false;
            Name = name;
            MaxHp = maxhp;
            Hp = maxhp;
            MaxMana = maxmana;
            Mana = maxmana;
            Atk = atk;
            Defend = defend;
        }

        /// <summary>
        ///     Add skill to characters
        ///     copy from GI161-Character-Solution
        /// </summary>
        /// <param name="skill"></param>
        public virtual void Setskills(Skill[] skill)
        {
            Skills = skill;
        }

        /// <summary>
        ///     Choose what to do with opponente
        /// </summary>
        /// <param name="opponent"></param>
        public virtual void Attack(CharacterBase opponent, Player player)
        {
            Command = false;
            while (!Command)
            {
                Console.WriteLine($"{Name} have {Hp} hp");
                Console.WriteLine($"{Name} have {Mana} mana");
                Console.WriteLine($"{Name} Is Attacking {opponent.Name} By");
                Console.WriteLine("Enter Command [Attack,Skill,Use item,Escape]");

                var attacking = Console.ReadLine();
                if (attacking != null)
                {
                    var lowerAttacking = attacking.ToLower();

                    switch (lowerAttacking)
                    {
                        case "skill":
                            SkillAttack(opponent);
                            Command = true;
                            break;
                        case "attack":
                            PhysicalAttack(opponent);
                            Command = true;
                            break;
                        case "escape":
                            Escape(opponent, player);
                            Command = true;
                            break;
                        case "use item":
                            Inventory.SelectUseItem();
                            Command = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Attack Command !\n");
                            break;
                    }
                }
            }
        }

        /// <summary>
        ///  Choose Skill to Attack opponent
        /// </summary>
        /// <param name="opponent"></param>
        public virtual void SkillAttack(CharacterBase opponent)
        {
            Command = false;
            ShowSkill();

            while (!Command)
                if (Skills.Length == 3)
                {
                    Console.WriteLine("Choice Skill[1,2,3]");
                    var skillNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                    var number = skillNumber - 1;
                    switch (skillNumber)
                    {
                        case 1:
                            Console.WriteLine($"{Name} Skill {skillNumber}: {Skills[number].Name}");
                            SelectedSkill = Skills[number];
                            UseSkill(opponent);
                            Command = true;
                            break;
                        case 2:
                            Console.WriteLine($"{Name} Skill {skillNumber}: {Skills[number].Name}");
                            SelectedSkill = Skills[number];
                            UseSkill(opponent);
                            Command = true;
                            break;
                        case 3:
                            Console.WriteLine($"{Name} Skill {skillNumber}: {Skills[number].Name}");
                            SelectedSkill = Skills[number];
                            UseSkill(opponent);
                            Command = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Attack Command !");
                            break;
                    }
                }

                else if (Skills.Length == 5)
                {
                    Console.WriteLine("Choice Skill[1,2,3,4,5,6]");
                    var skillNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                    var number = skillNumber - 1;
                    switch (skillNumber)
                    {
                        case 1:
                            Console.WriteLine($"{Name} Skill {skillNumber}: {Skills[number].Name}");
                            SelectedSkill = Skills[number];
                            UseSkill(opponent);
                            Command = true;
                            break;
                        case 2:
                            Console.WriteLine($"{Name} Skill {skillNumber}: {Skills[number].Name}");
                            SelectedSkill = Skills[number];
                            UseSkill(opponent);
                            Command = true;
                            break;
                        case 3:
                            Console.WriteLine($"{Name} Skill {skillNumber}: {Skills[number].Name}");
                            SelectedSkill = Skills[number];
                            UseSkill(opponent);
                            Command = true;
                            break;
                        case 4:
                            Console.WriteLine($"{Name} Skill {skillNumber}: {Skills[number].Name}");
                            SelectedSkill = Skills[number];
                            UseSkill(opponent);
                            Command = true;
                            break;
                        case 5:
                            Console.WriteLine($"{Name} Skill {skillNumber}: {Skills[number].Name}");
                            SelectedSkill = Skills[number];
                            UseSkill(opponent);
                            Command = true;
                            break;
                        case 6:
                            Console.WriteLine($"{Name} Skill {skillNumber}: {Skills[number].Name}");
                            SelectedSkill = Skills[number];
                            UseSkill(opponent);
                            Command = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Attack Command !");
                            break;
                    }
                }
        }

        /// <summary>
        ///     Choose Physical Attack to Attack opponent
        ///     copy from GI161-Character-Solution
        /// </summary>
        /// <param name="opponent"></param>
        public virtual void PhysicalAttack(CharacterBase opponent)
        {
            Console.WriteLine($"{Name} Is Attack {opponent.Name}");
            var damage = 0;

            if (opponent.Defend >= Atk)
                damage = 0;
            else
                damage = Atk - opponent.Defend;

            Console.WriteLine($"Attack {damage} Damage");

            opponent.TakeHit(opponent, damage);
        }

        /// <summary>
        ///     characters takeHit from enemy
        ///     copy from GI161-Character-Solution
        /// </summary>
        /// <param name="opponent"></param>
        /// <param name="damage"></param>
        public virtual void TakeHit(CharacterBase opponent, int damage)
        {
            Console.WriteLine($"{Name} Takes Damage: {damage} Damage");

            opponent.Hp -= damage;

            if (opponent.Hp > 0)
                Console.WriteLine($"{Name} have {Hp} Hp left.\n");
            else
                Dead();
        }

        protected virtual void Dead()
        {
            IsDead = true;

            Console.WriteLine($"{Name} Is Dead\n");
        }

        /// <summary>
        ///     Show Info characters
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"HP : {Hp}");
            Console.WriteLine($"MP : {Mana}");
            Console.WriteLine($"Atk : {Atk}");
            Console.WriteLine($"Def : {Defend}");
            Console.WriteLine("currently skills");
            ShowSkill();
        }
        
        /// <summary>
        ///     copy from GI161-Character-Solution
        /// </summary>
        /// <param name="opponent"></param>
        protected virtual void UseSkill(CharacterBase opponent)
        {
            var damage = 0;
            if (Mana >= SelectedSkill.ManaUsed)
            {
                Mana -= SelectedSkill.ManaUsed;
                if (Mana <= 0) Mana = 0;
                Console.WriteLine($"{Name} using {SelectedSkill.Name} to Make {SelectedSkill.Damage} Damage");
                damage = SelectedSkill.Damage;
            }

            opponent.TakeHit(opponent, damage);
        }
        protected virtual void ShowSkill()
        {
            for (var i = 0; i < Skills.Length; i++)
                Console.WriteLine($"Skill {i + 1} : {Skills[i].Name} ManaUsed : {Skills[i].ManaUsed} " +
                                  $"Damage : {Skills[i].Damage}");
        }
        protected virtual void Escape(CharacterBase opponent, Player player)
        {
            if (!opponent.IsBoss)
            {
                var random = new Random();
                var randomEscape = random.Next(101);
                if (randomEscape >= 50)
                {
                    opponent.IsDead = true;
                    Console.WriteLine($"{Name} Can Escape \n");
                    Gameplay.IdleState(player);
                }
                else
                {
                    Console.WriteLine("Escape Fail\n");
                }
            }
            else
            {
                Console.WriteLine($"{Name} Can't Escape ");
                Console.WriteLine("It a Boss\n");
            }
        }
    }
}
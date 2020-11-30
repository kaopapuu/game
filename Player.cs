using System;

namespace FinalProject
{
    public class Player : CharacterBase
    {
        public static int StaticHp;
        public static int StaticMana;
        public static int StaticMaxMana;
        public static int StaticMaxHp;
        public static string StaticName;
        public static ClassPlayer ClassPlayer;
        private static bool Command;
        private Armour _armour;
        private Armour _helmet;
        private Armour _necklace;
        private Armour _ring;
        private Weapon _weapon;
        public int BaseAtk;
        public int Basedef;

        public Player(string name, int maxhp, int maxmana, int atk, int def, ClassPlayer classPlayer) : base(name,
            maxhp, maxmana, atk, def)
        {
            Basedef = def;
            BaseAtk = atk;
            StaticName = Name;
            ClassPlayer = classPlayer;
            IsDead = false;
            StaticHp = maxhp;
            StaticMana = maxmana;
            StaticMaxMana = maxmana;
            StaticMaxHp = maxhp;

        }


        public override void Setskills(Skill[] skill)
        {
            base.Setskills(skill);
        }

        public override void Attack(CharacterBase opponent, Player player)
        {
            base.Attack(opponent, player);
        }

        public override void PhysicalAttack(CharacterBase opponent)
        {
            base.PhysicalAttack(opponent);
        }

        public override void SkillAttack(CharacterBase opponent)
        {
            base.SkillAttack(opponent);
        }

        public void EquipArmorStarter()
        {
            Defend += DataArmor.StarterArmor.Def;
            Defend += DataArmor.StarterHelmet.Def;
            Defend += DataArmor.StarterNecklace.Def;
            Defend += DataArmor.StarterRing.Def;

            _armour = DataArmor.StarterArmor;
            _helmet = DataArmor.StarterHelmet;
            _necklace = DataArmor.StarterNecklace;
            _ring = DataArmor.StarterRing;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Weapon {_weapon.Name}");
            Console.WriteLine($"Body Armor {_armour.Name}");
            Console.WriteLine($"Head Armour {_helmet.Name}");
            Console.WriteLine($"Ring {_ring.Name}");
            Console.WriteLine($"Necklace {_necklace.Name}\n");
        }

        public override void TakeHit(CharacterBase opponent, int damage)
        {
            base.TakeHit(opponent, damage);
        }

        protected override void Dead()
        {
            base.Dead();
            Console.WriteLine("Game Over");
        }

        protected override void UseSkill(CharacterBase opponent)
        {
            base.UseSkill(opponent);
        }

        protected override void ShowSkill()
        {
            base.ShowSkill();
        }

        protected override void Escape(CharacterBase opponent, Player player)
        {
            base.Escape(opponent, player);
        }

        /// <summary>
        ///     Player use Item
        /// </summary>
        /// <param name="items"></param>
        public static void UseItem(Item items)
        {
            Console.WriteLine($"{StaticName} healing : {items.Heal} hp");
            Console.WriteLine($"{StaticName} Restore : {items.RestoreMana} Mana");

            StaticMana += items.RestoreMana;
            StaticHp += items.Heal;

            if (StaticHp > StaticMaxHp) StaticHp = StaticMaxHp;

            if (StaticMana > StaticMaxMana) StaticMana = StaticMaxMana;

            Console.WriteLine($"Your {StaticHp} HP ");
            Console.WriteLine($"Your {StaticMana} Mana \n");
        }

        /// <summary>
        ///     Playerv Equip Weapon
        /// </summary>
        /// <param name="weapon"></param>
        public void EquipWeapon(Weapon weapon)
        {
            Atk = BaseAtk;
            switch (ClassPlayer)
            {
                case ClassPlayer.SwordMan when weapon.Type == WeaponType.Melee:
                    Console.WriteLine($"{Name} Equip {weapon.Name}\n");
                    Atk += weapon.Attack;
                    _weapon = weapon;
                    break;
                case ClassPlayer.Wizard when weapon.Type == WeaponType.Spellbook:
                    Console.WriteLine($"{Name} Equip {weapon.Name}\n");
                    Atk += weapon.Attack;
                    _weapon = weapon;
                    break;
                case ClassPlayer.Archer when weapon.Type == WeaponType.Range:
                    Console.WriteLine($"{Name} Equip {weapon.Name}\n");
                    Atk += weapon.Attack;
                    _weapon = weapon;
                    break;
                default:
                    Console.WriteLine($"{Name} can't equip because this {weapon.Name} not match with {ClassPlayer}\n");
                    break;
            }
        }

        /// <summary>
        ///     Player Equip Armor
        /// </summary>
        /// <param name="armour"></param>
        public void EquipArmor(Armour armour)
        {
            var remainDef = Defend - Basedef;
            switch (armour.ArmourType)
            {
                case ArmourType.Body:
                    Defend += armour.Def;
                    Defend += remainDef;
                    Console.WriteLine($"{Name} Equip {armour.Name}\n");
                    _armour = armour;
                    break;
                case ArmourType.Helmet:
                    Defend += armour.Def;
                    Defend += remainDef;
                    Console.WriteLine($"{Name} Equip {armour.Name}\n");
                    _helmet = armour;
                    break;
                case ArmourType.Necklace:
                    Defend += armour.Def;
                    Defend += remainDef;
                    Console.WriteLine($"{Name} Equip {armour.Name}\n");
                    _necklace = armour;
                    break;
                case ArmourType.Ring:
                    Defend += armour.Def;
                    Defend += remainDef;
                    Console.WriteLine($"{Name} Equip {armour.Name}\n");
                    _ring = armour;
                    break;
            }
        } 
        
        public void Setname()
        {
            Command = false;
            while (!Command)
            {
                Console.WriteLine("Please Enter your name");

                var name = Console.ReadLine();
                Console.Write("\n");
                Name = name;
                StaticName = name;

                Console.WriteLine($"Your Name :{name} ");
                Console.WriteLine("Confirm [Yes,no]");
                var confirmName = Console.ReadLine();
                var lowerConfirmName = confirmName.ToLower();
                Console.Write("\n");
                switch (lowerConfirmName)
                {
                    case "yes":
                        Command = true;
                        Console.Write("\n");
                        break;
                    case "no":
                        break;
                }
            }
        }

        public void Sleep(Player player)
        {
            if (Hp < MaxHp )
            {
                if (Mana < MaxHp)
                {
                    Console.WriteLine($"{Name} is sleeping");
                    Console.WriteLine($"{Name} gets more hp and mana from sleeping.");
                    Console.WriteLine($"Hp +100 Mana +100 .");
                    Hp += 100;
                    Mana += 100;
                    Console.WriteLine($"{Name} have {Hp} Hp left.\n");
                    Gameplay.IdleState(player);
                }
            }
            else
            {
                Console.WriteLine($"Your hp and mana are still full.");
                Gameplay.IdleState(player);
            }
            
            
        }
    }
}
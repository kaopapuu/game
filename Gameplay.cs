using System;
using System.Collections.Generic;

namespace FinalProject
{
    public abstract class Gameplay
    {
        //player
        public static Player Player1;
        private static bool _command;
        public static int Round;
        public static bool EndGame;
        
        public static void SelectYourCharacter()
        {
            while (!_command)
            {
                Console.WriteLine("Select Your Character");
                Console.WriteLine("Swordman,Archer,Wizard");

                var character = Console.ReadLine();
                var lowerCharacter = character.ToLower();

                Console.Write("\n");

                switch (lowerCharacter)
                {
                    case "swordman":

                        var swordman = new Player("Sword Man", 2000, 1000, 20, 15, ClassPlayer.SwordMan);
                        var swordsmanSkill1 = new Skill("Bash Deals", 10, 50);
                        var swordsmanSkill2 = new Skill("Pierce Dealing", 20, 70);
                        var swordsmanSkill3 = new Skill("Hundred Spears Dealing", 40, 100);
                        var swordsmanSkill = new[] {swordsmanSkill1, swordsmanSkill2, swordsmanSkill3};

                        swordman.EquipWeapon(DataWeapon.Startersword);
                        swordman.Setskills(swordsmanSkill);
                        swordman.EquipArmorStarter();
                        swordman.ShowInfo();

                        Confirmcharacter(swordman);
                        swordman.Setname();
                        break;
                    case "archer":

                        var archer = new Player("Archer", 1500, 2500, 50, 5, ClassPlayer.Archer);
                        var archerSkill1 = new Skill("Double Strafe Deal", 15, 70);
                        var archerSkill2 = new Skill("Arrow Repel Deal", 20, 75);
                        var archerSkill3 = new Skill("Heavy Arrow Deal", 25, 100);
                        var archerSkill = new[] {archerSkill1, archerSkill2, archerSkill3};

                        archer.Setskills(archerSkill);
                        archer.EquipWeapon(DataWeapon.Starterbow);
                        archer.EquipArmorStarter();
                        archer.ShowInfo();

                        Confirmcharacter(archer);
                        archer.Setname();
                        break;
                    case "wizard":

                        var wizard = new Player("Wizard", 1250, 5000, 35, 35, ClassPlayer.Wizard);
                        var wizardSkill1 = new Skill("Cold Bolt", 10, 150);
                        var wizardSkill2 = new Skill("Fire Bolt", 15, 250);
                        var wizardSkill3 = new Skill("Lightning Bolt", 20, 300);
                        var wizardSkill4 = new Skill("Soul Strike", 25, 350);
                        var wizardSkill5 = new Skill("Heaven's Drive", 30, 400);
                        var wizardSkill = new[] {wizardSkill1, wizardSkill2, wizardSkill3, wizardSkill4, wizardSkill5};

                        wizard.Setskills(wizardSkill);
                        wizard.EquipWeapon(DataWeapon.StarterSpellbook);
                        wizard.EquipArmorStarter();
                        wizard.ShowInfo();
                        Confirmcharacter(wizard);
                        wizard.Setname();
                        break;
                    default:

                        Console.WriteLine("Invalid Command !");
                        break;
                }
            }
        }

        private static void Confirmcharacter(Player confirmPlayer)
        {
            Console.WriteLine($"You Select {confirmPlayer.Name}");
            Console.WriteLine("Confirm Select [Yes,No]");

            var confirmcharacter = Console.ReadLine();
            var lowerconfirmcharacter = confirmcharacter.ToLower();

            switch (lowerconfirmcharacter)
            {
                case "yes":
                    _command = true;
                    Player1 = confirmPlayer;
                    Console.Write("\n");
                    break;
                case "no":
                    Console.Write("\n");
                    break;
            }
        }
        
        public static void SelectItem()
        {
            _command = false;
            while (!_command)
            {
                Console.WriteLine("select free consumable items ");
                Console.WriteLine("[1] 2 Lesser Healing Potion ");
                Console.WriteLine("[2] 2 Lesser Mana Potion  ");
                Console.WriteLine("[3] 1 Lesser Healing Potion and 1 Lesser Mana Potion ");

                var selectItem = Console.ReadLine();
                Console.Write("\n");

                switch (selectItem)
                {
                    case "1":
                        Inventory.AddItemin(new List<Item>
                            {DataItem.LesserHealingPotion, DataItem.LesserHealingPotion});
                        _command = true;
                        break;
                    case "2":
                        Inventory.AddItemin(new List<Item> {DataItem.LesserManaPotion, DataItem.LesserManaPotion});
                        _command = true;
                        break;
                    case "3":
                        Inventory.AddItemin(new List<Item> {DataItem.LesserHealingPotion, DataItem.LesserManaPotion});
                        _command = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Command !");
                        break;
                }
            }
        }


        private static void Walk(Player player)
        {
            Console.WriteLine($"=======Round {Round}=======");

            if (Round <= 19)
            {
                var random = new Random();
                var walknumber = random.Next(1, 4);
                switch (walknumber)
                {
                    case 1:
                        Console.WriteLine("Nothing happened");
                        IdleState(player);
                        break;
                    case 2:
                        var enemyumberumber = random.Next(DataEnemy.Enemies.Length);
                        Console.WriteLine($"{player.Name} fighting with {DataEnemy.Enemies[enemyumberumber].Name}.");
                        BattleState(player, DataEnemy.Enemies[enemyumberumber]);
                        IdleState(player);
                        break;
                    case 3:
                        Console.WriteLine("WOW You found treasure");
                        DataRandom.Random(player);
                        break;
                }
            }
            else
            {
                Console.WriteLine($"{player.Name} fighting with {DataEnemy.Krampus.Name}.");
                Console.WriteLine("Fight Him To End Game");
                BattleState(player, DataEnemy.Krampus);
                EndGame = true;
            }
        }

        public static void IdleState(Player player)
        {
            while (!EndGame)
            {
                _command = false;
                Round++;
                while (!_command)
                {
                    Console.WriteLine("What are you going to do next");
                    Console.WriteLine("Walk,Open Inventory,Open Menu,Show Stat,Sleep");
                    var idlestate = Console.ReadLine();
                    var loweridlestate = idlestate.ToLower();
                    Console.Write("\n");
                    switch (loweridlestate)
                    {
                        case "walk":
                            Walk(player);
                            _command = true;
                            break;
                        case "open inventory":
                            Inventory.OpenInventory();
                            _command = true;
                            break;
                        case "open menu":
                            Menu.OpenMenu(player);
                            _command = true;
                            break;
                        case "show stat" :
                            player.ShowInfo();
                            break;
                        case "Sleep" :
                            player.Sleep(player);
                            _command = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Command !");
                            break;
                    }
                }
            }

            Story.EndGame();
        }

        public static void BattleState(Player player, CharacterBase enemy)
        {
            enemy.IsDead = false;
            enemy.Hp = enemy.MaxHp;
            enemy.Mana = enemy.MaxMana;
            while (!player.IsDead && !enemy.IsDead)
            {
                player.Attack(enemy, player);
                if (enemy.IsDead == false)
                {
                    var random = new Random();
                    var randomattack = random.Next(1, 3);
                    switch (randomattack)
                    {
                        case 1:
                            enemy.PhysicalAttack(player);
                            break;
                        case 2:
                            enemy.SkillAttack(player);
                            break;
                    }
                }
            }

            Console.WriteLine("The Fight Is Over\n");
        }
    }
}
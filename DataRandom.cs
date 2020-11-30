using System;
using System.Collections.Generic;

namespace FinalProject
{
    public static class DataRandom
    {
        private static bool _commend;
        private static List<Item> _items = new List<Item>();

        public static void Random(Player player)
        {
            var random = new Random();
            var randomnumber = random.Next(1, 5);

            switch (randomnumber)
            {
                case 1:
                    RandomItem();
                    break;
                case 2:
                    RandomArmour(player);
                    break;
                case 3:
                    RandomWeapon(player);
                    break;
                case 4:
                    var enemyumberumber = random.Next(DataEnemy.Enemies.Length);
                    Console.WriteLine("it's a trap .");
                    Console.WriteLine($"{player.Name} fighting with {DataEnemy.Enemies[enemyumberumber].Name}.");
                    Gameplay.BattleState(player, DataEnemy.Enemies[enemyumberumber]);
                    Gameplay.IdleState(player);
                    break;
            }
        }
        
        public static void RandomItem()
        {
            var random = new Random();
            var itemNumber = random.Next(DataItem.Items.Length);
            var item = DataItem.Items[itemNumber];
            Console.WriteLine($"Really Bad, you found {item.Name}.");
            Item.ShowItem();

            _commend = false;
            while (!_commend)
            {
                Console.WriteLine("You Need add item ?");
                Console.WriteLine("[Yes,No]");
                var additem = Console.ReadLine();
                var loweradditem = additem.ToLower();

                switch (loweradditem)
                {
                    case "yes":
                        _items = Inventory.Items;
                        _items.Add(item);
                        Inventory.AddItemin(_items);
                        _commend = true;
                        break;
                    case "no":
                        _commend = true;
                        break;
                }
            }
        }
        
        private static void RandomArmour(Player player)
        {
            var random = new Random();
            var armourNumber = random.Next(DataArmor.Armours.Length);
            var armour = DataArmor.Armours[armourNumber];
            Console.WriteLine($"Really lucky, you found {armour.Name}.");
            Armour.ShowArmour();

            _commend = false;
            while (!_commend)
            {
                Console.WriteLine("You Need Equip Armor");
                Console.WriteLine("[Yes,No]");
                var equipArmor = Console.ReadLine();
                var lowerEquipArmor = equipArmor.ToLower();

                switch (lowerEquipArmor)
                {
                    case "yes":
                        player.EquipArmor(armour);
                        _commend = true;
                        break;
                    case "no":
                        _commend = true;
                        break;
                }
            }
        }

        private static void RandomWeapon(Player player)
        {
            var random = new Random();
            var weaponNumber = random.Next(DataWeapon.Weapons.Length);
            var weapon = DataWeapon.Weapons[weaponNumber];
            Console.WriteLine($"Really lucky, you found {weapon.Name}.");
            Weapon.ShowWeapon();

            _commend = false;
            while (!_commend)
            {
                Console.WriteLine("You Need Equip Weapon");
                Console.WriteLine("[Yes,No]");
                var equipWeapon = Console.ReadLine();
                var lowerEquipWeapon = equipWeapon.ToLower();

                switch (lowerEquipWeapon)
                {
                    case "yes":
                        player.EquipWeapon(weapon);
                        _commend = true;
                        break;
                    case "no":
                        _commend = true;
                        break;
                }
            }
        }
    }
}
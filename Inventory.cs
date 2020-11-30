using System;
using System.Collections.Generic;

namespace FinalProject
{
    public static class Inventory
    {
        public const int MaximumIteminInventory = 6;
        public static List<Item> Items = new List<Item>();
        public static bool Command;
        public static void AddItemin(List<Item> items)
        {
            if (items.Count < MaximumIteminInventory)
                Items = items;
            else
                Console.WriteLine("Inventory Is Full");
        }
        public static void OpenInventory()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Inventory Is Empty");
            }
            else
            {
                Command = false;
                while (!Command)
                {
                    Console.WriteLine("OpenInventory");
                    Console.WriteLine("Enter Command [ShowItemin,DropItem,UseItem,Quit]");
                    var commedInventory = Console.ReadLine();
                    var lowercommedInventory = commedInventory.ToLower();
                    switch (lowercommedInventory)
                    {
                        case "showitemin":
                            ShowItemin();
                            break;
                        case "dropitem":
                            DropItem();
                            Command = true;
                            break;
                        case "useitem":
                            SelectUseItem();
                            Command = true;
                            break;
                        case "quit":
                            Command = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Command !");
                            Command = true;
                            break;
                    }
                }
            }
        }
        public static void ShowItemin()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Inventory Is Empty");
            }
            else
            {
                for (var i = 0; i < Items.Count; i++) Console.WriteLine($"Items {i + 1} : {Items[i].Name}");
                Console.Write("\n");
            }
        }
        public static void DropItem()
        {
            Command = false;
            while (!Command)
            {
                ShowItemin();
                Console.WriteLine("select item to drop");
                var dropItemNumber = Convert.ToInt64(Console.ReadLine());
                var number = dropItemNumber - 1;
                switch (dropItemNumber)
                {
                    case 1:
                        Console.WriteLine($"You Drop {Items[(Index) number].Name}");
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    case 2:
                        Console.WriteLine($"You Drop {Items[(Index) number].Name}");
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    case 3:
                        Console.WriteLine($"You Drop {Items[(Index) number].Name}");
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    case 4:
                        Console.WriteLine($"You Drop {Items[(Index) number].Name}");
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    case 5:
                        Console.WriteLine($"You Drop {Items[(Index) number].Name}");
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Command !");
                        break;
                }
            }
        }
        public static void SelectUseItem()
        {
            Command = false;
            while (!Command)
            {
                ShowItemin();
                Console.WriteLine("select item to Use");
                var selectUseItem = Convert.ToInt64(Console.ReadLine());
                var number = selectUseItem - 1;
                switch (selectUseItem)
                {
                    case 1:
                        Console.WriteLine($"You Use {Items[(Index) number].Name}");
                        Player.UseItem(Items[(Index) number]);
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    case 2:
                        Console.WriteLine($"You Use {Items[(Index) number].Name}");
                        Player.UseItem(Items[(Index) number]);
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    case 3:
                        Console.WriteLine($"You Use {Items[(Index) number].Name}");
                        Player.UseItem(Items[(Index) number]);
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    case 4:
                        Console.WriteLine($"You Use {Items[(Index) number].Name}");
                        Player.UseItem(Items[(Index) number]);
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    case 5:
                        Console.WriteLine($"You Use {Items[(Index) number].Name}");
                        Player.UseItem(Items[(Index) number]);
                        Items.RemoveAt((int) number);
                        Command = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Command !");
                        break;
                }
            }
        }
    }
}
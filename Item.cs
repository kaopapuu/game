using System;

namespace FinalProject
{
    public class Item
    {
        public static string StaticName;
        public static int StaticHeal;
        public static int StaticRestoreMana;
        public int Heal;
        public string Name;
        public int RestoreMana;


        public Item(string name, int heal, int restoreMana)
        {
            Name = name;
            Heal = heal;
            RestoreMana = restoreMana;
            StaticName = name;
            StaticHeal = heal;
            StaticRestoreMana = restoreMana;
        }

        public static void ShowItem()
        {
            Console.WriteLine($"Item Name : {StaticName}");
            Console.WriteLine($"Item Heal : {StaticHeal}");
            Console.WriteLine($"Item RestoreMana : {StaticRestoreMana}");
        }
    }
}
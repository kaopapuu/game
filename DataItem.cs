namespace FinalProject
{
    public class DataItem
    {
        //Heal Only
        public static readonly Item LesserHealingPotion = new Item("Lesser Healing Potion", 50, 0);
        public static readonly Item HealingPotion = new Item("Healing Potion", 100, 0);
        public static readonly Item GreaterHealingPotion = new Item("Greater Healing Potion", 150, 0);
        public static readonly Item SuperHealingPotion = new Item("Super Healing Potion", 200, 0);

        //RestoreMana Only
        public static readonly Item LesserManaPotion = new Item("Lesser Mana Potion", 0, 50);
        public static readonly Item ManaPotion = new Item("Mana Potion", 0, 100);
        public static readonly Item GreaterManaPotion = new Item("Greater Mana Potion", 0, 150);
        public static readonly Item SuperManaPotion = new Item("Super Mana Potion", 0, 200);

        public static Item[] Items =
        {
            LesserHealingPotion, HealingPotion, GreaterHealingPotion,
            SuperHealingPotion, LesserManaPotion, ManaPotion, GreaterManaPotion, SuperManaPotion
        };
    }
}
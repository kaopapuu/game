namespace FinalProject
{
    public class DataArmor
    {
        //ArmourType.Body
        public static readonly Armour StarterArmor = new Armour("Starter Armor", 5, ArmourType.Body);
        public static readonly Armour WoodArmor = new Armour("Wood Armor", 10, ArmourType.Body);
        public static readonly Armour IronArmor = new Armour("Iron Armor", 20, ArmourType.Body);
        public static readonly Armour SilverArmor = new Armour("Silver Armor", 30, ArmourType.Body);
        public static readonly Armour MeteorArmor = new Armour("Meteor Armor", 40, ArmourType.Body);
        public static readonly Armour CrimsonArmor = new Armour("Crimson Armor", 50, ArmourType.Body);

        //ArmourType.Helmet
        public static readonly Armour StarterHelmet = new Armour("Starter Helmet", 5, ArmourType.Helmet);
        public static readonly Armour WoodHelmet = new Armour("Wood Helmet", 10, ArmourType.Helmet);
        public static readonly Armour IronHelmet = new Armour("Iron Helmet", 20, ArmourType.Helmet);
        public static readonly Armour SilverHelmet = new Armour("Silver Helmet", 30, ArmourType.Helmet);
        public static readonly Armour MeteorHelmet = new Armour("Meteor Helmet", 40, ArmourType.Helmet);
        public static readonly Armour CrimsonHelmet = new Armour("Crimson Helmet", 50, ArmourType.Helmet);

        //ArmourType.Necklace
        public static readonly Armour StarterNecklace = new Armour("Starter Necklace", 5, ArmourType.Necklace);
        public static readonly Armour JellyfishNecklace = new Armour("Jellyfish Necklace", 10, ArmourType.Necklace);
        public static readonly Armour StingerNecklace = new Armour("Stinger Necklace", 20, ArmourType.Necklace);
        public static readonly Armour SharkToothNecklace = new Armour("Shark Tooth Necklace", 30, ArmourType.Necklace);
        public static readonly Armour PygmyNecklace = new Armour("Pygmy Necklace", 40, ArmourType.Necklace);
        public static readonly Armour CrossNecklace = new Armour("Cross Necklace", 50, ArmourType.Necklace);

        //ArmourType.Ring
        public static readonly Armour StarterRing = new Armour("Starter Ring", 10, ArmourType.Ring);
        public static readonly Armour WoodRing = new Armour("Wood Ring", 10, ArmourType.Ring);
        public static readonly Armour IronRing = new Armour("Iron Ring", 20, ArmourType.Ring);
        public static readonly Armour SilverRing = new Armour("Silver Ring", 30, ArmourType.Ring);
        public static readonly Armour MeteorRing = new Armour("Meteor Ring", 40, ArmourType.Ring);
        public static readonly Armour CrimsonRing = new Armour("Crimson Ring", 50, ArmourType.Ring);

        public static Armour[] Armours =
        {
            WoodArmor, WoodHelmet, WoodRing, IronArmor, IronHelmet, IronRing, SilverArmor, SilverHelmet, SilverRing,
            MeteorArmor, MeteorHelmet, MeteorRing, CrimsonArmor, CrimsonHelmet, CrimsonRing, CrossNecklace,
            JellyfishNecklace, SharkToothNecklace, StingerNecklace, PygmyNecklace
        };
    }
}
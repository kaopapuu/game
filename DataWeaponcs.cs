namespace FinalProject
{
    public abstract class DataWeapon
    {
        //WeaponType.Melee
        public static Weapon Startersword = new Weapon("Starter Sword", WeaponType.Melee, 10);
        public static Weapon WoodenSword = new Weapon("Wooden Sword", WeaponType.Melee, 30);
        public static Weapon Coppersword = new Weapon("Copper Sword", WeaponType.Melee, 50);
        public static Weapon BeamSword = new Weapon("Beam Sword", WeaponType.Melee, 70);
        public static Weapon Muramasa = new Weapon("Muramasa", WeaponType.Melee, 80);
        public static Weapon Meowmere = new Weapon("Meowmere", WeaponType.Melee, 100);

        //WeaponType.Range
        public static Weapon Starterbow = new Weapon("Starter Bow", WeaponType.Range, 15);
        public static Weapon Woodenbow = new Weapon("Wooden Bow", WeaponType.Range, 35);
        public static Weapon Coppebow = new Weapon("Copper Bow", WeaponType.Range, 45);
        public static Weapon Beambow = new Weapon("Beam Bow", WeaponType.Range, 50);
        public static Weapon Sniperrifle = new Weapon("Sniper Rifle", WeaponType.Range, 100);
        public static Weapon Uzi = new Weapon("Uzi", WeaponType.Range, 150);

        //WeaponType.Spellbook
        public static Weapon StarterSpellbook = new Weapon("Starter Spellbook", WeaponType.Spellbook, 5);
        public static Weapon WaterBolt = new Weapon("Water Bolt", WeaponType.Spellbook, 15);
        public static Weapon DemonScythe = new Weapon("Demon Scythe", WeaponType.Spellbook, 35);
        public static Weapon CursedFlames = new Weapon("Cursed Flames", WeaponType.Spellbook, 40);
        public static Weapon RazorbladeTyphoon = new Weapon("Razorblade Typhoon", WeaponType.Spellbook, 45);
        public static Weapon MedusaHead = new Weapon("Medusa Head", WeaponType.Spellbook, 50);

        public static Weapon[] Weapons =
        {
            Woodenbow, WoodenSword, WaterBolt, Coppebow, Coppersword, CursedFlames, Beambow,
            BeamSword, Muramasa, Meowmere, Sniperrifle, Uzi, DemonScythe, RazorbladeTyphoon,
            MedusaHead
        };
    }
}
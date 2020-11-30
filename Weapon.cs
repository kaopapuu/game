using System;

namespace FinalProject
{
    public class Weapon
    {
        public static string StaticName;
        public static int StaticAttack;
        public static WeaponType StaticType;
        public int Attack;
        public string Name;
        public WeaponType Type;

        public Weapon(string name, WeaponType type, int attack)
        {
            Name = name;
            Type = type;
            Attack = attack;
            StaticName = name;
            StaticType = type;
            StaticAttack = attack;
        }

        public static void ShowWeapon()
        {
            Console.WriteLine($"Weapon Name : {StaticName}");
            Console.WriteLine($"Weapon type : {StaticType}");
            Console.WriteLine($"Weapon Damage : {StaticAttack}");
        }
    }
}
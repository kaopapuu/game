using System;

namespace FinalProject
{
    public class Armour
    {
        private static string _staticName;
        private static int _staticDef;
        private static ArmourType _staticArmourType;
        public ArmourType ArmourType;
        public int Def;
        public string Name;
        
        public Armour(string name, int def, ArmourType armourType)
        {
            Name = name;
            Def = def;
            ArmourType = armourType;
            _staticName = name;
            _staticDef = def;
            _staticArmourType = armourType;
        }
        
        public static void ShowArmour()
        {
            Console.WriteLine($"Armour Name : {_staticName}");
            Console.WriteLine($"Armour Def : {_staticDef}");
            Console.WriteLine($"Armour ArmourType : {_staticArmourType}");
        }
    }
}
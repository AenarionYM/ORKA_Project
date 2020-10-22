using System;
using System.Collections.Generic;

namespace O.R.K.A._Project_ver._2._0
{
    public class Eq
    {
        Methods methods;
        public List<Item> Items = new List<Item>() { };

        public void ItemsDisplay()
        {
            methods.Clear();
            // actual thing
            /*foreach (Item Item in Items)
            {
                int count = 1;
                Console.WriteLine($"{count}. {Item.name}");
                count++;
            }*/
            
            //For debug only
            {
                foreach (Item Item in Items)
                {
                    int count = 1;
                    Console.WriteLine(
                        $"{count}. " +
                        $"name:{Item.name} " +
                        $"{Item.dmgMinHead} " +
                        $"{Item.dmgMaxHead} " +
                        $"{Item.dmgMinBody} " +
                        $"{Item.dmgMaxBody} " +
                        $"{Item.dmgMinLegs} " +
                        $"{Item.dmgMaxLegs}"
                        );
                    count++;
                }
            }
        }
    }

    public class Item
    {
        public string name;
        public int dmgMinHead;
        public int dmgMaxHead;
        public int dmgMinBody;
        public int dmgMaxBody;
        public int dmgMinLegs;
        public int dmgMaxLegs;
        public bool equipable;
        
        
        public Item
            (string name, 
            bool equipable,
            int parry = 0,
            int dmgMinHead = 0, 
            int dmgMaxHead = 0, 
            int dmgMinBody = 0, 
            int dmgMaxBody = 0, 
            int dmgMinLegs = 0, 
            int dmgMaxLegs = 0)
        {
            this.name = name;
            this.equipable = equipable;
            this.dmgMinHead = dmgMinHead;
            this.dmgMaxHead = dmgMaxHead;
            this.dmgMinBody = dmgMinBody;
            this.dmgMaxBody = dmgMaxBody;
            this.dmgMinLegs = dmgMinLegs;
            this.dmgMaxLegs = dmgMaxLegs;
        }
        //Normal items
        public static Item Jacket = new Item("Kurtka", false);
        public static Item Code = new Item("Kot", false);
        public static Item Milk = new Item("Mlekooo",false);
        public static Item Rope = new Item("Lina", false);
        public static Item CoffeMilk = new Item("Kawamleko", false);
        public static Item BatonOfPower = new Item("Baton of Power", false);
        public static Item DrinkOfYoutk = new Item("Napój of Youth", false);
        public static Item CrispsOfImmortality = new Item("Chipsy of Immortality", false);
        public static Item Dell = new Item("Dell", false);
        public static Item Hp = new Item("HP", false);
        public static Item ThinkPad = new Item("Thinkpad", false);
        public static Item WygasPc = new Item("Laptop Wygasła", false);
        public static Item C4 = new Item("C4", false);
        public static Item KeyTo17 = new Item("Klucz do 17", false);
        public static Item RepairKit = new Item("Kit naprawczy", false);
        public static Item Coin = new Item("Moneta", false);
        public static Item Jbl = new Item("JBL", false);
        public static Item UsbKiller = new Item("Usb killer", false);
        //Weapons
        public static Item Axe = new Item("Siekiera", true, 0, 10, 20, 7, 16, 6, 13);
        public static Item Rabab = new Item("Gaśnica", true, 0, 38, 50, 27, 39, 24, 32);
        public static Item Thermos = new Item("Termos", true, 0, 7, 12, 5, 8, 2, 4);
        public static Item ThermosWater = new Item("Termoswoda", true, 0, 12, 21, 11, 17, 7, 10);
        public static Item ThermosTea = new Item("Termosherbata", true, 0, 10, 19, 9, 16, 6, 8);
        public static Item Extingusher = new Item("Gaśnica", true, 0, 8, 14, 5, 10, 4, 20);
        public static Item Lightsaber = new Item("Lightsaber", true, 0, 31, 44, 23, 35, 21, 32);
        public static Item StaffOfSosnowiec = new Item("Staff of Sosnowiec", true, 0, 29, 37, 24, 34, 21, 29);
        public static Item Secator = new Item("Sekator", true, 0, 5, 9, 3, 6, 2, 4);
        public static Item Hand = new Item("Ręka", true, 0, 3, 7, 2, 3, 1, 2);
        //Shields
        public static Item Desk = new Item("Deska", true, 6);
        public static Item ParryHand = new Item("Ręka", true, 3);
        public static Item DeskUpgraded = new Item("Deska ulepszona", true, 9);
        public static Item Doors = new Item("Drzwi", true, 12);
        public static Item Fap3000 = new Item("Fap3000", true, 15);
    }
}
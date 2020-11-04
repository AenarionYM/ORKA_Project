using System;
using System.Collections.Generic;
using System.Linq;

namespace O.R.K.A._Project_ver._2._0
{
    public class Eq
    {
        public List<Item> Items = new List<Item>() { };
        public List<Item> ItemsDebug = new List<Item>()
        {
            Item.Jacket, 
            Item.Code, 
            Item.Milk, 
            Item.Rope, 
            Item.Dell, 
            Item.Hp, 
            Item.ThinkPad,
            Item.WygasPc,
            Item.BrokenMouse,
            Item.C4,
            Item.KeyTo17,
            Item.RepairKit,
            Item.Coin,
            Item.Jbl,
            Item.UsbKiller,
            Item.CoffeMilk,
            Item.DrinkOfYouth,
            Item.BatonOfPower,
            Item.CrispsOfImmortality,
            Item.Axe,
            Item.Rabab,
            Item.Thermos,
            Item.ThermosWater,
            Item.ThermosTea,
            Item.Extingusher,
            Item.Lightsaber,
            Item.StaffOfSosnowiec,
            Item.Secator,
            Item.Hand,
            Item.Desk,
            Item.DeskUpgraded,
            Item.ParryHand,
            Item.Doors,
            Item.Fap3000
        };
        public Item equippedWeapon;
        public Item equippedShield;
        int count;
        public static int reprimands = 0;

        int[] dmgCalculator(Item item)
        {
            int minDmgChck = Math.Min(item.dmgMinBody, item.dmgMinHead);
            int minDmgShow = Math.Min(minDmgChck, item.dmgMinLegs);
            int maxDmgChck = Math.Max(item.dmgMaxBody, item.dmgMaxHead);
            int maxDmgShow = Math.Max(maxDmgChck, item.dmgMaxLegs);
            int[] dmgArray = {maxDmgShow, minDmgShow};
            return dmgArray;
        }

        void ItemsDebugDispaly()
        {
            Methods.Clear();
            count = 1;
            //Display
            foreach (var item in ItemsDebug)
            {
                Console.WriteLine($"{count}. {item.name}");
                count++;
            }
            Methods.SleepEq();
            Console.WriteLine("\n0. Wyjdź\n");

            //Choose Item
            string eqChoice = Console.ReadLine();
            bool isNumber = int.TryParse(eqChoice, out int eqChoiceInt);
            Methods.Clear();
            
            if (isNumber && eqChoice != "")
            {
                eqChoiceInt--;
                count--;
                
                if (eqChoiceInt == -1) {ItemsDisplay();}
                
                else if (ItemsDebug.Count > eqChoiceInt && ItemsDebug[eqChoiceInt] != null)
                {
                    Console.WriteLine($"Name: {ItemsDebug[eqChoiceInt].name}");
                    Console.WriteLine($"Descirption: {ItemsDebug[eqChoiceInt].description}");
                    if (Items.Contains(ItemsDebug[eqChoiceInt]))
                    {
                        Console.WriteLine("1. Usuń");
                    }
                    else if (!Items.Contains(ItemsDebug[eqChoiceInt]))
                    {
                        Console.WriteLine("1. Dodaj");
                    }
                    else
                    {
                        Console.WriteLine("Zepsute");
                    }
                    Console.WriteLine("2. Cofnij\n");

                    string itemChoice = Console.ReadLine();

                    if (itemChoice == "1" && Items.Contains(ItemsDebug[eqChoiceInt]))
                    {
                        Items.Remove(ItemsDebug[eqChoiceInt]);
                        ItemsDebugDispaly();
                    }                    
                    if (itemChoice == "1" && !Items.Contains(ItemsDebug[eqChoiceInt]))
                    {
                        Items.Add(ItemsDebug[eqChoiceInt]);
                        ItemsDebugDispaly();
                    }

                    else if(itemChoice == "2")
                    {
                        ItemsDebugDispaly();
                    }
                    else
                    {
                        Methods.Els();
                        ItemsDebugDispaly();
                    }
                }
                else
                {
                    Console.WriteLine("Wprowadź poprawną liczbę");
                    Methods.Ent();
                    ItemsDebugDispaly();
                }
            }
            else if (!isNumber && eqChoice != "")
            {
                Methods.Clear();
                Console.WriteLine("Wprowadź poprawną LICZBĘ");
                Methods.Ent();
                ItemsDebugDispaly();
            }
            else
            {
                ItemsDebugDispaly();
            }
        }
        
        public void ItemsDisplay()
        {
            //Może się przydać
            //Item[] itemsArray = Items.ToArray();
            eqStart:
            Methods.Clear();
            Console.WriteLine("EKWIPUNEK \n");
            
            //Items Display
            if (Items.Any())
            {
                count = 1; 
                foreach (var item in Items)
                {
                    Console.WriteLine($"{count}. {item.name}");
                    count++;
                    Methods.SleepEq();
                }
                //Display Weapon
                if (equippedWeapon != null)
                {
                    Console.WriteLine($"\n{count}. Używana broń: {equippedWeapon.name}");
                    Methods.SleepEq();
                    Console.WriteLine($"Obrażenia: {dmgCalculator(equippedWeapon).Min()} - {dmgCalculator(equippedWeapon).Max()}");
                }
                else
                {
                    Console.WriteLine($"\n{count}. Używana broń: Brak");
                    Methods.SleepEq();
                    Console.WriteLine("Obrażenia: 0 - 0");
                }
                Methods.SleepEq();
                //Display Shield
                if (equippedShield != null)
                {
                    Console.WriteLine($"\n{count + 1}. Używana tarcza: {equippedShield.name}");
                    Methods.SleepEq();
                    Console.WriteLine($"Obrona: {equippedShield.parry}");
                }
                else
                {
                    Console.WriteLine($"\n{count + 1}. Używana tarcza: Brak");
                    Methods.SleepEq();
                    Console.WriteLine("Obrona: 0");
                }
                Methods.SleepEq();
                Console.WriteLine("\n0. Wyjdź\n");
            }
            else
            {
                Console.WriteLine("\n*Ekwipunek jest pusty*\n");
                Console.WriteLine("\n0. Wyjdź");
            }
            
            //Choose Item
            string eqChoice = Console.ReadLine();
            bool isNumber = int.TryParse(eqChoice, out int eqChoiceInt);
            Methods.Clear();
            
            if (isNumber && eqChoice != "")
            {
                eqChoiceInt --;
                count --;
                //Exit
                if (eqChoiceInt == -1) {}
                //If weapon or shield equipped
                else if (eqChoiceInt == count && equippedWeapon == null)
                {
                    Console.WriteLine("Nie mam kurwa broni!");
                    Methods.Ent();
                    goto eqStart;
                }
                else if (eqChoiceInt == count + 1 && equippedShield == null)
                {
                    Console.WriteLine("Nie mam kurwa tarczy!");
                    Methods.Ent();
                    goto eqStart;
                }
                else if (eqChoiceInt == count && equippedWeapon != null)
                {
                    Console.WriteLine(equippedWeapon.name);
                    Console.WriteLine(equippedWeapon.description);
                    Console.WriteLine("\n1. Zdejmij");
                    Console.WriteLine("2. Wróć");

                    string itemEquipChoice = Console.ReadLine();

                    if (itemEquipChoice == "1")
                    {
                        Items.Add(equippedWeapon);
                        Console.WriteLine($"Odkładasz {equippedWeapon.name}");
                        equippedWeapon = null;
                        goto eqStart;
                    }

                    else if (itemEquipChoice == "2")
                    {
                        goto eqStart;
                    }

                    else
                    {
                        Methods.Els();
                        goto eqStart;
                    }
                }
                else if (eqChoiceInt == count + 1 && equippedShield != null)
                {
                    Console.WriteLine(equippedShield.name);
                    Console.WriteLine(equippedShield.description);
                    Console.WriteLine("\n1. Zdejmij");
                    Console.WriteLine("2. Wróć");

                    string itemEquipChoice = Console.ReadLine();

                    if (itemEquipChoice == "1")
                    {
                        Items.Add(equippedShield);
                        Console.WriteLine($"Odkładasz {equippedShield.name}");
                        equippedShield = null;
                        goto eqStart;
                    }

                    else if (itemEquipChoice == "2")
                    {
                        goto eqStart;
                    }

                    else
                    {
                        Methods.Els();
                        goto eqStart;
                    }
                }
                //Items use
                else if (Items.Count > eqChoiceInt && Items[eqChoiceInt] != null)
                {
                    Console.WriteLine(Items[eqChoiceInt].description);
                    if (Items[eqChoiceInt].usable)
                    {
                        Console.WriteLine("1. Użyj");
                        Console.WriteLine("2. Wróć\n");
                        
                        string itemChoice = Console.ReadLine();

                        
                        if (itemChoice == "2")
                        {
                            goto eqStart;
                        }
                        
                        else if (itemChoice == "1" && Items[eqChoiceInt].isWeapon)
                        {
                            if (equippedWeapon != null)
                            {
                                Items.Add(equippedWeapon);
                            }
                            equippedWeapon = Items[eqChoiceInt];
                            Console.WriteLine($"Używasz {Items[eqChoiceInt].name}");
                            Items.Remove(Items[eqChoiceInt]);
                            Methods.Ent();
                            goto eqStart;
                        }
                        else if (itemChoice == "1" && Items[eqChoiceInt].isShield)
                        {
                            equippedShield = Items[eqChoiceInt];
                            Console.WriteLine($"Używasz {Items[eqChoiceInt].name}");
                            Items.Remove(Items[eqChoiceInt]);
                            Methods.Ent();
                            goto eqStart;
                        }  
                        
                        else if (Items[eqChoiceInt] == Item.CoffeMilk)
                        {
                            Console.WriteLine("\nŻycie zwiększone");
                            //Dodaje 75 życia
                            Items.Remove(Item.CoffeMilk);
                            Methods.Ent();
                            goto eqStart;
                        }
                        else if (Items[eqChoiceInt] == Item.DrinkOfYouth)
                        {
                            Console.WriteLine("\n*HUMANITY RESTORED*");
                            //Przywraca 60 hp
                            Items.Remove(Item.DrinkOfYouth);
                            Methods.Ent();
                            goto eqStart;
                        }
                        //Dorobić ifa na inCombat
                        else if (Items[eqChoiceInt] == Item.BatonOfPower)
                        {
                            Console.WriteLine("\nSiła zwiększona");
                            //Dodatkowe 10 obrażeń do końca walki
                            Items.Remove(Item.BatonOfPower);
                            Methods.Ent();
                            goto eqStart;
                        }
                        else if (Items[eqChoiceInt] == Item.CrispsOfImmortality)
                        {
                            Console.WriteLine("\nObrona zwiększona");
                            //Dodatkowe 10 obrony do końca walki
                            Items.Remove(Item.CrispsOfImmortality);
                            Methods.Ent();
                            goto eqStart;
                        }
                        
                        else
                        {
                            Methods.Els();
                            goto eqStart;
                        }
                    }
                    else
                    {
                        Console.WriteLine("1. Wróć\n");
                        Console.ReadLine();
                        goto eqStart;
                    }
                }
                //Debug
                else if (eqChoiceInt == 2353)
                {
                    ItemsDebugDispaly();
                }
                else
                {
                    Console.WriteLine("Wprowadź poprawną liczbę");
                    Methods.Ent();
                    goto eqStart;
                }
            }
            else if (!isNumber && eqChoice != "")
            {
                Console.WriteLine("Wprowadź poprawną LICZBĘ");
                Methods.Ent();
                goto eqStart;
            }
            else
            { 
                goto eqStart;
            }
        }
    }
    public class Item
    {
        public string name, description;
        public bool usable, isShield, isWeapon;
        public int parry, 
            dmgMinHead, 
            dmgMaxHead, 
            dmgMinBody, 
            dmgMaxBody, 
            dmgMinLegs, 
            dmgMaxLegs;
        
        public Item
            (string name,
            string description,
            bool usable = false,
            bool isShield = false,
            int parry = 0,
            int dmgMinHead = 0, 
            int dmgMaxHead = 0, 
            int dmgMinBody = 0, 
            int dmgMaxBody = 0, 
            int dmgMinLegs = 0, 
            int dmgMaxLegs = 0,
            bool isWeapon = false)
        {
            this.name = name;
            this.description = description;
            this.usable = usable;
            this.isShield = isShield;
            this.parry = parry;
            this.dmgMinHead = dmgMinHead;
            this.dmgMaxHead = dmgMaxHead;
            this.dmgMinBody = dmgMinBody;
            this.dmgMaxBody = dmgMaxBody;
            this.dmgMinLegs = dmgMinLegs;
            this.dmgMaxLegs = dmgMaxLegs;
            this.isWeapon = isWeapon;
        }

        #region Items Database
        
            #region Normal items
            public static Item Jacket = new Item(
                "Kurtka", 
                "Kurtka twojego kolegi");
            public static Item Code = new Item(
                "Kot", 
                "Kartka z kodem do drzwi");
            public static Item Milk = new Item(
                "Mlekooo", 
                "Karton mleka");
            public static Item Rope = new Item(
                "Lina", 
                "Długa lina, na tyle silna żeby cię utrzymać");
            public static Item Dell = new Item(
                "Dell", 
                "Niezwykle mijający się ze swoim celem laptop gaming'owy");
            public static Item Hp = new Item(
                "HP", 
                "Zwykły hp'ek, naszczęście ma niezmienione hasło do teb-serwis");
            public static Item ThinkPad = new Item(
                "Thinkpad", 
                "Każdy go chce, eksperci twierdzą że 'no, jest dobry' oraz 'laptop jak laptop'");
            public static Item WygasPc = new Item(
                "Laptop Wygasła",
                "Komputer z najlepszym wygaśaczem ekranu");
            public static Item BrokenMouse = new Item(
                "Zepsuta myszka",
                "Mogłaby się przydać do zrobienia kursu sicso, gdyby tylko dało się ją naprawić");
            public static Item C4 = new Item(
                "C4", 
                "Pdobno 'Rozpierdoli to pół domu', w zestawie również zdalny detonator");
            public static Item KeyTo17 = new Item(
                "Klucz do 17", 
                "Klucz z przyczepionym napisem '17'");
            public static Item RepairKit = new Item(
                "Kit naprawczy", 
                "Zestaw naprawczy jednorazowego użytku do myszki z serii 'Pieniądze to nie problem'");
            public static Item Coin = new Item(
                "Moneta", 
                "Moneta o nominale ...zł");
            public static Item Jbl = new Item(
                "Głośnik JBL", 
                "Świetny do imitacji dźwięków pukania");
            public static Item UsbKiller = new Item(
                "Usb killer", 
                "Usb killer, prawdopodobnie należał do Wygasła");        
            #endregion

            #region Usable
            public static Item CoffeMilk = new Item(
                "Kawamleko", 
                "Kawa z mlekiem, powiększa maksymalne zdrowie o 75hp", 
                true);
            public static Item DrinkOfYouth = new Item(
                "Napój of Youth", 
                "Podejrzanie żółty napój, przywraca 60hp",
                true);
            public static Item BatonOfPower = new Item(
                "Baton of Power", 
                "Baton z automatu szkolnego, podnosi obrażenia o 10 do końca walki", 
                true);
            public static Item CrispsOfImmortality = new Item(
                "Chipsy of Immortality", 
                "Paczka powietrza zawierająca 25% chipsów, zwiększa obronę o 10 do końca walki",
                true);
            #endregion

            #region Weapons
            public static Item Axe = new Item(
                "Siekiera", 
                "Siekiera ze stróżówki, 6-20 dmg",
                true, 
                false,
                0, 
                10, 20, 
                7, 16, 
                6, 13,
                true);
            public static Item Rabab = new Item(
                "Rabab", 
                "Rabab, przekazywany tylko wbrańcom, 24-50",
                true, 
                false,
                0, 
                38, 50,
                27, 39,
                24, 32,
                true);
            public static Item Thermos = new Item(
                "Termos", 
                "Wielka aluminiowa pała do trzymania wody, 2-12 dmg",
                true, 
                false,
                0, 
                7, 12, 
                5, 8, 
                2, 4,
                true);
            public static Item ThermosWater = new Item(
                "Termoswoda", 
                "Wielka aluminiowa pała z wodą, 7-21 dmg",
                true, 
                false,
                0, 
                12, 21,
                11, 17, 
                7, 10,
                true);
            public static Item ThermosTea = new Item(
                "Termosherbata", 
                "Wielka aluminiowa pała z herbatką, 6-19 dmg",
                true, 
                false,
                0, 
                10, 19, 
                9, 16, 
                6, 8,
                true);
            public static Item Extingusher = new Item(
                "Gaśnica", 
                "Gaśnica 'pożyczona' z korytarza szkolnego, 4-20 dmg",
                true, 
                false,
                0, 
                8, 14, 
                5, 10, 
                4, 20,
                true);
            public static Item Lightsaber = new Item(
                "Lightsaber", 
                "May the force be with you",
                true, 
                false,
                0, 
                31, 44, 
                23, 35, 
                21, 32,
                true);
            public static Item StaffOfSosnowiec = new Item(
                "Staff of Sosnowiec", 
                "Unikalna ręcznie zrobiona pałka wykonania Sosnowcowego, 21-37",
                true, 
                false,
                0, 
                29, 37, 
                24, 34, 
                21, 29,
                true);
            public static Item Secator = new Item(
                "Sekator",
                "Popularne narzędzie fryzjerskie, 1-9 dmg",
                true, 
                false,
                0, 
                5, 9, 
                3, 6, 
                2, 4,
                true);
            public static Item Hand = new Item(
                "Ręka", 
                "O Boże!!! To moja ręka! 1-7dmg",
                true, 
                false,
                0, 
                3, 7, 
                2, 3, 
                1, 2,
                true);
            #endregion

            #region Shields
            public static Item Desk = new Item(
                "Deska", 
                "Deska pokryta jest tajemniczymi hieroglifami",
                true, 
                true, 
                6);
            public static Item DeskUpgraded = new Item(
                "Deska ulepszona", 
                "Deska ulepszona zdjęciem odByta, +9 obrony",
                true, 
                true, 
                9);
            public static Item ParryHand = new Item(
                "Ręka", 
                "O Boże!!! To moja ręka! 1-7dmg",
                true, 
                true, 
                3);
            public static Item Doors = new Item(
                "Drzwi", 
                "Drzwi, miejmy nadzieje że są bardziej wytrzymałe niż zawiasy, +12 obrony",
                true, 
                true, 
                12);
            public static Item Fap3000 = new Item(
                "Fap3000", 
                "Własnoręcznie stoworzony laptop, świetny do obrony, +15 obrony",
                true, 
                true, 
                15);
            #endregion
        
        #endregion
    }
}
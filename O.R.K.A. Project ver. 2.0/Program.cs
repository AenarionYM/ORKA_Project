using System;

namespace O.R.K.A._Project_ver._2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konstruktory Klas//
            Menu menu = new Menu();
            Eq eq = new Eq();
            
            //Unlocker'y
            bool dyrkaWBramie = true;
            bool loop = false;
            bool zbyszekRatuje = false;
            
            //Achivments
            bool niespostrzezony = false;
            bool segregacja = false;
            
            //Inty
            int toiletEvent = 1;
            
            //Wstęp do gry
            Methods.Clear();
            Console.WriteLine("Witaj w Project O.R.K.A.!");
            Methods.Sleep(350);
            Console.WriteLine("Jest to gra textowa w której wcielasz się w frajera który chodzi do TEB'u");
            Methods.Sleep(100);
            Console.WriteLine("Pomiędzy lekcjami spierdoliłeś do Ropuszki po Gorącego Psa z extra SSSOOOSSS");
            Methods.Sleep(200);
            Console.WriteLine("Reszte dowiesz(lub też nie) się podczas gry.");
            Methods.Sleep(200);
            Console.WriteLine("Miłej zabawy! - Zarząd TEB Studio");
            Methods.Ent();
            Methods.Clear();
            //Menu
            menu:
            menu._Menu();
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Console.WriteLine("Zapraszam!");
                Methods.Ent();
                goto front;
                
            }
            else if (menuChoice == "2")
            {
                Console.WriteLine("Zapraszam ponownie!");
                Methods.Ent();
                goto menu;
            }
            else if (menuChoice == "3")
            {
                Console.WriteLine("No raczej nie");
                Methods.Ent();
                goto menu;
            }
            else if (menuChoice == "4")
            {
                Console.WriteLine("No xD");
                Methods.Ent();
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Jak ty głupi");
                Methods.Ent();
                goto menu;            
            }

            //Przed budynkiem
            front:
            {
                
             Methods.Clear();
             Console.WriteLine("Stoisz przed głównym budynkiem Technikum TEB Edukacja w Bielsku");
             Methods.Sleep(500);
             Console.WriteLine("Co robisz?");
             Methods.Sleep(500);
             Console.WriteLine("1. Wchodzisz");
             Methods.Sleep(500);
             Console.WriteLine("2. Odchodzisz");
             string choiseToEnter = Console.ReadLine();

             if (choiseToEnter == "1")
             {
                 Console.WriteLine("Oł szit hir łi goł agen");
                 if (dyrkaWBramie == true)
                 {
                     dyrkaWBramie = false;
                     Methods.Ent();
                     Methods.Clear();
                     Console.WriteLine("Wchodzisz do szkoły");
                     Methods.Sleep(1000);
                     goto dyrkaGate;
                 }
                 else
                 {
                     Methods.Ent();
                     Methods.Clear();
                     goto gate;
                 }
             }
             
             else if (choiseToEnter == "2")
             {
                Console.WriteLine("Patrzysz na szkołę"); 
                Methods.Sleep(500);
                Console.WriteLine("*A... Pierdole*");
                Methods.Sleep(500);
                Console.WriteLine("Odchodzisz");
                Methods.Sleep(500);
                Console.Write(".");
                Methods.Sleep(500);
                Console.Write(".");
                Methods.Sleep(500);
                Console.Write(".");
                Environment.Exit(1);
             }
             
             else if (choiseToEnter == "1337")
             {
                 eq.Items.Add(Item.Doors);
                 eq.Items.Add(Item.Desk);
                 eq.Items.Add(Item.BatonOfPower);
                 eq.Items.Add(Item.CrispsOfImmortality);
                 eq.Items.Add(Item.Code);
                 Methods.Clear();
                 eq.ItemsDisplay();
                 goto front;
             }

             else
             {
                 Methods.Els();
                 goto front;
             }
             
            }
            
            //Dyrka w Bramie
            dyrkaGate:
            {
                Random achivmentDyrkaWBramie = new Random();
                int _achivmentDyrkaWBramie = achivmentDyrkaWBramie.Next(100);
                
                if (_achivmentDyrkaWBramie < 95)
                {
                    Methods.Sleep(500);
                    Console.WriteLine("Dyrka: A co ty tutaj robisz");
                    Methods.Sleep(500);
                    Console.WriteLine("Ty:yyyy...jaa....ni..");
                    Methods.Sleep(500);
                    Console.WriteLine("Dyrka: Byłeś w Ropuszce.");
                    Methods.Sleep(500);
                    Console.WriteLine("Dyrka: To znaczy nagana");
                    Methods.Sleep(500);
                    Console.WriteLine("A teraz WON na lekcje!!!!");
                    Methods.Sleep(500);
                    Console.WriteLine("TIP: Dostałeś naganę, trzy takowe oznaczają koniec gry.");
                    Methods.Sleep(500);
                    Methods.Rep();
                    Methods.Ent();
                }
                else
                {
                    Console.WriteLine("Zostałeś niespostrzeżony");
                    Methods.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Achievement Get: Niespostrzeżony");
                    Console.ResetColor();
                    Console.WriteLine(" ");
                    Methods.Ent();
                    niespostrzezony = true;
                    Methods.Clear();
                    Methods.Sleep(500);
                }
            }
            
            //Brama
            gate:
            {
                Methods.Clear();
                Console.WriteLine("Znajdujesz się w przedsionku");
                Methods.Sleep(500);
                Console.WriteLine("Widzisz dwie drogi");
                Methods.Sleep(500);
                Console.WriteLine("1. Schody na lewo");
                Methods.Sleep(500);
                Console.WriteLine("2. Schody na prawo");
                Methods.Sleep(500);
                Console.WriteLine("3. Wyjście");
                Methods.Sleep(500);
                Console.WriteLine("4. Ekwipunek");

                string choiseGate = Console.ReadLine();
                
                if (choiseGate == "1")
                {
                    Console.WriteLine("Postanawisz wejść po schodach na lewo");
                    Methods.Ent();
                    Methods.Clear();
                    Methods.Sleep(500);
                    goto groundFloor;
                }
                else if (choiseGate == "2" && !eq.Items.Contains(Item.Code))
                {
                    Console.WriteLine("*Zamknięte*");
                    Methods.Sleep(500);
                    Console.WriteLine("Kurwa, dalej niewiem jaki jest ten kod to szatni");
                    Methods.Ent();
                    Methods.Clear();
                    Methods.Sleep(500);
                    goto gate;
                }
                else if (choiseGate == "2" && eq.Items.Contains(Item.Code))
                {
                    Console.WriteLine("*beep*");
                    Methods.Sleep(500);
                    Console.WriteLine("Otwierasz drzwi i schodzisz do Lochów");
                    Methods.Ent();
                    Methods.Clear();
                    Methods.Sleep(500);
                    goto basement;
                }
                else if (choiseGate == "3")
                {
                    Console.WriteLine("Wychodzisz na zewnątrz");
                    Methods.Ent();
                    Methods.Clear();
                    Methods.Sleep(500);
                    goto front;
                }
                else if (choiseGate == "4")
                { 
                    eq.ItemsDisplay();
                    goto gate;

                }
                else
                {
                    Methods.Els();
                    goto gate;
                }
            }
            
            //Korytarz parter
            groundFloor:
            {
                Methods.Clear();
                Methods.Sleep(500);
                Console.WriteLine("1. Sala 1");
                Methods.Sleep(500);
                Console.WriteLine("2. Siadacze");
                Methods.Sleep(500);
                Console.WriteLine("3. Pokój nauczycielski");
                Methods.Sleep(500);
                Console.WriteLine("4. Kible");
                Methods.Sleep(500);
                Console.WriteLine("5. Sala Fryzjerska");
                Methods.Sleep(500);
                Console.WriteLine("6. Sekretariat");
                Methods.Sleep(500);
                Console.WriteLine("7. Sala Dentystyczna");
                Methods.Sleep(500);
                Console.WriteLine("8. Automat z Kawą");
                Methods.Sleep(500);
                Console.WriteLine("9. Dispenser z wodą");
                Methods.Sleep(500);
                Console.WriteLine("10. Zinwestyguj gaśnice");
                Methods.Sleep(500);
                Console.WriteLine("11. Zawróć");
                Methods.Sleep(500);
                Console.WriteLine("12. Schody na górę");
                Methods.Sleep(500);
                Console.WriteLine("13. Ekwipunek");

                string choiceGround = Console.ReadLine();
                
                //Sala 1
                if (choiceGround == "1")
                {
                    if (!eq.Items.Contains(Item.Jacket))

                    {
                        Methods.Clear();
                        Console.WriteLine("Wchodzisz do Sali 1");
                        Methods.Sleep(500);
                        Console.WriteLine("Przez przypadek wpadasz na Apel");
                        Methods.Sleep(500);
                        Console.WriteLine("Dyrka zauważa cię");
                        Methods.Sleep(500);
                        Console.WriteLine("a kolejno rzecze:");
                        Methods.Sleep(500);
                        Console.WriteLine("Dyrka: Ooo, Akurat miałam ci dać naganę");
                        Methods.Sleep(500);
                        Methods.Rep();
                        goto groundFloor;
                    }
                    
                    if (eq.Items.Contains(Item.Jacket))
                    {
                        Methods.Clear();
                        Console.WriteLine("Otwierasz drzwi, w środku jest apel");
                        Methods.Sleep(500);
                        Console.WriteLine("Dyrka zauważa cię,");
                        Methods.Sleep(500);
                        Console.WriteLine("ale dzięki kurtce twego 2 metrowego kolegi nie jest w stanie cię rozpoznać");
                        Methods.Sleep(500);
                        Console.WriteLine("korzystając z okazji szybko wychodzisz");
                        Methods.Ent();
                        goto groundFloor;
                    }
                }                
                //Siadacze
                else if (choiceGround == "2")
                {
                        if (!loop)
                        {
                            Console.WriteLine("Wszystkie  siadacze są zajęte");
                            Methods.Ent();
                            goto groundFloor;
                        }
                        else
                        {
                            Console.WriteLine("Siadasz na siadaczu i się regenerujesz");
                            Methods.Sleep(500);
                            Console.WriteLine("*Odnawiasz 25hp*");
                            //display_HP += 25;
                            Methods.Ent();
                            goto groundFloor;
                        }
                }          
                //Pokój nauczycielski
                else if (choiceGround == "3")
                {
                    Methods.Clear();
                    Console.WriteLine("Przez uchylone drzwi widzisz panią Marzenę Brat Zakonny");
                    Methods.Sleep(500);
                    Console.WriteLine("Gdyby tylko dało się ją wywabić");
                    Methods.Sleep(500);
                    Methods.Ent();
                    goto groundFloor;
                }                
                //Kible
                else if (choiceGround == "4")
                {
                    if (toiletEvent == 1)
                    {
                        Methods.Clear();
                        Console.WriteLine("Wkraczasz do toalet prawdziwych męszczyzn");
                        Methods.Sleep(500);
                        Console.WriteLine("Wchodzisz do kabiny by zastanowić się nad sensem swego żałosnego istnienia");
                        Methods.Sleep(500);
                        Console.WriteLine("Nagle słyszysz: *fap**fap**fap*");
                        Methods.Sleep(500);
                        Console.WriteLine("Zaglądzasz przez góre kabiny i widzisz");
                        Methods.Sleep(500);
                        Methods.Sleep(500);
                        Methods.Sleep(500);
                        Console.WriteLine("Pana Kruka");
                        Methods.Sleep(500);
                        Console.WriteLine("Szybko uciekasz by cię nie zauważył");
                        Methods.Sleep(500);
                        Methods.Ent();
                        toiletEvent++;
                        Methods.Clear();
                        goto groundFloor;
                    }
                    
                    else if (toiletEvent == 2 && zbyszekRatuje == false)
                    {
                        Methods.Clear();
                        Console.WriteLine("Wchodzisz do toalet i widzisz Horacego i Bonifacego wciągających Tobake");
                        Methods.Sleep(500);
                        Console.WriteLine("Witasz się z nimi, gdy do toalet wparowuje pan doktor reformowany Bielmar i rzecze:");
                        Methods.Sleep(500);
                        Console.WriteLine("RAZ...DWA...TRZY... kto wciąga tabake ma się przyznać bo inaczej wszyscy dostają po naganie");
                        Methods.Sleep(500);
                        Console.WriteLine("Twoi znajomi wspólnie oskarżyli o to ciebie");
                        Methods.Sleep(500);
                        Methods.Rep();
                        Methods.Ent();
                        toiletEvent++;
                        Methods.Clear();
                        goto groundFloor; 
                        ////////////toiletEvent dalszy nie jest jeszcze zrobiony z powodu niechęci do zrobienia jego////////////////
                    }
                    
                    else if (toiletEvent == 2 && zbyszekRatuje == true)
                    {
                        Console.WriteLine("Wchodzisz do toalet i widzisz Horacego i Bonifacego wciągających Tobake");
                        Methods.Sleep(500);
                        Console.WriteLine("Witasz się z nimi, gdy do toalet wparowuje pan doktor reformowany Bielmar i rzecze:");
                        Methods.Sleep(500);
                        Console.WriteLine("RAZ...DWA...TRZY... kto wciąga tabake ma się przyznać bo inaczej wszyscy dostają po naganie");
                        Methods.Sleep(500);
                        Console.WriteLine("Twoi znajomi wspólnie oskarżyli o to ciebie");
                        Methods.Sleep(500);
                        Console.WriteLine("W tym momencie słysząc co się dzieje, wchodzi ZBYSZEK himself");
                        Methods.Sleep(500);
                        Console.WriteLine("Zbyszek strzela Bielmarowi w PYSK wyciaga go za fraki i kulturalnie wrzuca do kontenera z odpadami naturalnymi #segragacja ");
                        Methods.Sleep(500);
                        Console.WriteLine("Horacy i Bonifacy dostają w PYSK od Zbyszka");
                        Methods.Sleep(500);
                        Console.WriteLine("Wychodzisz ze Zbyszkiem na korytarz");
                        Methods.Sleep(500);
                        Console.WriteLine("Achivment get: #segregacja");
                        segregacja = true;
                        Methods.Ent();
                        toiletEvent++;
                        Methods.Clear();
                        goto groundFloor;
                    }
                    
                    else if (toiletEvent == 3)
                    {
                        Methods.Clear();
                        Console.WriteLine("Idziesz się odlać do pisuaru");
                        Methods.Sleep(500);
                        Console.WriteLine("Szczając widzisz TAJEMNICZE GÓWNO na podłodze");
                        Methods.Sleep(500);
                        Console.WriteLine("Podchodzisz by zbadać sprawę, gdy do kibli wchodzi nagle po swej mistyczniej 'nieobecności'");
                        Methods.Sleep(1000);
                        Console.WriteLine("Świerszcz w Czynie");
                        Methods.Sleep(500);
                        Console.WriteLine("Wita się z tobą z daleka, próbując podać ci ręke poślizguje się na tym ów tajemniczym gównie");
                        Methods.Sleep(500);
                        Console.WriteLine("Rozbija se swój głupi ryj poczym odchodzi w strone drzwi");
                        Methods.Sleep(500);
                        Console.WriteLine("Wykrzykując przy tym: 'Kurwa', 'japierdole', 'to jest pojebane'");
                        Methods.Ent();
                        toiletEvent++;
                        Methods.Clear();
                        goto groundFloor;
                    }
                    
                    else if (toiletEvent > 3)

                    {
                        Methods.Clear();
                        Console.WriteLine("Po co tu przyszedłem");
                        Methods.Sleep(500);
                        Console.WriteLine("A... Zmierzam w tył...");
                        Methods.Sleep(500);
                        Methods.Ent();
                        Methods.Clear();
                        goto groundFloor;
                    }
                }                
                //Sala Fryzjerska
                else if (choiceGround == "5")
                {
                    
                }                
                //Sekretariat
                else if (choiceGround == "6")
                {
                    
                }                
                //Sala Dentystyczna
                else if (choiceGround == "7")
                {
                    
                }                
                //Automat z Kawą
                else if (choiceGround == "8")
                {
                    
                }                
                //Dispenser z wodą
                else if (choiceGround == "9")
                {
                    
                }                
                //Zinwestyguj gaśnice
                else if (choiceGround == "10")
                {
                    Methods.Clear();
                    eq.Items.Add(Item.Extingusher);
                    Console.WriteLine("Zauważasz gaśnice");
                    Methods.Sleep(500);
                    Console.WriteLine("Uważając że, jest przydatna zabierasz ją");
                    Methods.Sleep(500);
                    Console.WriteLine("*Zdobywasz gaśnice*");
                    Methods.Ent();
                    goto groundFloor;
                }                
                //Zawróć
                else if (choiceGround == "11")
                {
                    
                }                
                //Schody na górę
                else if (choiceGround == "12")
                {
                    
                }                
                //Ekwipunek
                else if (choiceGround == "13")
                {
                    Methods.Clear();
                    eq.ItemsDisplay();
                    goto groundFloor;
                }
            }
            
            //Piwnica
            basement:
            {
                
            }
        }
    }
}
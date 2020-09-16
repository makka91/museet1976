using System;
using System.Diagnostics;

namespace museum1976
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomChoice;
            int score = 0;
            int roomNumber = 8;
            int onFire;

            bool enterMusem = true;
            bool evacuate = false;
            
            var randomFire = new Random();

            Stopwatch stopWatch = new Stopwatch();


            void FireStarter()
            {
                Console.WriteLine("Det brinner! Alla måste lämna byggnaden.");
                Console.WriteLine("Evakuera genom att passera så få rum som möjligt.");
                evacuate = true;
                score = 11;
            }

            Console.WriteLine("Välkommen till museet.");
            Console.WriteLine("Vi har 7 olika rum med olika konstverk i.");
            Console.WriteLine("Du befinner dig utanför entren. Välj 1 för att kliva in i första rummet.");

            while (enterMusem)
            {
                onFire = randomFire.Next(1, 11);
                Console.Write("Ange ditt val: ");
                bool tryChoice = Int32.TryParse(Console.ReadLine(), out roomChoice);

                switch (roomChoice)
                {
                    case 1:
                        if (roomNumber == 8 || roomNumber == 2)
                        {
                            roomNumber = 1;
                            Console.WriteLine("Du befinner dig i rum 1 och kan välja mellan att gå ut (8) och att gå till rum 2");

                            if (onFire == 10 && evacuate == false)
                            {
                                stopWatch.Start();
                                FireStarter();
                            }
                            else if (evacuate == true)
                            {
                                score--;
                                Console.WriteLine("Du har just nu " + score + " poäng.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Här hänger Mona Lisa");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Nu blev det fel");
                        }
                        break;

                    case 2:
                        if (roomNumber == 1 || roomNumber == 3 || roomNumber == 6)
                        {
                            roomNumber = 2;
                            Console.WriteLine("Du befinner dig i rum 2 och kan välja mellan att gå till rum 3,6 eller 1.");

                            if (onFire == 10 && evacuate == false)
                            {
                                stopWatch.Start();
                                FireStarter();
                            }
                            else if (evacuate == true)
                            {
                                score--;
                                Console.WriteLine("Du har just nu " + score + " poäng.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Här hänger Starry Night");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du har angett ett felaktigt alternativ");
                        }
                        break;

                    case 3:
                        if (roomNumber == 2 || roomNumber == 4)
                        {
                            roomNumber = 3;
                            Console.WriteLine("Du befinner dig i rum 3 och kan välja mellan att gå till rum 4 eller 2.");

                            if (onFire == 10 && evacuate == false)
                            {
                                stopWatch.Start();
                                FireStarter();
                            }
                            else if (evacuate == true)
                            {
                                score--;
                                Console.WriteLine("Du har just nu " + score + " poäng.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Här hänger The Scream");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du har angett ett felaktigt alternativ");
                        }
                        break;

                    case 4:
                        if (roomNumber == 3)
                        {
                            roomNumber = 4;
                            Console.WriteLine("Du befinner dig i rum 4 och har nått en återvändsgränd. Gå tillbaks till rum 3 för att fortsätta.");

                            if (onFire == 10 && evacuate == false)
                            {
                                stopWatch.Start();
                                FireStarter();
                            }
                            else if (evacuate == true)
                            {
                                score--;
                                Console.WriteLine("Du har just nu " + score + " poäng.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Här hänger The Night Watch");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du har angett ett felaktigt alternativ");
                        }
                        break;

                    case 5:
                        if (roomNumber == 6)
                        {
                            roomNumber = 5;
                            Console.WriteLine("Du befinner dig i rum 5 och har nått en återvändsgränd. Gå tillbaks till rum 6 för att fortsätta.");

                            if (onFire == 10 && evacuate == false)
                            {
                                stopWatch.Start();
                                FireStarter();
                            }
                            else if (evacuate == true)
                            {
                                score--;
                                Console.WriteLine("Du har just nu " + score + " poäng.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Här hänger The Kiss");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du har angett ett felaktigt alternativ");
                        }
                        break;

                    case 6:
                        if (roomNumber == 2 || roomNumber == 5 || roomNumber == 7)
                        {
                            roomNumber = 6;
                            Console.WriteLine("Du befinner dig i rum 6 och kan välja mellan att gå till rum 2,5 eller 7.");

                            if (onFire == 10 && evacuate == false)
                            {
                                stopWatch.Start();
                                FireStarter();
                            }
                            else if (evacuate == true)
                            {
                                score--;
                                Console.WriteLine("Du har just nu " + score + " poäng.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Här hänger The Last Supper");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du har angett ett felaktigt alternativ");
                        }
                        break;

                    case 7:
                        if (roomNumber == 6)
                        {
                            roomNumber = 7;
                            Console.WriteLine("Du befinner dig i rum 7 och har nått en återvändsgränd. Gå tillbaks till rum 6 för att fortsätta.");

                            if (onFire == 10 && evacuate == false)
                            {
                                stopWatch.Start();
                                FireStarter();
                            }
                            else if (evacuate == true)
                            {
                                score--;
                                Console.WriteLine("Du har just nu " + score + " poäng.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Här hänger The Great Wave Off Kanagawa");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du har angett ett felaktigt alternativ");
                        }
                        break;

                    case 8:
                        if (roomNumber == 1 || roomNumber == 8)
                        {
                            roomNumber = 8;

                            if (evacuate == true)
                            {
                                stopWatch.Stop();

                                Console.WriteLine("Du har hittat ut och klarat dig från branden. Din slutgiltiga poäng blev " + score);

                                TimeSpan ts = stopWatch.Elapsed;
                                string elapsedTime = String.Format("{0:00}:{1:00}",
                                    ts.Seconds,
                                    ts.Milliseconds / 10);
                                Console.WriteLine("Det tog dig " + elapsedTime + " sekunder att hitta ut");

                                Console.WriteLine("Välj 8 igen för att avsluta eller 1 för att gå in i museet på nytt.");
                                evacuate = false;
                                break;
                            }
                            else
                            {
                                enterMusem = false;
                                Console.WriteLine("Du har lämnat museet.");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du har angett ett felaktigt alternativ");
                        }
                        break;

                    case 9:
                        Console.WriteLine("Du har stängt ned programmet");
                        enterMusem = false;
                        break;

                    default:
                        Console.WriteLine("Du måste ange en siffra mellan 1 och 8.");
                        break;
                }
            }
        }
    }
}
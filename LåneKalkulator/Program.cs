using System;

namespace LåneKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Walla Børre!");
            Console.WriteLine("Velkommen til lånekalkulatoren. Velg  \'1\' for bolig. Velg \'2\' for Kjøretøy.");
            int kalkulatorValg = Convert.ToInt32(Console.ReadLine());
            float ønsketLån = 0.0f;
            float EgenKapital = 0.0f;
            Console.BackgroundColor = ConsoleColor.Red;
            if (kalkulatorValg == 1) Console.WriteLine("Du har valgt bolig kalkulatoren");
            if (kalkulatorValg == 2) Console.WriteLine("Du har valgt kjøretøy kalkulatoren");
            bool skrevetNedbetalingstidEllerIkke = true;
            int nedbetalingstid = 0;


            if (kalkulatorValg > 2)
            {
                Console.WriteLine("Ugyldig valg, Velg et gyldig valg.  Velg  \'1\' for bolig. Velg \'2\' for Kjøretøy.");
                kalkulatorValg = Convert.ToInt32(Console.ReadLine());
            }

            if (kalkulatorValg == 1)
            {
                Console.WriteLine("du kan låne opp til 2.500.000kr");
                Console.WriteLine("Hva er din ønsket lånesum?");
                ønsketLån = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hvor mye egenkapital har du?");
                EgenKapital = Convert.ToInt32(Console.ReadLine());

                if (EgenKapital <= 50000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange års nedbetaling ønsker du? Maks 30 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }

                else if (EgenKapital > 50000 && EgenKapital <= 100000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 30 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else if (EgenKapital > 100000 && EgenKapital <= 150000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 30 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else if (EgenKapital > 150000 && EgenKapital <= 200000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 30 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else if (EgenKapital > 200000 && EgenKapital <= 250000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 30 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else if (EgenKapital > 2500000 && EgenKapital <= 300000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 30 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 30 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                while (skrevetNedbetalingstidEllerIkke)
                {
                    if (nedbetalingstid <= 5)
                    {
                        Console.WriteLine("Du har valgt en nedbetaling på " + nedbetalingstid + " år");
                        skrevetNedbetalingstidEllerIkke = false;
                    }
                    else if (nedbetalingstid > 5 && nedbetalingstid <= 10)
                    {
                        Console.WriteLine("Du har valgt en nedbetaling på " + nedbetalingstid + " år");
                        skrevetNedbetalingstidEllerIkke = false;
                    }
                    else if (nedbetalingstid > 10 && nedbetalingstid <= 30)
                    {
                        Console.WriteLine("Du har valgt en nedbetaling på " + nedbetalingstid + " år");
                        skrevetNedbetalingstidEllerIkke = false;
                    }
                    else if (nedbetalingstid > 30)
                    {
                        Console.WriteLine(nedbetalingstid + " Ugyldig valg av nedbetalingstid. Velg gyldig nedbetalingstid");
                        nedbetalingstid = Convert.ToInt32(Console.ReadLine());

                    }
                }
            }

            if (kalkulatorValg == 2)
            {
                Console.WriteLine("du kan låne opp til 200.000kr");
                Console.WriteLine("Hva er din ønsket lånesum?");
                ønsketLån = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hvor mye egenkapital har du?");
                EgenKapital = Convert.ToInt32(Console.ReadLine());

                if (EgenKapital <= 5000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange års nedbetaling ønsker du? Maks 15 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }

                else if (EgenKapital > 5000 && EgenKapital <= 10000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 15 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else if (EgenKapital > 10000 && EgenKapital <= 20000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 15 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else if (EgenKapital > 20000 && EgenKapital <= 40000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 15 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else if (EgenKapital > 40000 && EgenKapital <= 50000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 15 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else if (EgenKapital > 50000 && EgenKapital <= 70000)
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 15 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Du har en egenkapital på " + EgenKapital + ". Hvor mange år nedbetaling ønsker du? Maks 15 år.");
                    nedbetalingstid = Convert.ToInt32(Console.ReadLine());
                }
                while (skrevetNedbetalingstidEllerIkke)
                {
                    if (nedbetalingstid <= 1)
                    {
                        Console.WriteLine("Du har valgt en nedbetaling på " + nedbetalingstid + " år");
                        skrevetNedbetalingstidEllerIkke = false;
                    }
                    else if (nedbetalingstid > 1 && nedbetalingstid <= 3)
                    {
                        Console.WriteLine("Du har valgt en nedbetaling på " + nedbetalingstid + " år");
                        skrevetNedbetalingstidEllerIkke = false;
                    }
                    else if (nedbetalingstid > 3 && nedbetalingstid <= 7)
                    {
                        Console.WriteLine("Du har valgt en nedbetaling på " + nedbetalingstid + " år");
                        skrevetNedbetalingstidEllerIkke = false;
                    }
                    else if (nedbetalingstid > 7 && nedbetalingstid <= 15)
                    {
                        Console.WriteLine("Du har valgt en nedbetaling på " + nedbetalingstid + " år");
                        skrevetNedbetalingstidEllerIkke = false;
                    }
                    else if (nedbetalingstid > 15)
                    {
                        Console.WriteLine(nedbetalingstid + " Ugyldig valg av nedbetalingstid. Velg gyldig nedbetalingstid");
                        nedbetalingstid = Convert.ToInt32(Console.ReadLine());

                    }
                }
            }
            //---
            float sum = ønsketLån - EgenKapital;
            double nedbetalingsSum = 0;


            Console.WriteLine("Du har en egenkapital på: " + EgenKapital + "kr, og et ønsket lånebeløp på: " + ønsketLån + "kr. Du ønser da å låne en sum på: " + sum);
            Console.WriteLine("Her er din totalsum inkluder rente");

            if (kalkulatorValg == 1) //bolig 0 - 5 rente på 7% | 5 - 10 rente på 4.5% 10 - 30 rente på 2,3%
            {
                if (nedbetalingstid <= 5)
                {
                    nedbetalingsSum = ((sum * 1.7) * nedbetalingstid);
                }
                else if (nedbetalingstid > 5 && nedbetalingstid <= 10)
                {
                    nedbetalingsSum = ((sum * 1.45) * nedbetalingstid);

                }
                else if (nedbetalingstid > 10 && nedbetalingstid <= 30)
                {
                    nedbetalingsSum = ((sum * 1.23) * nedbetalingstid);

                }
            }
            if (kalkulatorValg == 2) //kjøretøy 1 - 3 rente på 13.7% | 3 - 7 rente på 11.2% 7 - 15 rente på 7,3%
            {
                if (nedbetalingstid <= 3)
                {
                    nedbetalingsSum = ((sum * 1.137) * nedbetalingstid);

                }
                else if (nedbetalingstid > 3 && nedbetalingstid <= 7)
                {
                    nedbetalingsSum = ((sum * 1.112) * nedbetalingstid);

                }
                else if (nedbetalingstid > 7 && nedbetalingstid <= 15)
                {
                    nedbetalingsSum = ((sum * 1.73) * nedbetalingstid);

                }
            }
            Console.WriteLine("du har fått invilget ett lån på: " + ønsketLån + " med en nedbetalingssum på: " + nedbetalingsSum + "kr");


        }
    }
}


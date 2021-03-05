using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSamen
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int oefening = Input();
                Console.WriteLine($"Oefening {oefening}: ");
                switch (oefening)
                {
                    case 1:
                        {
                            int[] getallen = new int[10];

                            for (int i = 0; i < getallen.Length; i++)
                            {
                                getallen[i] = i + 1;
                                Console.Write(getallen[i] + " ");
                            }
                        }
                        break;
                    case 2:
                        {
                            int[] getallen = new int[100];

                            for (int i = 0; i < getallen.Length; i++)
                            {
                                getallen[i] = getallen.Length - i;
                                Console.Write(getallen[i] + " ");
                            }
                        }
                        break;

                    case 3:
                        {
                            char[] alfabet = new char[26];

                            for (int i = 0; i < alfabet.Length; i++)
                            {
                                Console.WriteLine(Convert.ToChar(i + 'a'));
                            }
                        }
                        break;

                    case 4:
                        {
                            int[] randomGetal = new int[20];

                            Random r = new Random();

                            for (int i = 0; i < randomGetal.Length; i++)
                            {
                                randomGetal[i] = r.Next(1, 100);
                                Console.WriteLine(randomGetal[i]);
                            }
                        }
                        break;

                    case 5:
                        {
                            bool[] boolArray = new bool[30];

                            for (int i = 0; i < boolArray.Length; i++)
                            {
                                boolArray[i] = (i % 2 == 0);
                                Console.WriteLine(boolArray[i]);
                            }
                        }
                        break;

                    case 6:
                        {
                            int[] getallen = new int[10];
                            for (int i = 0; i < getallen.Length; i++)
                            {
                                Console.Write($"Getal {i + 1}: ");
                                int input = Convert.ToInt32(Console.ReadLine());
                                getallen[i] = input;
                            }
                            Console.WriteLine($"Som van ingegeven getallen: {getallen.Sum()}");
                            Console.WriteLine($"Gemiddelde van ingegeven getallen: {getallen.Average():F2}");
                            Console.WriteLine($"Grootste van ingegeven getallen: {getallen.Max()}");

                            Array.Sort(getallen);
                            Array.Reverse(getallen);

                            Console.Write("Vul een getal in om de grotere getallen weer te geven: ");
                            int compare = Convert.ToInt32(Console.ReadLine());
                            int grootste = getallen[0];

                            if (compare > grootste)
                            {
                                Console.WriteLine("Niets is groter dan uw ingegeven getal.");
                            }
                            else
                            {
                                for (int j = 0; j < getallen.Length; j++)
                                {
                                    if (getallen[j] > compare) Console.Write(getallen[j] + " ");
                                    else break;
                                }
                            }
                        }
                        break;

                    case 7:
                        {
                            int[] a = new int[5];
                            int[] b = new int[5];
                            int[] c = new int[5];

                            for (int i = 0; i < a.Length; i++)
                            {
                                Console.Write(" geef een getal1 ");

                                a[i] = (Convert.ToInt32(Console.ReadLine()));
                                Console.Write(" geef een getal2 ");

                                b[i] = (Convert.ToInt32(Console.ReadLine()));
                            }

                            Console.WriteLine();
                            for (int i = 0; i < a.Length; i++)
                            {
                                c[i] = a[i] + b[i];
                            }

                            for (int i = 0; i < c.Length; i++)
                            {
                                Console.WriteLine($" getal {a[i]} + {b[i]}  = {c[i]}");
                            }
                            Console.ReadLine();
                        }
                        break;

                    case 8:
                        {
                            string[] questions = { "Do you like chocolate?", "Can you swim?", "Are you older than 30?", "Do you eat meat?", "Do you enjoy walking?", "Do you live in Antwerp?" };
                            int[] answers = new int[6];
                            int answer = 0;


                            Console.WriteLine("Kies een nummer voor elke vraag:\n 1. Yes \n 2.No");

                            for (int i = 0; i < questions.Length; i++)
                            {
                                Console.WriteLine(questions[i]);
                                answer = Convert.ToInt32(Console.ReadLine());
                                if (answer == 1 || answer == 2)
                                {
                                    answers[i] = answer;

                                }
                                else
                                {
                                    Console.WriteLine("invalid number");
                                }
                            }

                            Console.WriteLine("Your answers:");

                            for (int i = 0; i < answers.Length; i++)
                            {
                                Console.WriteLine(questions[i]);
                                switch (answers[i])
                                {
                                    case 0: Console.WriteLine("Invalid answer"); break;
                                    case 1: Console.WriteLine("Yes"); break;
                                    case 2: Console.WriteLine("No"); break;
                                }
                            }
                        }
                        break;

                    case 9:
                        //NIET NAAR KIJKEN!!!!
                        {
                            string[] waarden = new string[10];
                            for (int i = 0; i < waarden.Length; i++)
                            {
                                waarden[i] = InputStr($"Waarden {i + 1}: ");
                            }
                            string teVerwijderen = InputStr("Waarden vervangen door -1: ");
                            Console.WriteLine("1: alle elementen vervangen\n" +
                                                "2: eerste waarden vervangen (opdracht)\n");
                            int menuKeuze = InputInt("Keuze: ");
                            int arrayVerschil = 0;
                            if (menuKeuze == 1)
                            {
                                arrayVerschil = waarden.Length;
                                waarden = waarden.Where(val => val != teVerwijderen).ToArray();
                                arrayVerschil -= waarden.Length;
                            }
                            else
                            {
                                int index = Array.IndexOf(waarden, teVerwijderen);
                                if (index != -1)
                                {
                                    arrayVerschil = waarden.Length;
                                    waarden = waarden.Where((val, idx) => idx != index).ToArray();
                                    arrayVerschil -= waarden.Length;
                                }
                            }
                            if (arrayVerschil > 0)
                            {
                                Array.Resize(ref waarden, waarden.Length + arrayVerschil);
                                for (int i = waarden.Length - arrayVerschil; i < waarden.Length; i++)
                                {
                                    waarden[i] = "-1";
                                }
                                Console.WriteLine($"{arrayVerschil} item(s) vervangen");
                            }
                            for (int i = 0; i < waarden.Length; i++)
                            {
                                Console.Write(waarden[i] + " ");
                            }
                        }
                        break;
                    case 10:
                        {
                            int[] postcodes = { 1000, 1500, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 5500 };
                            int[] prijs = { 10, 15, 20, 25, 35, 40, 45, 50, 55, 60 };
                            Console.Write("Gewicht van het pakket (kg): ");
                            int gewicht = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Postcode: ");
                            int postcode = Convert.ToInt32(Console.ReadLine());
                            int index = -1;
                            bool gevonden = false;

                            for (int i = 0; i < postcodes.Length; i++)
                            {
                                if (postcodes[i] == postcode)
                                {
                                    gevonden = true;
                                    index = i;
                                }
                            }
                            if (gevonden)
                            {
                                int totPrijs = gewicht * prijs[index];
                                Console.WriteLine($"Dit zal {totPrijs} kosten.");
                            }
                            else
                            {
                                Console.WriteLine("Op deze postcode wordt niet geleverd.");
                            }
                        }
                        break;
                    case 11:
                        {
                            string familieNaam = InputStr("Wat is je achternaam/familienaam?: ");
                            string telefoonNr = InputStr("Wat is uw telefoonNr?: ");
                            string postcode = InputStr("Wat is jou postcode?: ");
                            telefoonNr = telefoonNr.TrimStart('0');
                            char tweedeLetter = Char.ToUpper(familieNaam[1]);
                            char eersteLetter = Char.ToLower(familieNaam[0]);
                            string wachtwoord = Char.ToString(Char.ToLower(familieNaam[1])) +
                                                Char.ToString(Char.ToUpper(familieNaam[0])) +
                                                Char.ToString(telefoonNr[0]) +
                                                Convert.ToString(Math.Pow(Convert.ToInt32(postcode.Substring(0,1)), 2));
                            Console.WriteLine($"Wachtwoord: {wachtwoord}");
                        }
                        break;

                    case 12:
                        {
                            //https://github.com/TomDilen/2021_03_04_Arrays
                        }
                        break;
                }
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        static int Input()
        {
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int InputInt(string tekst = "Getal: ")
        {
            Console.Write(tekst);
            return int.Parse(Console.ReadLine());
        }
        static string InputStr(string tekst = "String: ")
        {
            Console.Write(tekst);
            return Console.ReadLine();
        }
        static int RandomInt(int einde, int start = 1)
        {
            Random rnd = new Random();
            return (int)rnd.Next(start, einde);
        }
        static bool InputBool(string tekst = "j/n")
        {
            ConsoleKeyInfo keyStrike = new ConsoleKeyInfo();
            Console.WriteLine(tekst);
            keyStrike = Console.ReadKey(true);
            switch (Char.ToLower(keyStrike.KeyChar))
            {
                case 'y':
                case 'j': return true;
                case 'n': return false;
            }
            return false;
        }
    }
}

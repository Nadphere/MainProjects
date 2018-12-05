using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Yey
{
    class Persona
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public Persona(string name, string age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

    }

    class Maschio : Persona
    {
        public Maschio(string nameM, string ageM, string sexM) : base(nameM, ageM, sexM)
        {
            string[] lines = { "Name:" + nameM, "Age:" + ageM, "Sex:" + sexM, "" };

            string mydocpath1 =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string mydocpath2 = Path.Combine(mydocpath1, "Maschi.txt");            
                        
            StreamWriter b = new StreamWriter(mydocpath2);

            foreach (string line in lines)
            {
                b.WriteLine(line);
            }

            b.Dispose();

        }

        class Femmina : Persona
        {
            public Femmina(string nameF, string ageF, string sexF) : base(nameF, ageF, sexF)
            {
                string[] lines = { "Name:" + nameF, "Age:" + ageF, "Sex:" + sexF, "" };

                string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "Femmine.txt")))
                {
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(line);
                    }

                    outputFile.Dispose();

                }

            }


            class Program
            {
                static void Main(string[] args)
                {
                    bool run = true;

                    while (run == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Welcome to PeopleSaver. VERSION: 1.0");
                        Console.ResetColor();

                        Console.WriteLine("To save a person, press 1. To exit, press 0.");

                        string sel = Console.ReadLine();

                        if (sel == "1")
                        {
                            Console.Clear();

                            while (true)
                            {
                                Console.WriteLine("Alright, now insert the name of the person: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("");

                                Console.WriteLine("And now the age of the person: ");
                                string age = Console.ReadLine();
                                Console.WriteLine("");

                                Console.WriteLine("Is the person Male or Female?: ");
                                string sexB = Console.ReadLine();
                                string sex = sexB.ToLower();
                                Console.WriteLine("");

                                Console.WriteLine("Name: {0}\nAge: {1}\nSex: {2}", name, age, sex);
                                Console.WriteLine("Is that right? (y/n)");
                                string sceltaB = Console.ReadLine();
                                string scelta = sceltaB.ToLower();

                                if (scelta == "y" || scelta == "s" || scelta == "si" || scelta == "yes")
                                {
                                    if (sex == "male" || sex == "m")
                                    {
                                        Maschio m = new Maschio(name, age, sexB);
                                        Console.WriteLine("Persona salvata.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Femmina f = new Femmina(name, age, sexB);
                                        Console.WriteLine("Persona salvata.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                }
                                else if (scelta == "n" || scelta == "no")
                                {
                                    Console.Clear();
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input.");
                                }

                            }

                        }
                        else if (sel == "0")
                        {
                            run = false;
                        }
                        else
                        {
                            Console.Write("Invalid input.");
                            Console.Clear();
                        }
                    }


                }
            }
        }
    }
}
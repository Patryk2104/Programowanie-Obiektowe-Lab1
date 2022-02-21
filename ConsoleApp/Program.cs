using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp {
    
    class Program {
        static void Main(string[] args) {
            List<Person> people = new List<Person>();
            string key = null;
            string path = @"people.txt";
            do {
                Console.Clear();
                Console.WriteLine("Utworzył Patryk Myśliński - 18407");
                Console.WriteLine("1. Dodaj studenta");
                Console.WriteLine("2. Dodaj nauczyciela");
                Console.WriteLine("3. Wyświetl listę dodanych osób");
                Console.WriteLine("4. Zapisz listę do pliku");
                Console.WriteLine("5. Wyświetl zawartość pliku");
                Console.WriteLine("6. Nadpisz/Dodaj do pliku");
                Console.WriteLine("7. Zakończ");
                Console.Write("Wybierz opcję: ");
                key = Console.ReadLine();

                switch (key) {
                    case "1":
                    Student student = new Student();
                    Console.Write("Podaj imie: ");
                    student.set_first_name(Console.ReadLine());
                    Console.Write("Podaj nazwisko: ");
                    student.set_last_name(Console.ReadLine());
                    Console.Write("Podaj wiek: ");
                    student.set_age(Convert.ToInt16(Console.ReadLine()));
                    Console.Write("Podaj klasę: ");
                    student.set_class_name(Console.ReadLine());
                    people.Add(student);
                        break;
                    case "2":
                    Teacher teacher = new Teacher();
                    Console.Write("Podaj imie: ");
                    teacher.set_first_name(Console.ReadLine());
                    Console.Write("Podaj nazwisko: ");
                    teacher.set_last_name(Console.ReadLine());
                    Console.Write("Podaj wiek: ");
                    teacher.set_age(Convert.ToInt16(Console.ReadLine()));
                    Console.Write("Podaj przedmiot: ");
                    teacher.set_subject(Console.ReadLine());
                    people.Add(teacher);
                        break;
                    case "3":
                    Console.Clear();
                    Console.WriteLine("<- LISTA DODANYCH OSÓB ->\n");
                    //pętla foreach operuje po kolei na elementach z listy
                    foreach (var person in people) {
                        Console.WriteLine(person.show());
                    }
                    Console.WriteLine("\nKliknij przycisk, aby wrócić do menu...");
                    Console.ReadKey();
                        break;
                    case "4":
                    Console.Clear();
                    if (people.Count > 0) {
                        //zapisanie do pliku
                        StreamWriter sw = new StreamWriter(path);
                        foreach (var person in people) {
                            sw.WriteLine(person.show());
                        }
                        sw.Close();
                        Console.WriteLine("Lista zapisana!");
                           
                    } else {
                        Console.WriteLine("Lista jest pusta!");
                    }


                    Console.WriteLine("\nKliknij przycisk, aby wrócić do menu...");
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("<- ZAWARTOŚĆ PLIKU " + path + " ->\n");
                    StreamReader sr = new StreamReader(path);
                    string s;
                    //odczyt z pliku
                    do {
                        s = sr.ReadLine();
                        Console.WriteLine(s);
                    } while (s != null);
                    sr.Close();
                    Console.WriteLine("\nKliknij przycisk, aby wrócić do menu...");
                    Console.ReadKey();
                    break;
                case "6":
                    Console.Clear();
                    Console.Write(path + ": ");
                    string line = Console.ReadLine();
                    Console.WriteLine("1. Nadpisz plik");
                    Console.WriteLine("2. Dodaj do pliku");
                    Console.Write("Wybierz opcję: ");
                    string opt = Console.ReadLine();
                    //instrukcje warunkowe
                    if (opt == "1") {
                        StreamWriter sw = new StreamWriter(path); //nadpisanie pliku wprowadzonym tekstem
                        sw.WriteLine(line);                             
                        sw.Close();
                    } else if (opt == "2") {
                        File.AppendAllText(path, line); //dodanie wpisanego tekstu do pliku
                    } else {
                        Console.WriteLine("Została wybrana nieprawidłowa opcja!");
                    }
                    break;
                } 
            } while (key != "7");
        }



    }
}

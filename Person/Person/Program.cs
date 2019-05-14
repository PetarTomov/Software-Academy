using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>();

            while (true)
            {
                Console.WriteLine("Commands list: add, remove, sort, display, add multiple and end.");
                Console.WriteLine("Input command: ");
                var command = Console.ReadLine().ToLower();

                if (command.Equals("end"))
                {
                    break;
                }
                else if (command.Equals("add"))
                {
                    Console.WriteLine("Input first name: ");
                    var firstName = Console.ReadLine();

                    Console.WriteLine("Input last name: ");
                    var lastName = Console.ReadLine();

                    Console.WriteLine("Input birth date {dd/MM/yyyy}: ");


                    if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime birthDate))
                    {
                        Console.WriteLine("Invalid date!");
                        continue;
                    }

                    personList.Add(new Person(firstName, lastName, birthDate));
                }
                else if (command.Equals("remove"))
                {
                    Console.WriteLine("Input last name: ");
                    var lastName = Console.ReadLine();

                    var person = personList.FirstOrDefault(x => x.LastName.Equals(lastName));

                    if (person == null)
                    {
                        Console.WriteLine("No such person found!");
                        continue;
                    }

                    personList.Remove(person);
                    Console.WriteLine("Person removed");
                }
                else if (command.Equals("sort"))
                {
                    personList = personList.OrderBy(x => x.LastName).ToList();
                    Console.WriteLine("Sorted successfully!");
                }
                else if (command.Equals("display"))
                {
                    foreach (var p in personList)
                    {
                        Console.WriteLine($"{p.FirstName} {p.LastName} : {p.BirthDate.ToString("dd/MM/yyyy")}");
                    }
                }
                else if (command.Equals("add multiple"))
                {
                    Console.WriteLine("Input amount: ");
                    var n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Input first name: ");
                        var firstName = Console.ReadLine();

                        Console.WriteLine("Input last name: ");
                        var lastName = Console.ReadLine();

                        Console.WriteLine("Input birth date {dd/MM/yyyy}: ");

                        if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime birthDate))
                        {
                            Console.WriteLine("Invalid date!");
                            i--;
                            continue;
                        }

                        personList.Add(new Person(firstName, lastName, birthDate));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}

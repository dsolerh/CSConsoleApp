using System;
using CSClassLib;

using static System.Console;

namespace CSConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var person = new Person();
            // person.Name = "Daniel";
            // person.BirthDate = DateTime.Now;
            // var alice = new Person
            // {
            //     Name = "Alice Jones",
            //     BirthDate = new DateTime(1998, 3, 7),
            //     FavoriteWonder = WondersOfTheWorld.ColossusOfRhodes,
            //     BucketList =
            //         WondersOfTheWorld.MausoleumAtHalicarnassus |
            //         WondersOfTheWorld.LighthouseOfAlexandria
            // };

            // alice.Children.Add(new Person { Name = "Alfred" });
            // alice.Children.Add(new Person { Name = "Zoe" });


            // WriteLine(person);
            // WriteLine(alice);
            // WriteLine(
            //     "{0} {1}",
            //     arg0: alice.Name,
            //     arg1: alice.BucketList
            // );
            // WriteLine(
            //     String.Format(
            //         "{0} has {1} Children{2}:",
            //         alice.Name,
            //         alice.Children.Count,
            //         alice.Children.Count > 1 ? 's' : ""
            //     )
            // );
            // foreach (var child in alice.Children)
            // {
            //     WriteLine($"\t{child.Name}");
            // }

            // BankAccount.InterestRate = 0.012M;
            // var ba1 = new BankAccount
            // {
            //     AccountName = alice.Name,
            //     Balance = 2400M
            // };
            // WriteLine(
            //     String.Format(
            //         "{0} earned {1:C} interest.",
            //         ba1.AccountName,
            //         ba1.Balance * BankAccount.InterestRate
            //     )
            // );

            // var ba2 = new BankAccount
            // {
            //     AccountName = person.Name,
            //     Balance = 1200M
            // };
            // WriteLine(
            //     String.Format(
            //         "{0} earned {1:C} interest.",
            //         ba2.AccountName,
            //         ba2.Balance * BankAccount.InterestRate
            //     )
            // );

            // var blankPerson = new Person();
            // WriteLine(
            //     format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
            //     arg0: blankPerson.Name,
            //     arg1: blankPerson.HomePlanet,
            //     arg2: blankPerson.Instantiated
            // );

            // WriteLine(new ThingsOfDefault());
            // (string, int) fruit = blankPerson.GetFruit();
            // WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            // var fruit2 = blankPerson.GetNamedFruit();
            // WriteLine($"{fruit2.Name}, {fruit2.Number} there are.");

            // int a = 10;
            // int b = 20;
            // int c = 30;
            // WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            // alice.PassingParameters(a, ref b, out c);
            // WriteLine($"After: a = {a}, b = {b}, c = {c}");

            // WriteLine(alice.Origin);
            // WriteLine(alice.Greeting);
            // WriteLine($"{alice.Name} is {alice.Age} years old");

            // alice.Shout += Harry_Shout;
            // alice.Poke();
            // alice.Poke();
            // alice.Poke();
            // alice.Poke();
            // alice.Poke();

            // Person[] people =
            // {
            //     new Person { Name = "Simon" },
            //     new Person { Name = "Jenny" },
            //     new Person { Name="Adam" },
            //     new Person {Name="Richard" }
            // };
            // WriteLine("Initial list of people:");
            // foreach (var person in people)
            // {
            //     WriteLine($"{person.Name}");
            // }
            // WriteLine("Use Person's IComparable implementation to sort: ");
            // Array.Sort(people);
            // foreach (var person in people)
            // {
            //     WriteLine($"{person.Name}");
            // }
            // WriteLine("Use PersonComparer's IComparer implementation to sort: ");
            // Array.Sort(people, new PersonComparer());
            // foreach (var person in people)
            // {
            //     WriteLine($"{person.Name}");
            // }

            // var t1 = new Thing();
            // t1.Data = 42;
            // WriteLine($"Thing with an integer: {t1.Process(42)}");
            // var t2 = new Thing();
            // t2.Data = "apple";
            // WriteLine($"Thing with a string: {t2.Process("apple")}");

            // var gt1 = new GenericThing<int>();
            // gt1.Data = 42;
            // WriteLine($"GenericThing with an integer:{gt1.Process(42)}");
            // var gt2 = new GenericThing<string>();
            // gt2.Data = "apple";
            // WriteLine($"GenericThing with a string:{gt2.Process("apple")}");

            // string number1 = "4";
            // WriteLine(
            //     "{0} squared is {1}",
            //     arg0: number1,
            //     arg1: Squarer.Square<string>(number1)
            // );

            // byte number2 = 3;
            // WriteLine(
            //     "{0} squared is {1}",
            //     arg0: number2,
            //     arg1: Squarer.Square(number2)
            // );

            // Employee john = new Employee
            // {
            //     Name = "John Jones",
            //     BirthDate = new DateTime(1990, 7, 28)
            // };
            // john.WriteToConsole();
            // john.EmployeeCode = "JJ001";
            // john.HireDate = new DateTime(2014, 11, 23);
            // WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

            // WriteLine("".IsValidEmail());

            var r = new Rectangle(3, 4.5);
            WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area:{r.Area}");
            var s = new Square(5);
            WriteLine($"Square H: {s.Height}, W: {s.Width}, Area:{s.Area}");
            var c = new Circle(2.5);
            WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area:{c.Area}");

        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }

    }
}

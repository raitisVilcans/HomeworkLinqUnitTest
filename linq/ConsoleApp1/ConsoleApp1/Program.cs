using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

using ConsoleApp1;
using System.Collections.Immutable;

List<Student> students = new List<Student>();
List<Student2> students2 = new List<Student2>();


students2.Add(new Student2() { Id = 1, Name = "Vards" });
students2.Add(new Student2() { Id = 2, Name = "Vards2" });
students2.Add(new Student2() { Id = 3, Name = "Vards2" });




students.Add(new Student() { Id = 1, Name = "Raitis", Type = 1 , Type2 = 1, Surename = "Vilcans", Age = 55 });
students.Add(new Student() { Id = 2, Name = "Janis", Type = 2 , Type2 = 3, Surename = "Berzins", Age = 5 });
students.Add(new Student() { Id = 3, Name = "Juris", Type = 3 , Type2 = 2, Surename = "Kalnins", Age = 15 });
students.Add(new Student() { Id = 4, Name = "Peteris", Type = 2 , Type2 = 1, Surename = "Berzs", Age = 18 });
students.Add(new Student() { Id = 5, Name = "Jana", Type = 1 , Type2 = 2, Surename = "Ozola", Age = 21 });
students.Add(new Student() { Id = 6, Name = "Lasma", Type = 2 , Type2 = 1, Surename = "Berzina", Age = 28 });
students.Add(new Student() { Id = 7, Name = "Liga", Type = 3 , Type2 = 3, Surename = "Kalnina", Age = 100 });



Student studentOne = new Student() { Id = 1, Name = "Raitis", Type = 1, Type2 = 1, Surename = "Vilcans", Age = 55 };

Student studentOneCopy = new Student() { Id = 1, Name = "Raitis", Type = 1, Type2 = 1, Surename = "Vilcans", Age = 55 };


bool result = students.Contains(studentOneCopy);

Console.WriteLine(result);

Console.ReadLine();



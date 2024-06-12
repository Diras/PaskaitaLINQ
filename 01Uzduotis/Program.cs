using _01Uzduotis;

List<Student> students = new List<Student>
        {
            new Student { Name = "Jonas", Grade = 8, Age = 20 },
            new Student { Name = "Petras", Grade = 5, Age = 22 },
            new Student { Name = "Ona", Grade = 9, Age = 24 },
            new Student { Name = "Rasa", Grade = 7, Age = 26 },
            new Student { Name = "Andrius", Grade = 6, Age = 23 },
            new Student { Name = "Gabija", Grade = 7, Age = 27 }
        };

List<Student> daugiau8MazejimoTvarka = students.Where(stud => stud.Grade >= 8).OrderByDescending(stud => stud.Grade).ToList();
List<Student> jaunesni25Pazymiai6ir9 = students.Where(stud => stud.Grade == 8 || stud.Grade == 6 && stud.Age <25).OrderBy(stud => stud.Grade).ToList();
double vidurkis = students.Average(stud => stud.Grade);
int max = students.Max(stud => stud.Grade);
int min = students.Min(stud => stud.Grade);
Student jauniausias = students.MinBy(stud => stud.Age);
Student vyriausias = students.OrderBy(stud => stud.Age).Last();
int studentaiSu7 = students.Where((stud) => stud.Grade == 7).Count();
List<Student> trisSuAuksciausiais = students.OrderByDescending(stud => stud.Grade).Take(3).ToList();


daugiau8MazejimoTvarka.ForEach(stud => Console.WriteLine($"1.: {stud.Name} - {stud.Grade} - {stud.Age}"));
jaunesni25Pazymiai6ir9.ForEach(stud => Console.WriteLine($"2.: {stud.Name} - {stud.Grade} - {stud.Age}"));
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");
Console.WriteLine($"Jauniausias: {jauniausias.Name} {jauniausias.Age}");
Console.WriteLine($"Vyriausias: {vyriausias.Name} {vyriausias.Age}");
Console.WriteLine($"Studentu skaicius kurie turi 7: {studentaiSu7}");
trisSuAuksciausiais.ForEach(stud => Console.WriteLine($"EXTRA.: {stud.Name} - {stud.Grade} - {stud.Age}"));

Console.ReadKey();
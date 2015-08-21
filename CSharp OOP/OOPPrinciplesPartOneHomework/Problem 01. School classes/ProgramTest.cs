namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;


    class ProgramTest
    {
        static void Main()
        {
            var disciplines = LoadDisciplines(); 
            School newSchool = new School("OU \"Yane Sandanski\"");
            newSchool.AddClass(new Class("1A"));
            newSchool.Classes[0].AddTeacher(new Teacher("Dora", "Chekanova", disciplines));
            newSchool.Classes[0].AddTeacher(new Teacher("Mita", "Georgieva", disciplines));
            newSchool.Classes[0].AddTeacher(new Teacher("Ivan", "Uzunov", disciplines));
            newSchool.AddClass(new Class("1B"));
            newSchool.Classes[1].AddTeacher(new Teacher("Desislava", "Botseva", disciplines));
            newSchool.Classes[1].AddTeacher(new Teacher("Elena", "Madjarova", disciplines));
            newSchool.Classes[1].AddTeacher(new Teacher("Mariyana", "Dimitrova", disciplines));
            Console.WriteLine("TEST FOR SCHOOL: \n" + newSchool);
            Class someClass = newSchool.Classes[0];
            Console.WriteLine("TEST FOR CLASS: \n" + someClass);
            Teacher someTeacher = newSchool.Classes[1].Teachers[1];
            Console.WriteLine("TEST FOR TEACHER: \n" + someTeacher);
            Console.WriteLine();
            Discipline someDiscipline = newSchool.Classes[0].Teachers[0].Disciplines[2];
            Console.WriteLine("TEST FOR DISCIPLINE: \n" + someDiscipline);
            Console.WriteLine();
            Student someStudent = new Student("Ivan", "Vasilev", 13);
            Console.WriteLine("TEST FOR STUDENT: \n" + someStudent);
            Console.WriteLine();
            Console.WriteLine("TEST FOR COMMENT FIELD: " + someStudent.Comment);
            someStudent.Comment = "{0} is the laziest student in the entire school!";
            Console.WriteLine();
            Console.WriteLine("TEST FOR COMMENT FIELD AFTER CHANGING THE TEXT: " + someStudent.Comment, someStudent.FirstName);
        }

        static List<Discipline> LoadDisciplines()
        {
            List<Discipline> disciplines = new List<Discipline>();

            disciplines.Add(new Discipline("Reading", 45, 90));
            disciplines.Add(new Discipline("Writing", 45, 200));
            disciplines.Add(new Discipline("Math", 45, 600));
            disciplines.Add(new Discipline("Art", 30, 30));
            disciplines.Add(new Discipline("Music", 30, 15));

            return disciplines;
        }
    }
}

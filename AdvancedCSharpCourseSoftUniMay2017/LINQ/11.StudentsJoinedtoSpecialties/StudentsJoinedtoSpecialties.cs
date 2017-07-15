using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StudentsJoinedtoSpecialties
{
    public class StudentsJoinedtoSpecialties
    {
        public class StudentSpecialty
        {
            public string SpecialtyName { get; set; }
            public int FacultyNumber { get; set; }
        }

        public class Student
        {
            public string StudentName { get; set; }
            public int FacultyNumber { get; set; }
        }

        public static void Main()
        {
            List<StudentSpecialty> listOfSpecialties = new List<StudentSpecialty>();
            List<Student> listOfStudents = new List<Student>();

            string input = Console.ReadLine();

            while (input != "Students:")
            {
                var inputArgs = input.Split();

                var current = new StudentSpecialty
                {
                    SpecialtyName = inputArgs[0] + " " + inputArgs[1],
                    FacultyNumber = int.Parse(inputArgs[2])

                };
                listOfSpecialties.Add(current);

                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine();

            while (input2 != "END")
            {
                var input2Args = input2.Split();

                var current = new Student
                {
                    FacultyNumber = int.Parse(input2Args[0]),
                    StudentName = input2Args[1] + " " + input2Args[2],
                };

                listOfStudents.Add(current);
                input2 = Console.ReadLine();
            }

            
            var result = listOfStudents.Join(listOfSpecialties, student => student.FacultyNumber, specialty => specialty.FacultyNumber, (student, specialty) => new { student.StudentName, student.FacultyNumber, specialty.SpecialtyName }).OrderBy(student => student.StudentName);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.StudentName} {item.FacultyNumber} {item.SpecialtyName}");
            }
        }
    }

    public class StudentSpecialty
    {
        string SpecialtyName { get; set; }
        int FacultyNumber { get; set; }
    }

    public class Student
    {
        string StudentName { get; set; }
        int FacultyNumber { get; set; }
    }
}


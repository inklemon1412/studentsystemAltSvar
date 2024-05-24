using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsystemtest
{
    internal class Student
    {
        public string StudentName { get; set; }
        public string MainStudy { get; set; }
       
        public int Age { get; set; }
        public int ID { get; set; }

        public Student(string studentName, string mainStudy, int age, int id)
        {
            StudentName = studentName;
            MainStudy = mainStudy;
           
            Age = age;
            ID = id;
        }

        public Student() 
        {
        }

            internal class Subject
            {
                public string SubjectCode { get; set; }
                public string SubjectName { get; set; }
                public int AmountOfPoints { get; set; }

                public Subject(string subjectCode, string subjectName, int amountOfPoints)
                {
                    SubjectCode = subjectCode;
                    SubjectName = subjectName;
                    AmountOfPoints = amountOfPoints;
                }

                public Subject()
                {

                }

            }
            public void SkrivUtInfo()
        {
            List<Subject> subjects = new List<Subject>();
            Subject subject1 = new Subject("ENG330", "Phonetikk", 15);
            subjects.Add(subject1);
            Subject subject2 = new Subject("ENG240", "Grammatikk", 20);
            subjects.Add(subject2);
            Subject subject3 = new Subject("ENG 100", "Basics", 5);
            subjects.Add(subject3);
            Subject subject4 = new Subject("ENG 110", "Literatur", 10);

            List<Student>students = new List<Student>();
            Student student1 = new Student("Jonas", "Engelsk Bachelor", 27, 485);
            students.Add(student1);
            Student student2 = new Student("Per", "Engelsk 1 års studie", 21, 100);
            students.Add(student2);
            Student student3 = new Student("Ann", "Engelsk Master", 31, 221);
            students.Add(student3);



            Console.WriteLine("Studenter:");

            foreach (Student student in students)
            {
                Console.WriteLine($"Navn: {student.StudentName}, Alder: {student.Age}, Studieprogram: {student.MainStudy}, Student ID: {student.ID}");
            }
            Console.WriteLine("Emner:");
            foreach(Subject subject in subjects)
            {
                Console.WriteLine($"Fagkode: {subject.SubjectCode}, Fagnavn: {subject.SubjectName}, Studiepoeng: {subject.AmountOfPoints}");
            }
            Console.WriteLine("Emner studenter tar:");
            {
                Console.WriteLine($"Navn: {student1.StudentName}, Emner: {subject1.SubjectName}, {subject2.SubjectName}");
                Console.WriteLine($"Navn: {student2.StudentName}, Emner: {subject3.SubjectName}, {subject2.SubjectName}");
                Console.WriteLine($"Navn: {student3.StudentName}, Emner: {subject1.SubjectName}, {subject2.SubjectName}, {subject4.SubjectName}");
            }
        }
    }
}









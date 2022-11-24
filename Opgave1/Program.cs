using Opgave1.Classes;
using Opgave1.Code.Enums;

Student Alexander = new Student(1, "Alexander", "K.H. Runge", "01-01-2003");
Student Amanda = new Student(2, "Amanda", "E.V. Gudmand", "01-04-1998");
Student Dennis = new Student(3, "Dennis", "D.B Paaske", "22-01-1981");
Student Ozan = new Student(4, "Ozan", "Kprkmaz", "10-10-1992");
Student Camilla = new Student(5, "Camilla", "Kløjgaard", "12-07-1995");
Student Rune = new Student(6, "Rune", "Hansen", "13-05-1997");
Student Sanjit = new Student(7, "Sanjit", "Pouden", "11-05-1998");
Student Rasmus = new Student(8, "Rasmus", "Wiell", "12-12-1995");
Student Temp = new Student(9, "Temp", "Name", "01-01-2000");

Teacher Niels = new Teacher("IT", "Niels", "Olesen", "02-02-1971");
Teacher Peter = new("IT", "Peter", "Lindenskov", "01-01-1970");

//Course OOP = new Course("OOP", Niels);
//Course Grund = new Course("Grundlæggende programmering", Niels);
//Course Studieteknik = new Course("Studieteknik", Niels);

Course clientSide = new(CourseEnum.ClientsideProgrammering.ToString(), Peter);
Course studieteknik = new(CourseEnum.Studieteknik.ToString(), Niels);
Course grundPro = new(CourseEnum.GrundlæggendeProgrammering.ToString(), Niels);
Course oop = new(CourseEnum.OOP.ToString(), Niels);
Course databaseprog = new Course(CourseEnum.DatabaseProgrammering.ToString(), Niels);
Course computertek = new Course(CourseEnum.Computerteknologi.ToString(), Niels);
Course netværk = new Course(CourseEnum.Netværk.ToString(), Niels);

Enrollment _enrollmentList = new();
_enrollmentList.EnrollList = new List<Enrollment>()
{
    new(Alexander, clientSide),
    new(Alexander, studieteknik),
    new(Alexander, oop),
    new(Alexander, grundPro),
    new(Alexander, databaseprog),
    new(Alexander, computertek),
    new(Alexander, netværk),

    new(Sanjit, studieteknik),
    new(Sanjit, grundPro),
    new(Sanjit, oop),
    new(Sanjit, databaseprog),
    new(Sanjit, computertek),
    new(Sanjit, netværk),

    new(Amanda, studieteknik),
    new(Amanda, grundPro),
    new(Amanda, oop),
    new(Amanda, databaseprog),
    new(Amanda, computertek),
    new(Amanda, netværk),

    new(Dennis, studieteknik),
    new(Dennis, oop),
    new(Dennis, grundPro),
    new(Dennis, databaseprog),
    new(Dennis, computertek),
    new(Dennis, netværk),

    new(Ozan, grundPro),
    new(Ozan, oop),
    new(Ozan, databaseprog),
    new(Ozan, computertek),
    new(Ozan, netværk),

    new(Camilla, grundPro),
    new(Camilla, oop),
    new(Camilla, databaseprog),
    new(Camilla, computertek),
    new(Camilla, netværk),

    new(Rune, oop),
    new(Rasmus, oop),
    new(Temp, oop)
};
//{
//    new Enrollment(Alexander, OOP),
//    new Enrollment(Alexander, Grund),
//    new Enrollment(Alexander, Studieteknik),
//    new Enrollment(Amanda, OOP),
//    new Enrollment(Amanda, Grund),
//    new Enrollment(Amanda, Studieteknik),
//    new Enrollment(Dennis, OOP),
//    new Enrollment(Dennis, Grund),
//    new Enrollment(Dennis, Studieteknik),
//    new Enrollment(Ozan, OOP),
//    new Enrollment(Ozan, Grund),
//    new Enrollment(Camilla, OOP),
//    new Enrollment(Camilla, Grund),
//};

//foreach (var item in _enrollments)
//{
//    Console.WriteLine(item._studentInfo._firstName + " " + item._studentInfo._lastName + " is enrolled in; " + item._courseInfo._courseName + ", taught by " + item._courseInfo._teacherInfo._firstName + " " + item._courseInfo._teacherInfo._lastName);
//}

_enrollmentList.EnrollList.Sort();

foreach (var item in _enrollmentList.EnrollList)
{
    Console.WriteLine($"{item._studentInfo._firstName} {item._studentInfo._lastName}  Course: {item._courseInfo._courseName}  Teacher: {item._courseInfo._teacherInfo._firstName} {item._courseInfo._teacherInfo._lastName} ");
}

try
{
    oop.CourseStudentAmount(oop.StudentList(_enrollmentList));
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
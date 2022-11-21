Student Alexander = new Student(1, "Alexander", "K.H. Runge", new DateTime(2003, 1, 1));
Student Amanda = new Student(2, "Amanda", "E.V. Gudmand", new DateTime(1998, 4, 1));
Student Dennis = new Student(3, "Dennis", "D.B Paaske", new DateTime(1981, 1, 22));
Student Ozan = new Student(4, "Ozan", "Kprkmaz", new DateTime(1992, 10, 10));
Student Camilla = new Student(5, "Camilla", "Kløjgaard", new DateTime(1995, 7, 12));

Teacher Niels = new Teacher("IT", "Niels", "Olesen", new DateTime(1971, 2, 2));

Course OOP = new Course("OOP", Niels);
Course Grund = new Course("Grundlæggende programmering", Niels);
Course Studieteknik = new Course("Studieteknik", Niels);

List<Enrollment> _enrollments = new List<Enrollment>()
{
    new Enrollment(Alexander, OOP),
    new Enrollment(Alexander, Grund),
    new Enrollment(Alexander, Studieteknik),
    new Enrollment(Amanda, OOP),
    new Enrollment(Amanda, Grund),
    new Enrollment(Amanda, Studieteknik),
    new Enrollment(Dennis, OOP),
    new Enrollment(Dennis, Grund),
    new Enrollment(Dennis, Studieteknik),
    new Enrollment(Ozan, OOP),
    new Enrollment(Ozan, Grund),
    new Enrollment(Camilla, OOP),
    new Enrollment(Camilla, Grund),
};

foreach (var item in _enrollments)
{
    Console.WriteLine(item._studentInfo._firstName + " " + item._studentInfo._lastName + " is enrolled in; " + item._courseInfo._courseName + ", taught by " + item._courseInfo._teacherInfo._firstName + " " + item._courseInfo._teacherInfo._lastName);
}

Console.ReadLine();